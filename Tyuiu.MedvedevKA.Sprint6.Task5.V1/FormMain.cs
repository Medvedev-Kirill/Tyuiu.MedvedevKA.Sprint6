using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MedvedevKA.Sprint6.Task5.V1.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task5.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutFileTask5V1.txt";
        private void buttonDone_MKA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_MKA.ColumnCount = 2;
            dataGridViewRes_MKA.Columns[0].Width = 20;
            dataGridViewRes_MKA.Columns[1].Width = 50;

            this.chartDiag_MKA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_MKA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_MKA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for(int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes_MKA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_MKA.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_MKA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-3 Медведев Кирилл Андриянович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
