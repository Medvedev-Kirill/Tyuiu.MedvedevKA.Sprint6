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

using Tyuiu.MedvedevKA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MKA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_MKA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,]LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void buttonHelp_MKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_MKA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MKA.ShowDialog();
            openFilePath = openFileDialogTask_MKA.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPutMatrix_MKA.ColumnCount = colums;
            dataGridViewInPutMatrix_MKA.RowCount = rows;
            dataGridViewOutPutMatrix_MKA.ColumnCount = colums;
            dataGridViewOutPutMatrix_MKA.RowCount = rows;

            for(int i = 0; i < colums; i++)
            {
                dataGridViewInPutMatrix_MKA.Columns[i].Width = 25;
                dataGridViewOutPutMatrix_MKA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPutMatrix_MKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_MKA.Enabled = true;
        }

        private void buttonDone_MKA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutPutMatrix_MKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_MKA.Enabled = true;
        }

        private void buttonSave_MKA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MKA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MKA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MKA.ShowDialog();

            string path = saveFileDialogMatrix_MKA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutMatrix_MKA.RowCount;
            int columns = dataGridViewOutPutMatrix_MKA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPutMatrix_MKA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPutMatrix_MKA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_MKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MKA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MKA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MKA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MKA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_MKA.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPutMatrix_MKA.ColumnCount = 50;
            dataGridViewOutPutMatrix_MKA.ColumnCount = 50;

            dataGridViewInPutMatrix_MKA.RowCount = 50;
            dataGridViewOutPutMatrix_MKA.RowCount = 50;

            for(int i = 0; i < 50; i++)
            {
                dataGridViewInPutMatrix_MKA.Columns[i].Width = 25;
                dataGridViewOutPutMatrix_MKA.Columns[i].Width = 25;
            }
        }
    }
}
