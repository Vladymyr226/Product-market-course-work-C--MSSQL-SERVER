using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Пуск : Form
    {
        public Пуск()
        {
            InitializeComponent();
        }

        private void linkLabelРазработчик_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Vladymyr226");
        }

        private void buttonОПрограмме_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал студент группы РПЗ 19 1/9\nСвириденко Владимир Романович. \nРабота написана на С#, оформлена на Windows Forms\nс использованием Базы данных MS SQL Server.", "Внимание!");
        }

        private void buttonРабочееМестоКассира_Click(object sender, EventArgs e)
        {
            Чек чек = new Чек();
            чек.ShowDialog();
        }

        private void buttonСправочникПоМагазину_Click(object sender, EventArgs e)
        {
            Товар товар = new Товар();
            товар.ShowDialog();
        }
    }
}
