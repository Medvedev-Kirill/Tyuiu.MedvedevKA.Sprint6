using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MedvedevKA.Sprint6.Task1.V4.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_MKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-3 Медведев Кирилл Андриянович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataService ds = new DataService();
        private void buttonDone_MKA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MKA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_MKA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRes_MKA.Text = "";
                textBoxRes_MKA.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxRes_MKA.AppendText("|    X    |   f(x)  |" + Environment.NewLine);
                textBoxRes_MKA.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    | {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxRes_MKA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_MKA.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
