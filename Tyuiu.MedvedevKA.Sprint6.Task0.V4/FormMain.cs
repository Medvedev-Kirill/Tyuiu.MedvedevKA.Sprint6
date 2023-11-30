using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MedvedevKA.Sprint6.Task0.V4.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDoneClick_MKA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_MKA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_MKA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxVarX_MKA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 3) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_MKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-23-3 Медведев Кирилл Андриянович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
