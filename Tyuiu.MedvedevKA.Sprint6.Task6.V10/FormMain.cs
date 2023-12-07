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

using Tyuiu.MedvedevKA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.MedvedevKA.Sprint6.Task6.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_MKA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MKA.ShowDialog();
            openFilePath = openFileDialogTask_MKA.FileName;
            textBoxInPutData_MKA.Text = File.ReadAllText(openFilePath);
            groupBoxOutputData_MKA.Text = groupBoxOutputData_MKA.Text + " " + openFileDialogTask_MKA.FileName;
            buttonDone_MKA.Enabled = true;
        }

        private void buttonDone_MKA_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_MKA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_MKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
