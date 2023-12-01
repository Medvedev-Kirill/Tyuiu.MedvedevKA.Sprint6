using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MedvedevKA.Sprint6.Task3.V22.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task3.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 17,0,19,-8,-1},
                                     { 9, 4, -5, 7, 15},
                                     { 11, 13, 4, -4, -14},
                                     { 11, 14, 5, -15, 16},
                                     {2, -14, -2, 11, 11 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_MKA.ColumnCount = columns;
            dataGridViewMatrix_MKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_MKA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j ++)
                {
                    dataGridViewMatrix_MKA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_MKA_Click(object sender, EventArgs e)
        {
            mtrx= ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_MKA.ColumnCount = columns;
            dataGridViewMatrix_MKA.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_MKA.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonHelp_MKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-3 Медведев Кирилл Андриянович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
