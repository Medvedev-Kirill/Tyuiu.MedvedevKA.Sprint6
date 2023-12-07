
namespace Tyuiu.MedvedevKA.Sprint6.Task5.V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_MKA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.buttonOpenFile_MKA = new System.Windows.Forms.Button();
            this.buttonDone_MKA = new System.Windows.Forms.Button();
            this.textBoxTask_MKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_MKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_MKA = new System.Windows.Forms.DataGridView();
            this.chartDiag_MKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_MKA.SuspendLayout();
            this.groupBoxOutPutData_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MKA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.buttonHelp_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.buttonOpenFile_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.buttonDone_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.textBoxTask_MKA);
            this.groupBoxTask_MKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(800, 92);
            this.groupBoxTask_MKA.TabIndex = 0;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие:";
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_MKA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp_MKA.Location = new System.Drawing.Point(679, 16);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(115, 60);
            this.buttonHelp_MKA.TabIndex = 3;
            this.buttonHelp_MKA.Text = "Справка";
            this.buttonHelp_MKA.UseVisualStyleBackColor = false;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // buttonOpenFile_MKA
            // 
            this.buttonOpenFile_MKA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpenFile_MKA.Location = new System.Drawing.Point(558, 16);
            this.buttonOpenFile_MKA.Name = "buttonOpenFile_MKA";
            this.buttonOpenFile_MKA.Size = new System.Drawing.Size(115, 60);
            this.buttonOpenFile_MKA.TabIndex = 2;
            this.buttonOpenFile_MKA.Text = "Открыть файл";
            this.buttonOpenFile_MKA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_MKA.Click += new System.EventHandler(this.buttonOpenFile_MKA_Click);
            // 
            // buttonDone_MKA
            // 
            this.buttonDone_MKA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MKA.Location = new System.Drawing.Point(437, 17);
            this.buttonDone_MKA.Name = "buttonDone_MKA";
            this.buttonDone_MKA.Size = new System.Drawing.Size(115, 60);
            this.buttonDone_MKA.TabIndex = 1;
            this.buttonDone_MKA.Text = "Выполнить";
            this.buttonDone_MKA.UseVisualStyleBackColor = false;
            this.buttonDone_MKA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            // 
            // textBoxTask_MKA
            // 
            this.textBoxTask_MKA.Location = new System.Drawing.Point(8, 16);
            this.textBoxTask_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTask_MKA.Multiline = true;
            this.textBoxTask_MKA.Name = "textBoxTask_MKA";
            this.textBoxTask_MKA.ReadOnly = true;
            this.textBoxTask_MKA.Size = new System.Drawing.Size(411, 61);
            this.textBoxTask_MKA.TabIndex = 0;
            this.textBoxTask_MKA.Text = resources.GetString("textBoxTask_MKA.Text");
            // 
            // groupBoxOutPutData_MKA
            // 
            this.groupBoxOutPutData_MKA.Controls.Add(this.dataGridViewRes_MKA);
            this.groupBoxOutPutData_MKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPutData_MKA.Location = new System.Drawing.Point(0, 92);
            this.groupBoxOutPutData_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxOutPutData_MKA.Name = "groupBoxOutPutData_MKA";
            this.groupBoxOutPutData_MKA.Size = new System.Drawing.Size(200, 358);
            this.groupBoxOutPutData_MKA.TabIndex = 1;
            this.groupBoxOutPutData_MKA.TabStop = false;
            this.groupBoxOutPutData_MKA.Text = "Вывод данных:";
            // 
            // dataGridViewRes_MKA
            // 
            this.dataGridViewRes_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_MKA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewRes_MKA.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewRes_MKA.Name = "dataGridViewRes_MKA";
            this.dataGridViewRes_MKA.ReadOnly = true;
            this.dataGridViewRes_MKA.RowHeadersVisible = false;
            this.dataGridViewRes_MKA.Size = new System.Drawing.Size(187, 326);
            this.dataGridViewRes_MKA.TabIndex = 0;
            // 
            // chartDiag_MKA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_MKA.ChartAreas.Add(chartArea2);
            this.chartDiag_MKA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiag_MKA.Legends.Add(legend2);
            this.chartDiag_MKA.Location = new System.Drawing.Point(200, 92);
            this.chartDiag_MKA.Name = "chartDiag_MKA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiag_MKA.Series.Add(series2);
            this.chartDiag_MKA.Size = new System.Drawing.Size(600, 358);
            this.chartDiag_MKA.TabIndex = 2;
            this.chartDiag_MKA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartDiag_MKA);
            this.Controls.Add(this.groupBoxOutPutData_MKA);
            this.Controls.Add(this.groupBoxTask_MKA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 1 | Медведев К.А.";
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            this.groupBoxOutPutData_MKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_MKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.TextBox textBoxTask_MKA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_MKA;
        private System.Windows.Forms.DataGridView dataGridViewRes_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.Button buttonOpenFile_MKA;
        private System.Windows.Forms.Button buttonDone_MKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_MKA;
    }
}

