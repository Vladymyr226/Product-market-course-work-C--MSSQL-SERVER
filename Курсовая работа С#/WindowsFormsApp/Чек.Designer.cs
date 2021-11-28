
namespace WindowsFormsApp1
{
    partial class Чек
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Чек));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDownКоличествоВыбранногоТовара = new System.Windows.Forms.NumericUpDown();
            this.groupBoxЧек = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxОбщаяСумма = new System.Windows.Forms.TextBox();
            this.buttonСформироватьИРаспечататьЧек = new System.Windows.Forms.Button();
            this.buttonДобавитьВЧек = new System.Windows.Forms.Button();
            this.buttonУдалитьЗаписьИзЧека = new System.Windows.Forms.Button();
            this.buttonСформироватьНовыйЧек = new System.Windows.Forms.Button();
            this.dataGridViewПродажиТоваровФормированиеЧека = new System.Windows.Forms.DataGridView();
            this.ТоварID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена_продажи = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxВыборКассира = new System.Windows.Forms.ComboBox();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productMarketDataSet = new WindowsFormsApp1.ProductMarketDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewТоварФормированиеЧека = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Еденица_изм = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Производитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Срок_годности = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникTableAdapter = new WindowsFormsApp1.ProductMarketDataSetTableAdapters.СотрудникTableAdapter();
            this.buttonСформироватьПродажу = new System.Windows.Forms.Button();
            this.buttonПерейтиКСправочнику = new System.Windows.Forms.Button();
            this.printPreviewDialogФормированиеЧека = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentЧек = new System.Drawing.Printing.PrintDocument();
            this.buttonПерейтиНаГлавноеОкно = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxФильтрТоварПриФормированииЧека = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownКоличествоВыбранногоТовара)).BeginInit();
            this.groupBoxЧек.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewПродажиТоваровФормированиеЧека)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТоварФормированиеЧека)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownКоличествоВыбранногоТовара
            // 
            this.numericUpDownКоличествоВыбранногоТовара.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownКоличествоВыбранногоТовара.Location = new System.Drawing.Point(631, 20);
            this.numericUpDownКоличествоВыбранногоТовара.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownКоличествоВыбранногоТовара.Name = "numericUpDownКоличествоВыбранногоТовара";
            this.numericUpDownКоличествоВыбранногоТовара.Size = new System.Drawing.Size(68, 27);
            this.numericUpDownКоличествоВыбранногоТовара.TabIndex = 91;
            this.numericUpDownКоличествоВыбранногоТовара.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxЧек
            // 
            this.groupBoxЧек.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBoxЧек.Controls.Add(this.pictureBox1);
            this.groupBoxЧек.Controls.Add(this.textBoxОбщаяСумма);
            this.groupBoxЧек.Controls.Add(this.buttonСформироватьИРаспечататьЧек);
            this.groupBoxЧек.Controls.Add(this.buttonДобавитьВЧек);
            this.groupBoxЧек.Controls.Add(this.numericUpDownКоличествоВыбранногоТовара);
            this.groupBoxЧек.Controls.Add(this.buttonУдалитьЗаписьИзЧека);
            this.groupBoxЧек.Controls.Add(this.buttonСформироватьНовыйЧек);
            this.groupBoxЧек.Controls.Add(this.dataGridViewПродажиТоваровФормированиеЧека);
            this.groupBoxЧек.Controls.Add(this.label1);
            this.groupBoxЧек.Controls.Add(this.label8);
            this.groupBoxЧек.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxЧек.Location = new System.Drawing.Point(11, 466);
            this.groupBoxЧек.Name = "groupBoxЧек";
            this.groupBoxЧек.Size = new System.Drawing.Size(1145, 245);
            this.groupBoxЧек.TabIndex = 97;
            this.groupBoxЧек.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(734, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxОбщаяСумма
            // 
            this.textBoxОбщаяСумма.Location = new System.Drawing.Point(1003, 48);
            this.textBoxОбщаяСумма.Name = "textBoxОбщаяСумма";
            this.textBoxОбщаяСумма.ReadOnly = true;
            this.textBoxОбщаяСумма.Size = new System.Drawing.Size(134, 24);
            this.textBoxОбщаяСумма.TabIndex = 104;
            // 
            // buttonСформироватьИРаспечататьЧек
            // 
            this.buttonСформироватьИРаспечататьЧек.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonСформироватьИРаспечататьЧек.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСформироватьИРаспечататьЧек.Location = new System.Drawing.Point(937, 84);
            this.buttonСформироватьИРаспечататьЧек.Name = "buttonСформироватьИРаспечататьЧек";
            this.buttonСформироватьИРаспечататьЧек.Size = new System.Drawing.Size(200, 59);
            this.buttonСформироватьИРаспечататьЧек.TabIndex = 103;
            this.buttonСформироватьИРаспечататьЧек.Text = "Распечатать чек";
            this.buttonСформироватьИРаспечататьЧек.UseVisualStyleBackColor = false;
            this.buttonСформироватьИРаспечататьЧек.Click += new System.EventHandler(this.buttonСформироватьИРаспечататьЧек_Click);
            // 
            // buttonДобавитьВЧек
            // 
            this.buttonДобавитьВЧек.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonДобавитьВЧек.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьВЧек.Location = new System.Drawing.Point(499, 84);
            this.buttonДобавитьВЧек.Name = "buttonДобавитьВЧек";
            this.buttonДобавитьВЧек.Size = new System.Drawing.Size(200, 59);
            this.buttonДобавитьВЧек.TabIndex = 100;
            this.buttonДобавитьВЧек.Text = "Добавить в чек";
            this.buttonДобавитьВЧек.UseVisualStyleBackColor = false;
            this.buttonДобавитьВЧек.Click += new System.EventHandler(this.buttonДобавитьВЧек_Click);
            // 
            // buttonУдалитьЗаписьИзЧека
            // 
            this.buttonУдалитьЗаписьИзЧека.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonУдалитьЗаписьИзЧека.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьЗаписьИзЧека.Location = new System.Drawing.Point(499, 177);
            this.buttonУдалитьЗаписьИзЧека.Name = "buttonУдалитьЗаписьИзЧека";
            this.buttonУдалитьЗаписьИзЧека.Size = new System.Drawing.Size(200, 59);
            this.buttonУдалитьЗаписьИзЧека.TabIndex = 102;
            this.buttonУдалитьЗаписьИзЧека.Text = "Удалить из чека";
            this.buttonУдалитьЗаписьИзЧека.UseVisualStyleBackColor = false;
            this.buttonУдалитьЗаписьИзЧека.Click += new System.EventHandler(this.buttonУдалитьЗаписьИзЧека_Click);
            // 
            // buttonСформироватьНовыйЧек
            // 
            this.buttonСформироватьНовыйЧек.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonСформироватьНовыйЧек.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСформироватьНовыйЧек.ForeColor = System.Drawing.Color.Black;
            this.buttonСформироватьНовыйЧек.Location = new System.Drawing.Point(881, 177);
            this.buttonСформироватьНовыйЧек.Name = "buttonСформироватьНовыйЧек";
            this.buttonСформироватьНовыйЧек.Size = new System.Drawing.Size(258, 60);
            this.buttonСформироватьНовыйЧек.TabIndex = 101;
            this.buttonСформироватьНовыйЧек.Text = "Сформировать новый чек";
            this.buttonСформироватьНовыйЧек.UseVisualStyleBackColor = false;
            this.buttonСформироватьНовыйЧек.Click += new System.EventHandler(this.buttonСформироватьНовыйЧек_Click);
            // 
            // dataGridViewПродажиТоваровФормированиеЧека
            // 
            this.dataGridViewПродажиТоваровФормированиеЧека.AllowUserToAddRows = false;
            this.dataGridViewПродажиТоваровФормированиеЧека.AllowUserToDeleteRows = false;
            this.dataGridViewПродажиТоваровФормированиеЧека.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewПродажиТоваровФормированиеЧека.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewПродажиТоваровФормированиеЧека.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewПродажиТоваровФормированиеЧека.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ТоварID,
            this.Наименование_ID,
            this.Количество,
            this.Цена_продажи});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewПродажиТоваровФормированиеЧека.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewПродажиТоваровФормированиеЧека.Location = new System.Drawing.Point(5, 20);
            this.dataGridViewПродажиТоваровФормированиеЧека.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewПродажиТоваровФормированиеЧека.Name = "dataGridViewПродажиТоваровФормированиеЧека";
            this.dataGridViewПродажиТоваровФормированиеЧека.ReadOnly = true;
            this.dataGridViewПродажиТоваровФормированиеЧека.RowHeadersWidth = 51;
            this.dataGridViewПродажиТоваровФормированиеЧека.RowTemplate.Height = 30;
            this.dataGridViewПродажиТоваровФормированиеЧека.Size = new System.Drawing.Size(489, 217);
            this.dataGridViewПродажиТоваровФормированиеЧека.TabIndex = 100;
            // 
            // ТоварID
            // 
            this.ТоварID.DataPropertyName = "ТоварID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ТоварID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ТоварID.HeaderText = "№ Товара";
            this.ТоварID.MinimumWidth = 6;
            this.ТоварID.Name = "ТоварID";
            this.ТоварID.ReadOnly = true;
            this.ТоварID.Visible = false;
            // 
            // Наименование_ID
            // 
            this.Наименование_ID.HeaderText = "Наименование";
            this.Наименование_ID.Name = "Наименование_ID";
            this.Наименование_ID.ReadOnly = true;
            this.Наименование_ID.Width = 220;
            // 
            // Количество
            // 
            this.Количество.DataPropertyName = "Количество";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Количество.DefaultCellStyle = dataGridViewCellStyle3;
            this.Количество.HeaderText = "Количество";
            this.Количество.Name = "Количество";
            this.Количество.ReadOnly = true;
            // 
            // Цена_продажи
            // 
            this.Цена_продажи.DataPropertyName = "Цена_продажи";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Цена_продажи.DefaultCellStyle = dataGridViewCellStyle4;
            this.Цена_продажи.HeaderText = "Цена";
            this.Цена_продажи.Name = "Цена_продажи";
            this.Цена_продажи.ReadOnly = true;
            this.Цена_продажи.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(500, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 92;
            this.label1.Text = "Количество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(957, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 24);
            this.label8.TabIndex = 84;
            this.label8.Text = "Общая сумма(грн):";
            // 
            // comboBoxВыборКассира
            // 
            this.comboBoxВыборКассира.DataSource = this.сотрудникBindingSource;
            this.comboBoxВыборКассира.DisplayMember = "ID";
            this.comboBoxВыборКассира.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxВыборКассира.FormattingEnabled = true;
            this.comboBoxВыборКассира.Location = new System.Drawing.Point(136, 433);
            this.comboBoxВыборКассира.Name = "comboBoxВыборКассира";
            this.comboBoxВыборКассира.Size = new System.Drawing.Size(80, 32);
            this.comboBoxВыборКассира.TabIndex = 90;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.productMarketDataSet;
            // 
            // productMarketDataSet
            // 
            this.productMarketDataSet.DataSetName = "ProductMarketDataSet";
            this.productMarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 89;
            this.label2.Text = "За пультом";
            // 
            // dataGridViewТоварФормированиеЧека
            // 
            this.dataGridViewТоварФормированиеЧека.AllowUserToAddRows = false;
            this.dataGridViewТоварФормированиеЧека.AllowUserToDeleteRows = false;
            this.dataGridViewТоварФормированиеЧека.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewТоварФормированиеЧека.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewТоварФормированиеЧека.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Наименование,
            this.Цена,
            this.Вес,
            this.Еденица_изм,
            this.Производитель,
            this.Описание,
            this.Срок_годности});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewТоварФормированиеЧека.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewТоварФормированиеЧека.Location = new System.Drawing.Point(11, 40);
            this.dataGridViewТоварФормированиеЧека.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewТоварФормированиеЧека.Name = "dataGridViewТоварФормированиеЧека";
            this.dataGridViewТоварФормированиеЧека.ReadOnly = true;
            this.dataGridViewТоварФормированиеЧека.RowHeadersWidth = 51;
            this.dataGridViewТоварФормированиеЧека.RowTemplate.Height = 30;
            this.dataGridViewТоварФормированиеЧека.Size = new System.Drawing.Size(1145, 356);
            this.dataGridViewТоварФормированиеЧека.TabIndex = 98;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle6;
            this.ID.HeaderText = "№";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Наименование
            // 
            this.Наименование.DataPropertyName = "Наименование";
            this.Наименование.HeaderText = "Наименование";
            this.Наименование.MinimumWidth = 6;
            this.Наименование.Name = "Наименование";
            this.Наименование.ReadOnly = true;
            this.Наименование.Width = 150;
            // 
            // Цена
            // 
            this.Цена.DataPropertyName = "Цена";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Цена.DefaultCellStyle = dataGridViewCellStyle7;
            this.Цена.HeaderText = "Цена";
            this.Цена.MinimumWidth = 6;
            this.Цена.Name = "Цена";
            this.Цена.ReadOnly = true;
            this.Цена.Width = 70;
            // 
            // Вес
            // 
            this.Вес.DataPropertyName = "Вес";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Вес.DefaultCellStyle = dataGridViewCellStyle8;
            this.Вес.HeaderText = "Вес";
            this.Вес.MinimumWidth = 6;
            this.Вес.Name = "Вес";
            this.Вес.ReadOnly = true;
            this.Вес.Width = 70;
            // 
            // Еденица_изм
            // 
            this.Еденица_изм.DataPropertyName = "Еденица_изм";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Еденица_изм.DefaultCellStyle = dataGridViewCellStyle9;
            this.Еденица_изм.HeaderText = "Ед. изм.";
            this.Еденица_изм.MinimumWidth = 6;
            this.Еденица_изм.Name = "Еденица_изм";
            this.Еденица_изм.ReadOnly = true;
            // 
            // Производитель
            // 
            this.Производитель.DataPropertyName = "Производитель";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Производитель.DefaultCellStyle = dataGridViewCellStyle10;
            this.Производитель.HeaderText = "Производитель";
            this.Производитель.MinimumWidth = 6;
            this.Производитель.Name = "Производитель";
            this.Производитель.ReadOnly = true;
            this.Производитель.Width = 150;
            // 
            // Описание
            // 
            this.Описание.DataPropertyName = "Описание";
            this.Описание.HeaderText = "Описание";
            this.Описание.MinimumWidth = 6;
            this.Описание.Name = "Описание";
            this.Описание.ReadOnly = true;
            this.Описание.Width = 350;
            // 
            // Срок_годности
            // 
            this.Срок_годности.DataPropertyName = "Срок_годности";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Срок_годности.DefaultCellStyle = dataGridViewCellStyle11;
            this.Срок_годности.HeaderText = "Срок годности";
            this.Срок_годности.MinimumWidth = 6;
            this.Срок_годности.Name = "Срок_годности";
            this.Срок_годности.ReadOnly = true;
            this.Срок_годности.Width = 150;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // buttonСформироватьПродажу
            // 
            this.buttonСформироватьПродажу.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonСформироватьПродажу.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСформироватьПродажу.Location = new System.Drawing.Point(896, 401);
            this.buttonСформироватьПродажу.Name = "buttonСформироватьПродажу";
            this.buttonСформироватьПродажу.Size = new System.Drawing.Size(260, 60);
            this.buttonСформироватьПродажу.TabIndex = 101;
            this.buttonСформироватьПродажу.Text = "Сформировать продажу";
            this.buttonСформироватьПродажу.UseVisualStyleBackColor = false;
            this.buttonСформироватьПродажу.Click += new System.EventHandler(this.buttonСформироватьПродажу_Click);
            // 
            // buttonПерейтиКСправочнику
            // 
            this.buttonПерейтиКСправочнику.BackColor = System.Drawing.Color.Yellow;
            this.buttonПерейтиКСправочнику.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonПерейтиКСправочнику.Location = new System.Drawing.Point(11, 5);
            this.buttonПерейтиКСправочнику.Name = "buttonПерейтиКСправочнику";
            this.buttonПерейтиКСправочнику.Size = new System.Drawing.Size(234, 30);
            this.buttonПерейтиКСправочнику.TabIndex = 102;
            this.buttonПерейтиКСправочнику.Text = "Перейти к справочнику";
            this.buttonПерейтиКСправочнику.UseVisualStyleBackColor = false;
            this.buttonПерейтиКСправочнику.Click += new System.EventHandler(this.buttonПерейтиКСправочнику_Click);
            // 
            // printPreviewDialogФормированиеЧека
            // 
            this.printPreviewDialogФормированиеЧека.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogФормированиеЧека.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogФормированиеЧека.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialogФормированиеЧека.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogФормированиеЧека.Document = this.printDocumentЧек;
            this.printPreviewDialogФормированиеЧека.Enabled = true;
            this.printPreviewDialogФормированиеЧека.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogФормированиеЧека.Icon")));
            this.printPreviewDialogФормированиеЧека.Name = "printPreviewDialog";
            this.printPreviewDialogФормированиеЧека.Visible = false;
            // 
            // printDocumentЧек
            // 
            this.printDocumentЧек.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentЧек_PrintPage);
            // 
            // buttonПерейтиНаГлавноеОкно
            // 
            this.buttonПерейтиНаГлавноеОкно.BackColor = System.Drawing.Color.Yellow;
            this.buttonПерейтиНаГлавноеОкно.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonПерейтиНаГлавноеОкно.Location = new System.Drawing.Point(251, 5);
            this.buttonПерейтиНаГлавноеОкно.Name = "buttonПерейтиНаГлавноеОкно";
            this.buttonПерейтиНаГлавноеОкно.Size = new System.Drawing.Size(257, 30);
            this.buttonПерейтиНаГлавноеОкно.TabIndex = 103;
            this.buttonПерейтиНаГлавноеОкно.Text = "Перейти на главное окно";
            this.buttonПерейтиНаГлавноеОкно.UseVisualStyleBackColor = false;
            this.buttonПерейтиНаГлавноеОкно.Click += new System.EventHandler(this.buttonПерейтиНаГлавноеОкно_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(275, 419);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(252, 24);
            this.label18.TabIndex = 107;
            this.label18.Text = "Фильтр по наименованию";
            // 
            // textBoxФильтрТоварПриФормированииЧека
            // 
            this.textBoxФильтрТоварПриФормированииЧека.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxФильтрТоварПриФормированииЧека.Location = new System.Drawing.Point(529, 420);
            this.textBoxФильтрТоварПриФормированииЧека.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxФильтрТоварПриФормированииЧека.Name = "textBoxФильтрТоварПриФормированииЧека";
            this.textBoxФильтрТоварПриФормированииЧека.Size = new System.Drawing.Size(181, 27);
            this.textBoxФильтрТоварПриФормированииЧека.TabIndex = 106;
            this.textBoxФильтрТоварПриФормированииЧека.TextChanged += new System.EventHandler(this.textBoxФильтрТоварПриФормированииЧека_TextChanged);
            // 
            // Чек
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1164, 715);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxФильтрТоварПриФормированииЧека);
            this.Controls.Add(this.buttonПерейтиНаГлавноеОкно);
            this.Controls.Add(this.buttonПерейтиКСправочнику);
            this.Controls.Add(this.buttonСформироватьПродажу);
            this.Controls.Add(this.dataGridViewТоварФормированиеЧека);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxВыборКассира);
            this.Controls.Add(this.groupBoxЧек);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Чек";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование чека";
            this.Load += new System.EventHandler(this.Чек_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownКоличествоВыбранногоТовара)).EndInit();
            this.groupBoxЧек.ResumeLayout(false);
            this.groupBoxЧек.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewПродажиТоваровФормированиеЧека)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТоварФормированиеЧека)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownКоличествоВыбранногоТовара;
        private System.Windows.Forms.GroupBox groupBoxЧек;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxВыборКассира;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewТоварФормированиеЧека;
        private ProductMarketDataSet productMarketDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private ProductMarketDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewПродажиТоваровФормированиеЧека;
        private System.Windows.Forms.Button buttonСформироватьНовыйЧек;
        private System.Windows.Forms.Button buttonСформироватьИРаспечататьЧек;
        private System.Windows.Forms.Button buttonУдалитьЗаписьИзЧека;
        private System.Windows.Forms.Button buttonДобавитьВЧек;
        private System.Windows.Forms.Button buttonСформироватьПродажу;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxОбщаяСумма;
        private System.Windows.Forms.Button buttonПерейтиКСправочнику;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogФормированиеЧека;
        private System.Drawing.Printing.PrintDocument printDocumentЧек;
        private System.Windows.Forms.Button buttonПерейтиНаГлавноеОкно;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxФильтрТоварПриФормированииЧека;
        private System.Windows.Forms.DataGridViewTextBoxColumn ТоварID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена_продажи;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вес;
        private System.Windows.Forms.DataGridViewTextBoxColumn Еденица_изм;
        private System.Windows.Forms.DataGridViewTextBoxColumn Производитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание;
        private System.Windows.Forms.DataGridViewTextBoxColumn Срок_годности;
    }
}