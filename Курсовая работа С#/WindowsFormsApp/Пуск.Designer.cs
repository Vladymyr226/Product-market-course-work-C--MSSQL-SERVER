
namespace WindowsFormsApp1
{
    partial class Пуск
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Пуск));
            this.buttonРабочееМестоКассира = new System.Windows.Forms.Button();
            this.buttonСправочникПоМагазину = new System.Windows.Forms.Button();
            this.linkLabelРазработчик = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonОПрограмме = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonРабочееМестоКассира
            // 
            this.buttonРабочееМестоКассира.BackColor = System.Drawing.Color.Yellow;
            this.buttonРабочееМестоКассира.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonРабочееМестоКассира.Location = new System.Drawing.Point(93, 331);
            this.buttonРабочееМестоКассира.Name = "buttonРабочееМестоКассира";
            this.buttonРабочееМестоКассира.Size = new System.Drawing.Size(300, 100);
            this.buttonРабочееМестоКассира.TabIndex = 0;
            this.buttonРабочееМестоКассира.Text = "Рабочее место кассира";
            this.buttonРабочееМестоКассира.UseVisualStyleBackColor = false;
            this.buttonРабочееМестоКассира.Click += new System.EventHandler(this.buttonРабочееМестоКассира_Click);
            // 
            // buttonСправочникПоМагазину
            // 
            this.buttonСправочникПоМагазину.BackColor = System.Drawing.Color.Yellow;
            this.buttonСправочникПоМагазину.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСправочникПоМагазину.Location = new System.Drawing.Point(93, 214);
            this.buttonСправочникПоМагазину.Name = "buttonСправочникПоМагазину";
            this.buttonСправочникПоМагазину.Size = new System.Drawing.Size(300, 100);
            this.buttonСправочникПоМагазину.TabIndex = 1;
            this.buttonСправочникПоМагазину.Text = "Справочник по магазину";
            this.buttonСправочникПоМагазину.UseVisualStyleBackColor = false;
            this.buttonСправочникПоМагазину.Click += new System.EventHandler(this.buttonСправочникПоМагазину_Click);
            // 
            // linkLabelРазработчик
            // 
            this.linkLabelРазработчик.AutoSize = true;
            this.linkLabelРазработчик.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelРазработчик.Location = new System.Drawing.Point(12, 9);
            this.linkLabelРазработчик.Name = "linkLabelРазработчик";
            this.linkLabelРазработчик.Size = new System.Drawing.Size(121, 23);
            this.linkLabelРазработчик.TabIndex = 2;
            this.linkLabelРазработчик.TabStop = true;
            this.linkLabelРазработчик.Text = "Разработчик";
            this.linkLabelРазработчик.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelРазработчик_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonОПрограмме
            // 
            this.buttonОПрограмме.BackColor = System.Drawing.Color.Yellow;
            this.buttonОПрограмме.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОПрограмме.Location = new System.Drawing.Point(93, 95);
            this.buttonОПрограмме.Name = "buttonОПрограмме";
            this.buttonОПрограмме.Size = new System.Drawing.Size(300, 100);
            this.buttonОПрограмме.TabIndex = 4;
            this.buttonОПрограмме.Text = "О программе";
            this.buttonОПрограмме.UseVisualStyleBackColor = false;
            this.buttonОПрограмме.Click += new System.EventHandler(this.buttonОПрограмме_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вас приветствует программа автоматизация учета продаж продуктов питания!";
            // 
            // Пуск
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonОПрограмме);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelРазработчик);
            this.Controls.Add(this.buttonСправочникПоМагазину);
            this.Controls.Add(this.buttonРабочееМестоКассира);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Пуск";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonРабочееМестоКассира;
        private System.Windows.Forms.Button buttonСправочникПоМагазину;
        private System.Windows.Forms.LinkLabel linkLabelРазработчик;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonОПрограмме;
        private System.Windows.Forms.Label label1;
    }
}