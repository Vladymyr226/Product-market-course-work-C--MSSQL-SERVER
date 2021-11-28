using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Чек : Form
    {
        public Чек()
        {
            InitializeComponent();

            Font F = new Font("Calibri", 12, FontStyle.Bold);
            dataGridViewТоварФормированиеЧека.ColumnHeadersDefaultCellStyle.Font = F;
            dataGridViewПродажиТоваровФормированиеЧека.ColumnHeadersDefaultCellStyle.Font = F;

            dataGridViewТоварФормированиеЧека.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТоварФормированиеЧека.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТоварФормированиеЧека.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТоварФормированиеЧека.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТоварФормированиеЧека.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТоварФормированиеЧека.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТоварФормированиеЧека.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТоварФормированиеЧека.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewПродажиТоваровФормированиеЧека.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewПродажиТоваровФормированиеЧека.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewПродажиТоваровФормированиеЧека.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //https://www.cyberforum.ru/windows-forms/thread2272408.html
        const string connectionString = @"Data Source=DESKTOP-16PLM1Q\SQLEXPRESS; Initial Catalog=ProductMarket; Trusted_Connection=True;";
        private void refreshDataTableФормированиеЧекаТовар()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewТоварФормированиеЧека.Rows.Clear();

            string query = "SELECT * FROM Товар";
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);
            SqlDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Внимание!");
            }
            else
            {
                while (dbReader.Read())
                {
                    //Выводим данные
                    dataGridViewТоварФормированиеЧека.Rows.Add(dbReader["ID"], dbReader["Наименование"], dbReader["Цена"], dbReader["Вес"],
                    dbReader["Ед_изм"], dbReader["Производитель"], dbReader["Описание"], dbReader["Срок_годности"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }
        private void Чек_Load(object sender, EventArgs e)
        {
            refreshDataTableФормированиеЧекаТовар();
            buttonСформироватьИРаспечататьЧек.Enabled = false;
            buttonУдалитьЗаписьИзЧека.Enabled = false;
            buttonДобавитьВЧек.Enabled = false;

            this.сотрудникTableAdapter.Fill(this.productMarketDataSet.Сотрудник);
        }
        private void calculateTotalPrice()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Продажа";
            SqlCommand tmpDbCommand = new SqlCommand(tmpQueryGetMaxID, dbConnection);
            int maxID = (int)tmpDbCommand.ExecuteScalar();

            string querySumOfCheck = $@"SELECT SUM(Цена_продажи) FROM Продажи_товаров WHERE Продажа_ID = {maxID}";
            SqlCommand dbCommandForCheck = new SqlCommand(querySumOfCheck, dbConnection);

            double fullPrice = (double)dbCommandForCheck.ExecuteScalar();
            textBoxОбщаяСумма.Text = fullPrice.ToString();

            dbConnection.Close();
        }
        private void buttonСформироватьНовыйЧек_Click(object sender, EventArgs e)
        {
            refreshDataTableФормированиеЧекаТовар();
            textBoxОбщаяСумма.Text = "";
            dataGridViewПродажиТоваровФормированиеЧека.Rows.Clear();

            buttonСформироватьПродажу.Enabled = true;
            buttonДобавитьВЧек.Enabled = false;

            numericUpDownКоличествоВыбранногоТовара.Value = 1;
        }
        private void buttonУдалитьЗаписьИзЧека_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            textBoxОбщаяСумма.Text = "";

            if (dataGridViewПродажиТоваровФормированиеЧека.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку из чека!", "Внимание!");
                return;
            }

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Продажа";
            SqlCommand tmpDbCommand = new SqlCommand(tmpQueryGetMaxID, dbConnection);
            int maxID = (int)tmpDbCommand.ExecuteScalar();

            int index = dataGridViewПродажиТоваровФормированиеЧека.SelectedRows[0].Index;

            string ID = dataGridViewПродажиТоваровФормированиеЧека.Rows[index].Cells[0].Value.ToString();

            string query = $@"DELETE FROM Продажи_товаров WHERE Продажа_ID = {maxID} And Товар_ID = {ID}";
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                dataGridViewПродажиТоваровФормированиеЧека.Rows.RemoveAt(index);
                calculateTotalPrice();
                return;
            }
            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");


            dbConnection.Close();
        }
        private void buttonДобавитьВЧек_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            textBoxОбщаяСумма.Text = "";

            if (dataGridViewТоварФормированиеЧека.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Продажа";
            SqlCommand tmpDbCommand = new SqlCommand(tmpQueryGetMaxID, dbConnection);
            int maxID = (int)tmpDbCommand.ExecuteScalar();


            int index = dataGridViewТоварФормированиеЧека.SelectedRows[0].Index;


            string Товар_ID = dataGridViewТоварФормированиеЧека.Rows[index].Cells[0].Value.ToString();
            string Наименование = Convert.ToString(dataGridViewТоварФормированиеЧека.Rows[index].Cells[1].Value.ToString());
            int Количество = Convert.ToInt32(numericUpDownКоличествоВыбранногоТовара.Value);
            float tmpЦенаТовара = (float)Convert.ToDouble(dataGridViewТоварФормированиеЧека.Rows[index].Cells[2].Value);
            float Цена_продажи = (float)(Количество * Convert.ToDouble(tmpЦенаТовара));


            string query = $@"INSERT INTO Продажи_товаров (Продажа_ID, Товар_ID, Наименование, Количество, Цена_продажи)
            VALUES({maxID}, '{Товар_ID}', '{Наименование}', '{Количество}', {Цена_продажи})";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                return;
            }

            //--------------------------------------------------------
            dataGridViewПродажиТоваровФормированиеЧека.Rows.Clear();

            string queryReadDownTable = $@"SELECT Товар_ID, Наименование, Количество, Цена_продажи FROM Продажи_товаров WHERE Продажа_ID = {maxID}";
            SqlCommand dbCommandActually = new SqlCommand(queryReadDownTable, dbConnection);
            SqlDataReader dbReader = dbCommandActually.ExecuteReader();

            while (dbReader.Read())
            {

                dataGridViewПродажиТоваровФормированиеЧека.Rows.Add(dbReader["Товар_ID"], dbReader["Наименование"], dbReader["Количество"], dbReader["Цена_продажи"]);
            }
            calculateTotalPrice();
            dataGridViewПродажиТоваровФормированиеЧека.Height += 30;
            buttonСформироватьИРаспечататьЧек.Enabled = true;
            buttonУдалитьЗаписьИзЧека.Enabled = true;

            dbReader.Close();
            dbConnection.Close();
        }
        private void buttonСформироватьПродажу_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            buttonДобавитьВЧек.Enabled = true;

            buttonСформироватьПродажу.Enabled = false;

            DateTime dt = DateTime.Now;
            string Сотрудник_ID = comboBoxВыборКассира.Text.ToString();

            string query = $@"INSERT INTO Продажа (Дата_время, Сотрудник_ID) VALUES('{dt}', '{Сотрудник_ID}')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                buttonСформироватьПродажу.Enabled = false;
                return;
            }

            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            dbConnection.Close();
        }
        private void buttonПерейтиКСправочнику_Click(object sender, EventArgs e)
        {
            Товар товар = new Товар();
            товар.ShowDialog();
        }

        private void buttonПерейтиНаГлавноеОкно_Click(object sender, EventArgs e)
        {
            Пуск пуск = new Пуск();
            пуск.ShowDialog();
        }
        private void textBoxФильтрТоварПриФормированииЧека_TextChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewТоварФормированиеЧека.Rows.Clear();
            string querry = "SELECT [ID], [Наименование], [Цена], [Вес], [Ед_изм], [Производитель], [Описание], [Срок_годности]" +
            " FROM [Товар] WHERE [Наименование] LIKE '%" + textBoxФильтрТоварПриФормированииЧека.Text + "%'";
            SqlCommand command = new SqlCommand(querry, dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewТоварФормированиеЧека.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
            }
        }
        //Print
        private void buttonСформироватьИРаспечататьЧек_Click(object sender, EventArgs e)
        {
            printPreviewDialogФормированиеЧека.ShowDialog();
        }
        private void printDocumentЧек_PrintPage(object sender, PrintPageEventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            Bitmap bmp = new Bitmap(dataGridViewПродажиТоваровФормированиеЧека.Size.Width + 10, dataGridViewПродажиТоваровФормированиеЧека.Size.Height + 10);

            dataGridViewПродажиТоваровФормированиеЧека.DrawToBitmap(bmp, dataGridViewПродажиТоваровФормированиеЧека.Bounds);

            const string line = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Продажа";
            SqlCommand tmpDbCommand = new SqlCommand(tmpQueryGetMaxID, dbConnection);
            int maxID = (int)tmpDbCommand.ExecuteScalar();

            e.Graphics.DrawString($"Продуктовый магазин 69", new Font("Calibri", 16, FontStyle.Bold), Brushes.Black, new PointF(290, 25));

            e.Graphics.DrawString($"Чек № {maxID}", new Font("Calibri", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 50));
            e.Graphics.DrawString($"Дата: {DateTime.Now}", new Font("Calibri", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 100));
            e.Graphics.DrawString($"Касир: {comboBoxВыборКассира.Text}", new Font("Calibri", 16, FontStyle.Bold), Brushes.Black, new PointF(600, 100));

            e.Graphics.DrawString(line, new Font("Calibri", 16, FontStyle.Bold), Brushes.Green, new PointF(50, 125));

            e.Graphics.DrawImage(bmp, 100, 150);

            e.Graphics.DrawString(line, new Font("Calibri", 16, FontStyle.Bold), Brushes.Green,
                new PointF(dataGridViewПродажиТоваровФормированиеЧека.Size.Width - 440, dataGridViewПродажиТоваровФормированиеЧека.Size.Height + 200));

            e.Graphics.DrawString($"СУММА", new Font("Calibri", 18, FontStyle.Bold), Brushes.Red,
                  new PointF(dataGridViewПродажиТоваровФормированиеЧека.Size.Width - 440, dataGridViewПродажиТоваровФормированиеЧека.Size.Height + 225));

            e.Graphics.DrawString(textBoxОбщаяСумма.Text, new Font("Calibri", 18, FontStyle.Bold), Brushes.Red,
            new PointF(dataGridViewПродажиТоваровФормированиеЧека.Size.Width + 160, dataGridViewПродажиТоваровФормированиеЧека.Size.Height + 225));

            dbConnection.Close();
        }
    }
}