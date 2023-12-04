
namespace Tyuiu.MedvedevKA.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_MKA = new System.Windows.Forms.GroupBox();
            this.buttonSave_MKA = new System.Windows.Forms.Button();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.buttonDone_MKA = new System.Windows.Forms.Button();
            this.groupBoxIntputData_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_MKA = new System.Windows.Forms.TextBox();
            this.labelStopStep_MKA = new System.Windows.Forms.Label();
            this.textBoxStart_MKA = new System.Windows.Forms.TextBox();
            this.labelStartStep_MKA = new System.Windows.Forms.Label();
            this.textBoxTask_MKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxRES_MKA = new System.Windows.Forms.TextBox();
            this.chartFunction_MKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_MKA.SuspendLayout();
            this.groupBoxIntputData_MKA.SuspendLayout();
            this.groupBoxOutput_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MKA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.buttonSave_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.buttonHelp_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.buttonDone_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.groupBoxIntputData_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.textBoxTask_MKA);
            this.groupBoxTask_MKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(1036, 83);
            this.groupBoxTask_MKA.TabIndex = 0;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие:";
            // 
            // buttonSave_MKA
            // 
            this.buttonSave_MKA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_MKA.Location = new System.Drawing.Point(831, 12);
            this.buttonSave_MKA.Name = "buttonSave_MKA";
            this.buttonSave_MKA.Size = new System.Drawing.Size(87, 60);
            this.buttonSave_MKA.TabIndex = 4;
            this.buttonSave_MKA.Text = "Сохранить";
            this.buttonSave_MKA.UseVisualStyleBackColor = false;
            this.buttonSave_MKA.Click += new System.EventHandler(this.buttonSave_MKA_Click);
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MKA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_MKA.Location = new System.Drawing.Point(924, 12);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(100, 60);
            this.buttonHelp_MKA.TabIndex = 3;
            this.buttonHelp_MKA.Text = "Справка";
            this.buttonHelp_MKA.UseVisualStyleBackColor = false;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // buttonDone_MKA
            // 
            this.buttonDone_MKA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MKA.Location = new System.Drawing.Point(725, 12);
            this.buttonDone_MKA.Name = "buttonDone_MKA";
            this.buttonDone_MKA.Size = new System.Drawing.Size(100, 60);
            this.buttonDone_MKA.TabIndex = 2;
            this.buttonDone_MKA.Text = "Выполнить";
            this.buttonDone_MKA.UseVisualStyleBackColor = false;
            this.buttonDone_MKA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            // 
            // groupBoxIntputData_MKA
            // 
            this.groupBoxIntputData_MKA.Controls.Add(this.textBoxStop_MKA);
            this.groupBoxIntputData_MKA.Controls.Add(this.labelStopStep_MKA);
            this.groupBoxIntputData_MKA.Controls.Add(this.textBoxStart_MKA);
            this.groupBoxIntputData_MKA.Controls.Add(this.labelStartStep_MKA);
            this.groupBoxIntputData_MKA.Location = new System.Drawing.Point(467, 12);
            this.groupBoxIntputData_MKA.Name = "groupBoxIntputData_MKA";
            this.groupBoxIntputData_MKA.Size = new System.Drawing.Size(243, 60);
            this.groupBoxIntputData_MKA.TabIndex = 1;
            this.groupBoxIntputData_MKA.TabStop = false;
            this.groupBoxIntputData_MKA.Text = "Ввод данных";
            // 
            // textBoxStop_MKA
            // 
            this.textBoxStop_MKA.Location = new System.Drawing.Point(131, 33);
            this.textBoxStop_MKA.Name = "textBoxStop_MKA";
            this.textBoxStop_MKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_MKA.TabIndex = 3;
            this.textBoxStop_MKA.Text = "5";
            // 
            // labelStopStep_MKA
            // 
            this.labelStopStep_MKA.AutoSize = true;
            this.labelStopStep_MKA.Location = new System.Drawing.Point(128, 16);
            this.labelStopStep_MKA.Name = "labelStopStep_MKA";
            this.labelStopStep_MKA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_MKA.TabIndex = 2;
            this.labelStopStep_MKA.Text = "Конец шага:";
            // 
            // textBoxStart_MKA
            // 
            this.textBoxStart_MKA.Location = new System.Drawing.Point(9, 33);
            this.textBoxStart_MKA.Name = "textBoxStart_MKA";
            this.textBoxStart_MKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_MKA.TabIndex = 1;
            this.textBoxStart_MKA.Text = "-5";
            // 
            // labelStartStep_MKA
            // 
            this.labelStartStep_MKA.AutoSize = true;
            this.labelStartStep_MKA.Location = new System.Drawing.Point(6, 16);
            this.labelStartStep_MKA.Name = "labelStartStep_MKA";
            this.labelStartStep_MKA.Size = new System.Drawing.Size(65, 13);
            this.labelStartStep_MKA.TabIndex = 0;
            this.labelStartStep_MKA.Text = "СтартШага:";
            // 
            // textBoxTask_MKA
            // 
            this.textBoxTask_MKA.Location = new System.Drawing.Point(3, 12);
            this.textBoxTask_MKA.Multiline = true;
            this.textBoxTask_MKA.Name = "textBoxTask_MKA";
            this.textBoxTask_MKA.ReadOnly = true;
            this.textBoxTask_MKA.Size = new System.Drawing.Size(458, 60);
            this.textBoxTask_MKA.TabIndex = 0;
            this.textBoxTask_MKA.Text = resources.GetString("textBoxTask_MKA.Text");
            // 
            // groupBoxOutput_MKA
            // 
            this.groupBoxOutput_MKA.Controls.Add(this.textBoxRES_MKA);
            this.groupBoxOutput_MKA.Location = new System.Drawing.Point(3, 90);
            this.groupBoxOutput_MKA.Name = "groupBoxOutput_MKA";
            this.groupBoxOutput_MKA.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxOutput_MKA.Size = new System.Drawing.Size(200, 309);
            this.groupBoxOutput_MKA.TabIndex = 1;
            this.groupBoxOutput_MKA.TabStop = false;
            this.groupBoxOutput_MKA.Text = "Вывод";
            // 
            // textBoxRES_MKA
            // 
            this.textBoxRES_MKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRES_MKA.Location = new System.Drawing.Point(5, 18);
            this.textBoxRES_MKA.Multiline = true;
            this.textBoxRES_MKA.Name = "textBoxRES_MKA";
            this.textBoxRES_MKA.ReadOnly = true;
            this.textBoxRES_MKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRES_MKA.Size = new System.Drawing.Size(190, 286);
            this.textBoxRES_MKA.TabIndex = 0;
            // 
            // chartFunction_MKA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_MKA.ChartAreas.Add(chartArea1);
            this.chartFunction_MKA.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartFunction_MKA.Legends.Add(legend1);
            this.chartFunction_MKA.Location = new System.Drawing.Point(222, 83);
            this.chartFunction_MKA.Name = "chartFunction_MKA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MKA.Series.Add(series1);
            this.chartFunction_MKA.Size = new System.Drawing.Size(814, 328);
            this.chartFunction_MKA.TabIndex = 2;
            this.chartFunction_MKA.Text = "chartFunction";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "TitleFunction";
            title1.Text = "График функции f(x)=4 - 2X+(2+Cos(x)/ 2x-2)";
            this.chartFunction_MKA.Titles.Add(title1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 411);
            this.Controls.Add(this.chartFunction_MKA);
            this.Controls.Add(this.groupBoxOutput_MKA);
            this.Controls.Add(this.groupBoxTask_MKA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 23 | Медведев К.А.";
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            this.groupBoxIntputData_MKA.ResumeLayout(false);
            this.groupBoxIntputData_MKA.PerformLayout();
            this.groupBoxOutput_MKA.ResumeLayout(false);
            this.groupBoxOutput_MKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.TextBox textBoxTask_MKA;
        private System.Windows.Forms.GroupBox groupBoxIntputData_MKA;
        private System.Windows.Forms.TextBox textBoxStop_MKA;
        private System.Windows.Forms.Label labelStopStep_MKA;
        private System.Windows.Forms.TextBox textBoxStart_MKA;
        private System.Windows.Forms.Label labelStartStep_MKA;
        private System.Windows.Forms.Button buttonDone_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.GroupBox groupBoxOutput_MKA;
        private System.Windows.Forms.TextBox textBoxRES_MKA;
        private System.Windows.Forms.Button buttonSave_MKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MKA;
    }
}

