using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.MedvedevKA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_MKA_Click(object sender, EventArgs e)
        { 
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_MKA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_MKA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                //this.chartFunction.Titles.Add("График функции f(x)=4 - 2X+(2+Cos(x)/ 2x-2)")

                this.chartFunction_MKA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MKA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRES_MKA.Text = "";

                chartFunction_MKA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_MKA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRES_MKA.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-3 Медведев Кирилл Андриянович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_MKA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V23.txt";
                File.WriteAllText(path, textBoxRES_MKA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
