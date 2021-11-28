using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Товар : Form
    {
        public Товар()
        {
            InitializeComponent();
            this.ActiveControl = textBoxНаименование;

            Font F = new Font("Calibri", 12, FontStyle.Bold);
            dataGridViewТовар.ColumnHeadersDefaultCellStyle.Font = F;
            dataGridViewСотрудник.ColumnHeadersDefaultCellStyle.Font = F;
            dataGridViewПродажа.ColumnHeadersDefaultCellStyle.Font = F;
            dataGridViewПродажиТоваров.ColumnHeadersDefaultCellStyle.Font = F;


            dataGridViewТовар.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТовар.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТовар.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТовар.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТовар.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТовар.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТовар.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewТовар.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewСотрудник.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewСотрудник.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewСотрудник.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewСотрудник.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewСотрудник.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewСотрудник.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewСотрудник.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewСотрудник.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewПродажа.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewПродажа.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewПродажа.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewПродажиТоваров.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewПродажиТоваров.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewПродажиТоваров.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewПродажиТоваров.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        const string connectionString = @"Data Source=DESKTOP-16PLM1Q\SQLEXPRESS; Initial Catalog=ProductMarket; Trusted_Connection=True;";

        private void refreshDataTableТовар()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewТовар.Rows.Clear();
            cleanFormТовар();

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
                    dataGridViewТовар.Rows.Add(dbReader["ID"], dbReader["Наименование"], dbReader["Цена"], dbReader["Вес"],
                    dbReader["Ед_изм"], dbReader["Производитель"], dbReader["Описание"], dbReader["Срок_годности"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void Товар_Load(object sender, EventArgs e)
        {
            textBoxНаименование.Focus();

            labelID.Visible = false;
            textBoxID.Visible = false;
            labelIDСотрудник.Visible = false;
            textBoxIDСотрудник.Visible = false;

            buttonОбновитьТовар.Enabled = false;
            buttonДобавитьТовар.Enabled = false;
            buttonОбновитьСотрудник.Enabled = false;
            buttonДобавитьСотрудник.Enabled = false;

            refreshDataTableТовар();
            refreshDataTableСотрудник();
            refreshDataTableПродажа();
            refreshDataTableПродажиТоваров();
        }
        private void buttonДобавитьТовар_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            string name = textBoxНаименование.Text.ToString();
            string price = textBoxЦена.Text.ToString();
            string weight = textBoxВес.Text.ToString();
            string volumeUnit = textBoxЕденицаИзмерения.Text.ToString();
            string manufacturer = textBoxПроизводитель.Text.ToString();
            string description = textBoxОписание.Text.ToString();
            DateTime shelfLife = dateTimePickerСрокГодности.Value;

            string query = $@"INSERT INTO Товар (Наименование, Цена, Вес, Ед_изм, Производитель, Описание, Срок_годности)
            VALUES('{name}', '{price}', '{weight}', '{volumeUnit}', '{manufacturer}', '{description}', '{shelfLife}')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                refreshDataTableТовар();
                cleanFormТовар();
                return;
            }
            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            dbConnection.Close();
        }
        private void buttonОбновитьТовар_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            if (dataGridViewТовар.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = Convert.ToInt32(textBoxID.Text);
            string name = textBoxНаименование.Text;
            string price = textBoxЦена.Text.ToString();
            string weight = textBoxВес.Text.ToString();
            string volumeUnit = textBoxЕденицаИзмерения.Text;
            string manufacturer = textBoxПроизводитель.Text;
            string description = textBoxОписание.Text;
            DateTime shelfLife = dateTimePickerСрокГодности.Value;

            string query = $@"
            UPDATE Товар SET
            [Наименование] = '{name}',
            [Цена] = {price},
            [Вес] = {weight},
            [Ед_изм] = '{volumeUnit}',
            [Производитель] = '{manufacturer}',
            [Описание] = '{description}',
            [Срок_годности] = '{shelfLife}'
            WHERE ID = {index}";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {

                refreshDataTableТовар();
                cleanFormТовар();
                buttonОбновитьТовар.Enabled = false;
                return;
            }
            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            dbConnection.Close();
        }
        private void buttonУдалитьТовар_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            if (dataGridViewТовар.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridViewТовар.SelectedRows[0].Index;

            string ID = dataGridViewТовар.Rows[index].Cells[0].Value.ToString();

            string query = "DELETE FROM Товар WHERE ID = " + ID;
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                dataGridViewТовар.Rows.RemoveAt(index);
                return;
            }
            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            dbConnection.Close();
        }
        private void buttonОтменаТовара_Click(object sender, EventArgs e)
        {
            cleanFormТовар();
        }
        private void buttonОтменаПоискаФильтра_Click(object sender, EventArgs e)
        {
            textBoxПоискНазваниеТовар.Text = "";
            textBoxПоискПоПроизводителю.Text = "";
            textBoxФильтрТовар.Text = "";
        }
        private void cleanFormТовар()
        {
            textBoxID.Text = "";
            textBoxНаименование.Text = "";
            textBoxЦена.Text = "";
            textBoxВес.Text = "";
            textBoxЕденицаИзмерения.Text = "";
            textBoxПроизводитель.Text = "";
            textBoxОписание.Text = "";
            dateTimePickerСрокГодности.Text = "";
        }

        private void dataGridViewТовар_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonОбновитьТовар.Enabled = true;

            textBoxID.Text = dataGridViewТовар.Rows[dataGridViewТовар.SelectedRows[0].Index].Cells[0].Value.ToString();
            int index = Convert.ToInt32(dataGridViewТовар.SelectedRows[0].Index.ToString());

            textBoxНаименование.Text = dataGridViewТовар.Rows[index].Cells[1].Value.ToString();
            textBoxЦена.Text = dataGridViewТовар.Rows[index].Cells[2].Value.ToString().Replace(",", ".");
            textBoxВес.Text = dataGridViewТовар.Rows[index].Cells[3].Value.ToString().Replace(",", ".");
            textBoxЕденицаИзмерения.Text = dataGridViewТовар.Rows[index].Cells[4].Value.ToString();
            textBoxПроизводитель.Text = dataGridViewТовар.Rows[index].Cells[5].Value.ToString();
            textBoxОписание.Text = dataGridViewТовар.Rows[index].Cells[6].Value.ToString();
            dateTimePickerСрокГодности.Value = (DateTime)dataGridViewТовар.Rows[index].Cells[7].Value;
        }

        private void textBoxПоискНаименованиеТовар_TextChanged(object sender, EventArgs e)
        {
            dataGridViewТовар.ClearSelection();

            if (string.IsNullOrWhiteSpace(textBoxПоискНазваниеТовар.Text))
                return;

            var values = textBoxПоискНазваниеТовар.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < dataGridViewТовар.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = dataGridViewТовар.Rows[i];

                    if (row.Cells["Наименование"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                    }
                }
            }
        }
        private void textBoxПоискПроизводительТовар_TextChanged(object sender, EventArgs e)
        {
            dataGridViewТовар.ClearSelection();

            if (string.IsNullOrWhiteSpace(textBoxПоискПоПроизводителю.Text))
                return;

            var values = textBoxПоискПоПроизводителю.Text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < dataGridViewТовар.RowCount; i++)
            {
                foreach (string value in values)
                {
                    var row = dataGridViewТовар.Rows[i];

                    if (row.Cells["Производитель"].Value.ToString().Contains(value))
                    {
                        row.Selected = true;
                    }
                }
            }
        }
        private void textBoxФильтрНаименованиеТовар_TextChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewТовар.Rows.Clear();
            string querry = "SELECT [ID], [Наименование], [Цена], [Вес], [Ед_изм], [Производитель], [Описание], [Срок_годности]" +
            " FROM [Товар] WHERE [Наименование] LIKE '%" + textBoxФильтрТовар.Text + "%'";
            SqlCommand command = new SqlCommand(querry, dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewТовар.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
            }
        }

        private void textBoxНаименование_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number)) // символы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void textBoxЦена_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и точка
            {
                e.Handled = true;
            }
        }
        private void textBoxВес_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и точка
            {
                e.Handled = true;
            }
        }
        private void textBoxЕденицаИзмерения_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number)) // символы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void textBoxПроизводитель_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number)) // символы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void textBoxНаименование_TextChanged(object sender, EventArgs e)
        {
            if (textBoxНаименование.Text.Length > 0 && textBoxЦена.Text.Length > 0 && textBoxВес.Text.Length > 0 && textBoxЕденицаИзмерения.Text.Length > 0
                && textBoxПроизводитель.Text.Length > 0 && textBoxОписание.Text.Length > 0)
            {
                buttonДобавитьТовар.Enabled = true;
            }
            else buttonДобавитьТовар.Enabled = false;
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        private void refreshDataTableПродажа()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewПродажа.Rows.Clear();

            string query = "SELECT * FROM Продажа";
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
                    dataGridViewПродажа.Rows.Add(dbReader["ID"], dbReader["Дата_время"], dbReader["Сотрудник_ID"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void textBoxФильтрПоПродажеПродажа_TextChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewПродажа.Rows.Clear();
            string querry = "SELECT [ID], [Дата_время], [Сотрудник_ID] FROM [Продажа] WHERE [ID] LIKE '%" + textBoxСуммаПоПродаже.Text + "%'";
            SqlCommand command = new SqlCommand(querry, dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewПродажа.Rows.Add(reader[0], reader[1], reader[2]);
            }
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void refreshDataTableПродажиТоваров()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewПродажиТоваров.Rows.Clear();

            string query = "SELECT * FROM Продажи_товаров";
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
                    dataGridViewПродажиТоваров.Rows.Add(dbReader["Продажа_ID"], dbReader["Товар_ID"], dbReader["Количество"], dbReader["Цена_продажи"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void textBoxФильтрПоПродажиПродажиТоваров_TextChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewПродажиТоваров.Rows.Clear();
            string querry = "SELECT [Продажа_ID], [Товар_ID], [Количество], [Цена_продажи] FROM [Продажи_товаров] WHERE [Продажа_ID] LIKE '%" + textBoxФильтрПоПродажиПродажиТоваров.Text + "%'";
            SqlCommand command = new SqlCommand(querry, dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewПродажиТоваров.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
            }
        }

        private void buttonПерейтиКФормированиюЧека_Click(object sender, EventArgs e)
        {
            Чек чек = new Чек();
            чек.ShowDialog();
        }
        private void dataGridViewТовар_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Не занимайся ерундой!");
            return;
        }

        private void buttonУзнатьСуммуПоПродаже_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            if (textBoxСуммаПоПродаже.Text.Length < 1)
            {
                MessageBox.Show("Укажите номер продажи!", "Внимание!");
                return;
            }

            int maxID = Convert.ToInt32(textBoxСуммаПоПродаже.Text);

            if (dataGridViewПродажа.Rows.Count < 1)
            {
                MessageBox.Show("Данные не найдены!", "Внимание!");
                textBoxВыводСуммыПродажи.Text = "";
                return;
            }

            string querySumOfCheck = $@"SELECT SUM(Цена_продажи) FROM Продажи_товаров WHERE Продажа_ID = {maxID}";
            SqlCommand dbCommandForCheck = new SqlCommand(querySumOfCheck, dbConnection);

            double fullPrice = (double)dbCommandForCheck.ExecuteScalar();

            textBoxВыводСуммыПродажи.Text = fullPrice.ToString();

            dbConnection.Close();
        }
        private void button1УзнатьПоследнююПродажу_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();


            string queryMaxIDПродажа = $@"SELECT MAX(ID) FROM Продажа";
            SqlCommand dbCommandForCheck = new SqlCommand(queryMaxIDПродажа, dbConnection);

            int maxПродажаID = (int)dbCommandForCheck.ExecuteScalar();
            textBoxСуммаПоПродаже.Text = maxПродажаID.ToString();

            dbConnection.Close();
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void refreshDataTableСотрудник()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewСотрудник.Rows.Clear();
            cleanFormСотрудник();

            string query = "SELECT * FROM Сотрудник";
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
                    dataGridViewСотрудник.Rows.Add(dbReader["ID"], dbReader["Фамилия"], dbReader["Имя"], dbReader["Отчество"],
                    dbReader["Дата_рождения"], dbReader["Должность"], dbReader["Моб_номер"], dbReader["Заработная_плата"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }

        private void buttonДобавитьСотрудник_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            string surname = textBoxФамилияСотрудник.Text.ToString();
            string name = textBoxИмяСотрудник.Text.ToString();
            string patronymic = textBoxОтчествоСотрудник.Text.ToString();
            DateTime birthDay = dateTimePickerДатаРожденияСотрудник.Value;
            string position = textBoxДолжностьСотрудник.Text.ToString();
            long number = (int)Convert.ToUInt64(maskedTextBoxМобильныйНомерСотрудник.Text.ToString());
            string salary = textBoxЗпСотрудник.Text.ToString();

            string query = $@"INSERT INTO Сотрудник (Фамилия, Имя, Отчество, Дата_рождения, Должность, Моб_номер, Заработная_плата)
            VALUES('{surname}', '{name}', '{patronymic}', '{birthDay}', '{position}', {number}, '{salary}')";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                refreshDataTableСотрудник();
                cleanFormСотрудник();
                return;
            }
            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            dbConnection.Close();
        }
        private void buttonУдалитьСотрудник_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            if (dataGridViewСотрудник.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridViewСотрудник.SelectedRows[0].Index;

            string ID = dataGridViewСотрудник.Rows[index].Cells[0].Value.ToString();

            string query = "DELETE FROM Сотрудник WHERE ID = " + ID;
            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                dataGridViewСотрудник.Rows.RemoveAt(index);
                return;
            }
            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            dbConnection.Close();
        }
        private void buttonОбновитьСотрудник_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            if (dataGridViewСотрудник.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = Convert.ToInt32(textBoxIDСотрудник.Text);

            string surname = textBoxФамилияСотрудник.Text.ToString();
            string name = textBoxИмяСотрудник.Text.ToString();
            string patronymic = textBoxОтчествоСотрудник.Text.ToString();
            DateTime birthDay = dateTimePickerДатаРожденияСотрудник.Value;
            string position = textBoxДолжностьСотрудник.Text.ToString();
            //Int64 number = (int)Convert.ToInt64(maskedTextBoxМобильныйНомерСотрудник.Text.ToString().Trim(new Char[] { '(', ')', '-' }));
            //https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/trimming
            long number = (int)Convert.ToUInt64(maskedTextBoxМобильныйНомерСотрудник.Text.ToString()); //рабочий
            string salary = textBoxЗпСотрудник.Text.ToString();


            string query = $@"
            UPDATE Сотрудник SET
            [Фамилия] = '{surname}',
            [Имя] = '{name}',
            [Отчество] = '{patronymic}',
            [Дата_рождения] = '{birthDay}',
            [Должность] = '{position}',
            [Моб_номер] = '{number}',
            [Заработная_плата] = '{salary}'
            WHERE ID = {index}";

            SqlCommand dbCommand = new SqlCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                refreshDataTableСотрудник();
                cleanFormСотрудник();
                buttonОбновитьСотрудник.Enabled = false;
                return;
            }
            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");

            dbConnection.Close();
        }
        private void buttonОтменаСотрудник_Click(object sender, EventArgs e)
        {
            cleanFormСотрудник();
        }
        private void cleanFormСотрудник()
        {
            textBoxФамилияСотрудник.Text = "";
            textBoxИмяСотрудник.Text = "";
            textBoxОтчествоСотрудник.Text = "";
            dateTimePickerДатаРожденияСотрудник.Text = "";
            textBoxДолжностьСотрудник.Text = "";
            maskedTextBoxМобильныйНомерСотрудник.Text = "";
            textBoxЗпСотрудник.Text = "";
        }

        private void dataGridViewСотрудник_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonОбновитьСотрудник.Enabled = true;

            textBoxIDСотрудник.Text = dataGridViewСотрудник.Rows[dataGridViewСотрудник.SelectedRows[0].Index].Cells[0].Value.ToString();
            int index = Convert.ToInt32(dataGridViewСотрудник.SelectedRows[0].Index.ToString());

            textBoxФамилияСотрудник.Text = dataGridViewСотрудник.Rows[index].Cells[1].Value.ToString();
            textBoxИмяСотрудник.Text = dataGridViewСотрудник.Rows[index].Cells[2].Value.ToString();
            textBoxОтчествоСотрудник.Text = dataGridViewСотрудник.Rows[index].Cells[3].Value.ToString();
            dateTimePickerДатаРожденияСотрудник.Value = (DateTime)dataGridViewСотрудник.Rows[index].Cells[4].Value;
            textBoxДолжностьСотрудник.Text = dataGridViewСотрудник.Rows[index].Cells[5].Value.ToString();
            maskedTextBoxМобильныйНомерСотрудник.Text = dataGridViewСотрудник.Rows[index].Cells[6].Value.ToString();
            textBoxЗпСотрудник.Text = dataGridViewСотрудник.Rows[index].Cells[7].Value.ToString();
        }

        private void textBoxФамилияСотрудник_TextChanged(object sender, EventArgs e)
        {
            if (textBoxФамилияСотрудник.Text.Length > 0 && textBoxИмяСотрудник.Text.Length > 0 && textBoxОтчествоСотрудник.Text.Length > 0 && dateTimePickerДатаРожденияСотрудник.Text.Length > 0
                && textBoxДолжностьСотрудник.Text.Length > 0 && maskedTextBoxМобильныйНомерСотрудник.Text.Length > 0 && textBoxЗпСотрудник.Text.Length > 0)
            {
                buttonДобавитьСотрудник.Enabled = true;
            }
            else buttonДобавитьСотрудник.Enabled = false;
        }

        private void textBoxФамилияСотрудник_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number)) // символы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void textBoxЗпСотрудник_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и точка
            {
                e.Handled = true;
            }
        }

        private void textBoxФильтрПоФамилии_TextChanged(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            dataGridViewСотрудник.Rows.Clear();
            string querry = "SELECT [ID], [Фамилия], [Имя], [Отчество], [Дата_рождения], [Должность], [Моб_номер], [Заработная_плата]" +
            " FROM [Сотрудник] WHERE [Фамилия] LIKE '%" + textBoxФильтрПоФамилии.Text + "%'";
            SqlCommand command = new SqlCommand(querry, dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridViewСотрудник.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
            }
        }
    }
}
