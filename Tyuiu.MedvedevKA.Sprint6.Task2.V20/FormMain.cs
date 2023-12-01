using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MedvedevKA.Sprint6.Task2.V20.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task2.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_MKA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_MKA.BackColor = Color.Blue;
        }

        private void buttonDone_MKA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MKA.BackColor = Color.Red;
        }

        private void buttonDone_MKA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MKA.BackColor = Color.Green;
        }

        private void buttonDone_MKA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MKA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_MKA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MKA.Titles.Add("График функции (sin(x)/x+1,2) - sin(x) * 2 - 2x");

                this.chartFunction_MKA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MKA.ChartAreas[0].AxisY.Title = "Ось Y";

                for(int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MKA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_MKA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-3 Медведев Кирилл Андриянович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
