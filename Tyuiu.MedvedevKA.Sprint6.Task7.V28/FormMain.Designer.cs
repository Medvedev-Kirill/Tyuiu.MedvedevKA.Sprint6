
namespace Tyuiu.MedvedevKA.Sprint6.Task7.V28
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
            this.buttonSave_MKA = new System.Windows.Forms.Button();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.panelTop_MKA = new System.Windows.Forms.Panel();
            this.groupBoxTask_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxTak_MKA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_MKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutMatrix_MKA = new System.Windows.Forms.DataGridView();
            this.groupBoxOut_MKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutMatrix_MKA = new System.Windows.Forms.DataGridView();
            this.panelTask_MKA = new System.Windows.Forms.Panel();
            this.panelInPut_MKA = new System.Windows.Forms.Panel();
            this.panelOutPut_MKA = new System.Windows.Forms.Panel();
            this.splitterSeparator_MKA = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_MKA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MKA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_MKA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_MKA.SuspendLayout();
            this.groupBoxTask_MKA.SuspendLayout();
            this.groupBoxInPut_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_MKA)).BeginInit();
            this.groupBoxOut_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_MKA)).BeginInit();
            this.panelTask_MKA.SuspendLayout();
            this.panelInPut_MKA.SuspendLayout();
            this.panelOutPut_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_MKA
            // 
            this.buttonOpenFile_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_MKA.Image")));
            this.buttonOpenFile_MKA.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_MKA.Name = "buttonOpenFile_MKA";
            this.buttonOpenFile_MKA.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_MKA.TabIndex = 0;
            this.toolTip_MKA.SetToolTip(this.buttonOpenFile_MKA, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_MKA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MKA.Click += new System.EventHandler(this.buttonOpenFile_MKA_Click);
            this.buttonOpenFile_MKA.MouseEnter += new System.EventHandler(this.buttonOpenFile_MKA_MouseEnter);
            // 
            // buttonDone_MKA
            // 
            this.buttonDone_MKA.Enabled = false;
            this.buttonDone_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_MKA.Image")));
            this.buttonDone_MKA.Location = new System.Drawing.Point(84, 3);
            this.buttonDone_MKA.Name = "buttonDone_MKA";
            this.buttonDone_MKA.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_MKA.TabIndex = 1;
            this.toolTip_MKA.SetToolTip(this.buttonDone_MKA, "Выполнить обработку данных");
            this.buttonDone_MKA.UseVisualStyleBackColor = true;
            this.buttonDone_MKA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            this.buttonDone_MKA.MouseEnter += new System.EventHandler(this.buttonDone_MKA_MouseEnter);
            // 
            // buttonSave_MKA
            // 
            this.buttonSave_MKA.Enabled = false;
            this.buttonSave_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_MKA.Image")));
            this.buttonSave_MKA.Location = new System.Drawing.Point(165, 3);
            this.buttonSave_MKA.Name = "buttonSave_MKA";
            this.buttonSave_MKA.Size = new System.Drawing.Size(75, 55);
            this.buttonSave_MKA.TabIndex = 2;
            this.toolTip_MKA.SetToolTip(this.buttonSave_MKA, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_MKA.UseVisualStyleBackColor = true;
            this.buttonSave_MKA.Click += new System.EventHandler(this.buttonSave_MKA_Click);
            this.buttonSave_MKA.MouseEnter += new System.EventHandler(this.buttonSave_MKA_MouseEnter);
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MKA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_MKA.Image")));
            this.buttonHelp_MKA.Location = new System.Drawing.Point(729, 3);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_MKA.TabIndex = 3;
            this.toolTip_MKA.SetToolTip(this.buttonHelp_MKA, "Сведение о программе");
            this.buttonHelp_MKA.UseVisualStyleBackColor = true;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            this.buttonHelp_MKA.MouseEnter += new System.EventHandler(this.buttonHelp_MKA_MouseEnter);
            // 
            // panelTop_MKA
            // 
            this.panelTop_MKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop_MKA.Controls.Add(this.buttonOpenFile_MKA);
            this.panelTop_MKA.Controls.Add(this.buttonHelp_MKA);
            this.panelTop_MKA.Controls.Add(this.buttonDone_MKA);
            this.panelTop_MKA.Controls.Add(this.buttonSave_MKA);
            this.panelTop_MKA.Location = new System.Drawing.Point(1, 1);
            this.panelTop_MKA.Name = "panelTop_MKA";
            this.panelTop_MKA.Size = new System.Drawing.Size(810, 60);
            this.panelTop_MKA.TabIndex = 4;
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.textBoxTak_MKA);
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(5, 11);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(800, 72);
            this.groupBoxTask_MKA.TabIndex = 5;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие:";
            // 
            // textBoxTak_MKA
            // 
            this.textBoxTak_MKA.Location = new System.Drawing.Point(12, 20);
            this.textBoxTak_MKA.Multiline = true;
            this.textBoxTak_MKA.Name = "textBoxTak_MKA";
            this.textBoxTak_MKA.ReadOnly = true;
            this.textBoxTak_MKA.Size = new System.Drawing.Size(782, 48);
            this.textBoxTak_MKA.TabIndex = 0;
            this.textBoxTak_MKA.Text = resources.GetString("textBoxTak_MKA.Text");
            // 
            // groupBoxInPut_MKA
            // 
            this.groupBoxInPut_MKA.Controls.Add(this.dataGridViewInPutMatrix_MKA);
            this.groupBoxInPut_MKA.Location = new System.Drawing.Point(4, 5);
            this.groupBoxInPut_MKA.Name = "groupBoxInPut_MKA";
            this.groupBoxInPut_MKA.Size = new System.Drawing.Size(390, 280);
            this.groupBoxInPut_MKA.TabIndex = 6;
            this.groupBoxInPut_MKA.TabStop = false;
            this.groupBoxInPut_MKA.Text = "Ввод:";
            // 
            // dataGridViewInPutMatrix_MKA
            // 
            this.dataGridViewInPutMatrix_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutMatrix_MKA.ColumnHeadersVisible = false;
            this.dataGridViewInPutMatrix_MKA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewInPutMatrix_MKA.Name = "dataGridViewInPutMatrix_MKA";
            this.dataGridViewInPutMatrix_MKA.ReadOnly = true;
            this.dataGridViewInPutMatrix_MKA.RowHeadersVisible = false;
            this.dataGridViewInPutMatrix_MKA.Size = new System.Drawing.Size(377, 254);
            this.dataGridViewInPutMatrix_MKA.TabIndex = 0;
            // 
            // groupBoxOut_MKA
            // 
            this.groupBoxOut_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut_MKA.Controls.Add(this.dataGridViewOutPutMatrix_MKA);
            this.groupBoxOut_MKA.Location = new System.Drawing.Point(15, 7);
            this.groupBoxOut_MKA.Name = "groupBoxOut_MKA";
            this.groupBoxOut_MKA.Size = new System.Drawing.Size(390, 280);
            this.groupBoxOut_MKA.TabIndex = 7;
            this.groupBoxOut_MKA.TabStop = false;
            this.groupBoxOut_MKA.Text = "Вывод:";
            // 
            // dataGridViewOutPutMatrix_MKA
            // 
            this.dataGridViewOutPutMatrix_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutMatrix_MKA.ColumnHeadersVisible = false;
            this.dataGridViewOutPutMatrix_MKA.Location = new System.Drawing.Point(7, 18);
            this.dataGridViewOutPutMatrix_MKA.Name = "dataGridViewOutPutMatrix_MKA";
            this.dataGridViewOutPutMatrix_MKA.ReadOnly = true;
            this.dataGridViewOutPutMatrix_MKA.RowHeadersVisible = false;
            this.dataGridViewOutPutMatrix_MKA.Size = new System.Drawing.Size(377, 254);
            this.dataGridViewOutPutMatrix_MKA.TabIndex = 0;
            // 
            // panelTask_MKA
            // 
            this.panelTask_MKA.Controls.Add(this.groupBoxTask_MKA);
            this.panelTask_MKA.Location = new System.Drawing.Point(1, 66);
            this.panelTask_MKA.Name = "panelTask_MKA";
            this.panelTask_MKA.Size = new System.Drawing.Size(810, 86);
            this.panelTask_MKA.TabIndex = 8;
            // 
            // panelInPut_MKA
            // 
            this.panelInPut_MKA.Controls.Add(this.groupBoxInPut_MKA);
            this.panelInPut_MKA.Location = new System.Drawing.Point(1, 151);
            this.panelInPut_MKA.Name = "panelInPut_MKA";
            this.panelInPut_MKA.Size = new System.Drawing.Size(405, 315);
            this.panelInPut_MKA.TabIndex = 9;
            // 
            // panelOutPut_MKA
            // 
            this.panelOutPut_MKA.Controls.Add(this.splitterSeparator_MKA);
            this.panelOutPut_MKA.Controls.Add(this.groupBoxOut_MKA);
            this.panelOutPut_MKA.Location = new System.Drawing.Point(401, 151);
            this.panelOutPut_MKA.Name = "panelOutPut_MKA";
            this.panelOutPut_MKA.Size = new System.Drawing.Size(410, 315);
            this.panelOutPut_MKA.TabIndex = 10;
            // 
            // splitterSeparator_MKA
            // 
            this.splitterSeparator_MKA.Location = new System.Drawing.Point(0, 0);
            this.splitterSeparator_MKA.Name = "splitterSeparator_MKA";
            this.splitterSeparator_MKA.Size = new System.Drawing.Size(10, 315);
            this.splitterSeparator_MKA.TabIndex = 8;
            this.splitterSeparator_MKA.TabStop = false;
            // 
            // openFileDialogTask_MKA
            // 
            this.openFileDialogTask_MKA.FileName = "openFileDialog";
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
            this.ClientSize = new System.Drawing.Size(820, 465);
            this.Controls.Add(this.panelOutPut_MKA);
            this.Controls.Add(this.panelInPut_MKA);
            this.Controls.Add(this.panelTask_MKA);
            this.Controls.Add(this.panelTop_MKA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Медведев К.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            this.groupBoxInPut_MKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_MKA)).EndInit();
            this.groupBoxOut_MKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_MKA)).EndInit();
            this.panelTask_MKA.ResumeLayout(false);
            this.panelInPut_MKA.ResumeLayout(false);
            this.panelOutPut_MKA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_MKA;
        private System.Windows.Forms.Button buttonDone_MKA;
        private System.Windows.Forms.Button buttonSave_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.Panel panelTop_MKA;
        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.TextBox textBoxTak_MKA;
        private System.Windows.Forms.GroupBox groupBoxInPut_MKA;
        private System.Windows.Forms.GroupBox groupBoxOut_MKA;
        private System.Windows.Forms.Panel panelTask_MKA;
        private System.Windows.Forms.Panel panelInPut_MKA;
        private System.Windows.Forms.Panel panelOutPut_MKA;
        private System.Windows.Forms.DataGridView dataGridViewInPutMatrix_MKA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutMatrix_MKA;
        private System.Windows.Forms.Splitter splitterSeparator_MKA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MKA;
        private System.Windows.Forms.ToolTip toolTip_MKA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_MKA;
    }
}

