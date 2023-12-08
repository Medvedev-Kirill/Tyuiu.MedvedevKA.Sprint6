
namespace Tyuiu.MedvedevKA.Sprint6.Task6.V10
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_MKA = new System.Windows.Forms.Button();
            this.buttonDone_MKA = new System.Windows.Forms.Button();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.groupBoxTask_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MKA = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_MKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_MKA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MKA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MKA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask_MKA.SuspendLayout();
            this.groupBoxInputData_MKA.SuspendLayout();
            this.groupBoxOutputData_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_MKA
            // 
            this.buttonOpenFile_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MKA.Image")));
            this.buttonOpenFile_MKA.Location = new System.Drawing.Point(15, 15);
            this.buttonOpenFile_MKA.Name = "buttonOpenFile_MKA";
            this.buttonOpenFile_MKA.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_MKA.TabIndex = 0;
            this.toolTip_MKA.SetToolTip(this.buttonOpenFile_MKA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonOpenFile_MKA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MKA.Click += new System.EventHandler(this.buttonOpenFile_MKA_Click);
            // 
            // buttonDone_MKA
            // 
            this.buttonDone_MKA.Enabled = false;
            this.buttonDone_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_MKA.Image")));
            this.buttonDone_MKA.Location = new System.Drawing.Point(95, 15);
            this.buttonDone_MKA.Name = "buttonDone_MKA";
            this.buttonDone_MKA.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_MKA.TabIndex = 1;
            this.toolTip_MKA.SetToolTip(this.buttonDone_MKA, "Производит поиск в файле вхождений символов \"w\"\r\nи конкатенирует строки в которых" +
        " находят \r\nэти символы\r\n\r\n");
            this.buttonDone_MKA.UseVisualStyleBackColor = true;
            this.buttonDone_MKA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MKA.Image")));
            this.buttonHelp_MKA.Location = new System.Drawing.Point(730, 15);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_MKA.TabIndex = 2;
            this.toolTip_MKA.SetToolTip(this.buttonHelp_MKA, "Сведение о программе");
            this.buttonHelp_MKA.UseVisualStyleBackColor = true;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.textBoxTask_MKA);
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(1, 75);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(806, 75);
            this.groupBoxTask_MKA.TabIndex = 3;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие:";
            // 
            // textBoxTask_MKA
            // 
            this.textBoxTask_MKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_MKA.Multiline = true;
            this.textBoxTask_MKA.Name = "textBoxTask_MKA";
            this.textBoxTask_MKA.ReadOnly = true;
            this.textBoxTask_MKA.Size = new System.Drawing.Size(793, 49);
            this.textBoxTask_MKA.TabIndex = 0;
            this.textBoxTask_MKA.Text = resources.GetString("textBoxTask_MKA.Text");
            // 
            // groupBoxInputData_MKA
            // 
            this.groupBoxInputData_MKA.Controls.Add(this.textBoxInPutData_MKA);
            this.groupBoxInputData_MKA.Location = new System.Drawing.Point(1, 151);
            this.groupBoxInputData_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxInputData_MKA.Name = "groupBoxInputData_MKA";
            this.groupBoxInputData_MKA.Size = new System.Drawing.Size(400, 300);
            this.groupBoxInputData_MKA.TabIndex = 4;
            this.groupBoxInputData_MKA.TabStop = false;
            this.groupBoxInputData_MKA.Text = "Ввод:";
            // 
            // textBoxInPutData_MKA
            // 
            this.textBoxInPutData_MKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxInPutData_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxInPutData_MKA.Multiline = true;
            this.textBoxInPutData_MKA.Name = "textBoxInPutData_MKA";
            this.textBoxInPutData_MKA.ReadOnly = true;
            this.textBoxInPutData_MKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPutData_MKA.Size = new System.Drawing.Size(385, 274);
            this.textBoxInPutData_MKA.TabIndex = 0;
            // 
            // groupBoxOutputData_MKA
            // 
            this.groupBoxOutputData_MKA.Controls.Add(this.textBoxOutPutData_MKA);
            this.groupBoxOutputData_MKA.Location = new System.Drawing.Point(407, 151);
            this.groupBoxOutputData_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxOutputData_MKA.Name = "groupBoxOutputData_MKA";
            this.groupBoxOutputData_MKA.Size = new System.Drawing.Size(400, 300);
            this.groupBoxOutputData_MKA.TabIndex = 5;
            this.groupBoxOutputData_MKA.TabStop = false;
            this.groupBoxOutputData_MKA.Text = "Вывод:";
            // 
            // textBoxOutPutData_MKA
            // 
            this.textBoxOutPutData_MKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxOutPutData_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxOutPutData_MKA.Multiline = true;
            this.textBoxOutPutData_MKA.Name = "textBoxOutPutData_MKA";
            this.textBoxOutPutData_MKA.ReadOnly = true;
            this.textBoxOutPutData_MKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_MKA.Size = new System.Drawing.Size(385, 274);
            this.textBoxOutPutData_MKA.TabIndex = 0;
            // 
            // openFileDialogTask_MKA
            // 
            this.openFileDialogTask_MKA.FileName = "openFileDialog1";
            // 
            // toolTip_MKA
            // 
            this.toolTip_MKA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MKA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 457);
            this.Controls.Add(this.groupBoxOutputData_MKA);
            this.Controls.Add(this.groupBoxInputData_MKA);
            this.Controls.Add(this.groupBoxTask_MKA);
            this.Controls.Add(this.buttonHelp_MKA);
            this.Controls.Add(this.buttonDone_MKA);
            this.Controls.Add(this.buttonOpenFile_MKA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 10 | Медведев К.А.";
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            this.groupBoxInputData_MKA.ResumeLayout(false);
            this.groupBoxInputData_MKA.PerformLayout();
            this.groupBoxOutputData_MKA.ResumeLayout(false);
            this.groupBoxOutputData_MKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_MKA;
        private System.Windows.Forms.ToolTip toolTip_MKA;
        private System.Windows.Forms.Button buttonDone_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.TextBox textBoxTask_MKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_MKA;
        private System.Windows.Forms.TextBox textBoxInPutData_MKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_MKA;
        private System.Windows.Forms.TextBox textBoxOutPutData_MKA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MKA;
    }
}

