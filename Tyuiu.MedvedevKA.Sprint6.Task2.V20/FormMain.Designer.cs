
namespace Tyuiu.MedvedevKA.Sprint6.Task2.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_MKA = new System.Windows.Forms.GroupBox();
            this.labelYS2_MKA = new System.Windows.Forms.Label();
            this.labelYS1_MKA = new System.Windows.Forms.Label();
            this.groupBoxInputData_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_MKA = new System.Windows.Forms.TextBox();
            this.labelEnd_MKA = new System.Windows.Forms.Label();
            this.textBoxStartStep_MKA = new System.Windows.Forms.TextBox();
            this.labelStart_MKA = new System.Windows.Forms.Label();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.buttonDone_MKA = new System.Windows.Forms.Button();
            this.groupBoxOutputData_MKA = new System.Windows.Forms.GroupBox();
            this.chartFunction_MKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_MKA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRES_MKA = new System.Windows.Forms.Label();
            this.groupBoxTask_MKA.SuspendLayout();
            this.groupBoxInputData_MKA.SuspendLayout();
            this.groupBoxOutputData_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MKA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.labelYS2_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.labelYS1_MKA);
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(546, 343);
            this.groupBoxTask_MKA.TabIndex = 0;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие";
            // 
            // labelYS2_MKA
            // 
            this.labelYS2_MKA.AutoSize = true;
            this.labelYS2_MKA.Location = new System.Drawing.Point(7, 37);
            this.labelYS2_MKA.Name = "labelYS2_MKA";
            this.labelYS2_MKA.Size = new System.Drawing.Size(335, 13);
            this.labelYS2_MKA.TabIndex = 1;
            this.labelYS2_MKA.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // labelYS1_MKA
            // 
            this.labelYS1_MKA.AutoSize = true;
            this.labelYS1_MKA.Location = new System.Drawing.Point(7, 20);
            this.labelYS1_MKA.Name = "labelYS1_MKA";
            this.labelYS1_MKA.Size = new System.Drawing.Size(405, 13);
            this.labelYS1_MKA.TabIndex = 0;
            this.labelYS1_MKA.Text = "Протобулировать функцию (sin(x)/x+1,2 ) -sin(x) * 2 - 2x на заданном диапазоне.";
            // 
            // groupBoxInputData_MKA
            // 
            this.groupBoxInputData_MKA.Controls.Add(this.textBoxStopStep_MKA);
            this.groupBoxInputData_MKA.Controls.Add(this.labelEnd_MKA);
            this.groupBoxInputData_MKA.Controls.Add(this.textBoxStartStep_MKA);
            this.groupBoxInputData_MKA.Controls.Add(this.labelStart_MKA);
            this.groupBoxInputData_MKA.Location = new System.Drawing.Point(13, 362);
            this.groupBoxInputData_MKA.Name = "groupBoxInputData_MKA";
            this.groupBoxInputData_MKA.Size = new System.Drawing.Size(274, 76);
            this.groupBoxInputData_MKA.TabIndex = 1;
            this.groupBoxInputData_MKA.TabStop = false;
            this.groupBoxInputData_MKA.Text = "Ввод данных";
            // 
            // textBoxStopStep_MKA
            // 
            this.textBoxStopStep_MKA.Location = new System.Drawing.Point(136, 37);
            this.textBoxStopStep_MKA.Name = "textBoxStopStep_MKA";
            this.textBoxStopStep_MKA.Size = new System.Drawing.Size(124, 20);
            this.textBoxStopStep_MKA.TabIndex = 3;
            this.textBoxStopStep_MKA.Text = "5";
            // 
            // labelEnd_MKA
            // 
            this.labelEnd_MKA.AutoSize = true;
            this.labelEnd_MKA.Location = new System.Drawing.Point(133, 21);
            this.labelEnd_MKA.Name = "labelEnd_MKA";
            this.labelEnd_MKA.Size = new System.Drawing.Size(69, 13);
            this.labelEnd_MKA.TabIndex = 2;
            this.labelEnd_MKA.Text = "Конец шага:";
            // 
            // textBoxStartStep_MKA
            // 
            this.textBoxStartStep_MKA.Location = new System.Drawing.Point(6, 37);
            this.textBoxStartStep_MKA.Name = "textBoxStartStep_MKA";
            this.textBoxStartStep_MKA.Size = new System.Drawing.Size(124, 20);
            this.textBoxStartStep_MKA.TabIndex = 1;
            this.textBoxStartStep_MKA.Text = "-5";
            // 
            // labelStart_MKA
            // 
            this.labelStart_MKA.AutoSize = true;
            this.labelStart_MKA.Location = new System.Drawing.Point(7, 21);
            this.labelStart_MKA.Name = "labelStart_MKA";
            this.labelStart_MKA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_MKA.TabIndex = 0;
            this.labelStart_MKA.Text = "Старт шага:";
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_MKA.Location = new System.Drawing.Point(294, 363);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(99, 75);
            this.buttonHelp_MKA.TabIndex = 2;
            this.buttonHelp_MKA.Text = "Справка";
            this.buttonHelp_MKA.UseVisualStyleBackColor = false;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // buttonDone_MKA
            // 
            this.buttonDone_MKA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MKA.Location = new System.Drawing.Point(400, 363);
            this.buttonDone_MKA.Name = "buttonDone_MKA";
            this.buttonDone_MKA.Size = new System.Drawing.Size(159, 75);
            this.buttonDone_MKA.TabIndex = 3;
            this.buttonDone_MKA.Text = "Выполнить";
            this.buttonDone_MKA.UseVisualStyleBackColor = false;
            this.buttonDone_MKA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            this.buttonDone_MKA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MKA_MouseDown);
            this.buttonDone_MKA.MouseEnter += new System.EventHandler(this.buttonDone_MKA_MouseEnter);
            this.buttonDone_MKA.MouseLeave += new System.EventHandler(this.buttonDone_MKA_MouseLeave);
            // 
            // groupBoxOutputData_MKA
            // 
            this.groupBoxOutputData_MKA.Controls.Add(this.chartFunction_MKA);
            this.groupBoxOutputData_MKA.Controls.Add(this.dataGridViewFunction_MKA);
            this.groupBoxOutputData_MKA.Controls.Add(this.labelRES_MKA);
            this.groupBoxOutputData_MKA.Location = new System.Drawing.Point(566, 13);
            this.groupBoxOutputData_MKA.Name = "groupBoxOutputData_MKA";
            this.groupBoxOutputData_MKA.Size = new System.Drawing.Size(704, 425);
            this.groupBoxOutputData_MKA.TabIndex = 4;
            this.groupBoxOutputData_MKA.TabStop = false;
            this.groupBoxOutputData_MKA.Text = "Вывод данных";
            // 
            // chartFunction_MKA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_MKA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_MKA.Legends.Add(legend2);
            this.chartFunction_MKA.Location = new System.Drawing.Point(240, 35);
            this.chartFunction_MKA.Name = "chartFunction_MKA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_MKA.Series.Add(series2);
            this.chartFunction_MKA.Size = new System.Drawing.Size(458, 371);
            this.chartFunction_MKA.TabIndex = 2;
            this.chartFunction_MKA.Text = "chart1";
            // 
            // dataGridViewFunction_MKA
            // 
            this.dataGridViewFunction_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_MKA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_MKA.Location = new System.Drawing.Point(6, 35);
            this.dataGridViewFunction_MKA.Name = "dataGridViewFunction_MKA";
            this.dataGridViewFunction_MKA.ReadOnly = true;
            this.dataGridViewFunction_MKA.RowHeadersVisible = false;
            this.dataGridViewFunction_MKA.Size = new System.Drawing.Size(193, 384);
            this.dataGridViewFunction_MKA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            // 
            // labelRES_MKA
            // 
            this.labelRES_MKA.AutoSize = true;
            this.labelRES_MKA.Location = new System.Drawing.Point(7, 19);
            this.labelRES_MKA.Name = "labelRES_MKA";
            this.labelRES_MKA.Size = new System.Drawing.Size(62, 13);
            this.labelRES_MKA.TabIndex = 0;
            this.labelRES_MKA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 450);
            this.Controls.Add(this.groupBoxOutputData_MKA);
            this.Controls.Add(this.buttonDone_MKA);
            this.Controls.Add(this.buttonHelp_MKA);
            this.Controls.Add(this.groupBoxInputData_MKA);
            this.Controls.Add(this.groupBoxTask_MKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 20 | Медведев К.А.";
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            this.groupBoxInputData_MKA.ResumeLayout(false);
            this.groupBoxInputData_MKA.PerformLayout();
            this.groupBoxOutputData_MKA.ResumeLayout(false);
            this.groupBoxOutputData_MKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.Label labelYS2_MKA;
        private System.Windows.Forms.Label labelYS1_MKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_MKA;
        private System.Windows.Forms.Label labelStart_MKA;
        private System.Windows.Forms.TextBox textBoxStartStep_MKA;
        private System.Windows.Forms.Label labelEnd_MKA;
        private System.Windows.Forms.TextBox textBoxStopStep_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.Button buttonDone_MKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_MKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MKA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_MKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.Label labelRES_MKA;
    }
}

