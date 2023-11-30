
namespace Tyuiu.MedvedevKA.Sprint6.Task1.V4
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
            this.groupBoxTask_MKA = new System.Windows.Forms.GroupBox();
            this.labelText2_MKA = new System.Windows.Forms.Label();
            this.labelText1_MKA = new System.Windows.Forms.Label();
            this.groupBoxInputData_MKA = new System.Windows.Forms.GroupBox();
            this.labelStart_MKA = new System.Windows.Forms.Label();
            this.textBoxStartStep_MKA = new System.Windows.Forms.TextBox();
            this.labelStop_MKA = new System.Windows.Forms.Label();
            this.textBoxStopStep_MKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_MKA = new System.Windows.Forms.GroupBox();
            this.labelRES_MKA = new System.Windows.Forms.Label();
            this.textBoxRes_MKA = new System.Windows.Forms.TextBox();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.buttonDone_MKA = new System.Windows.Forms.Button();
            this.groupBoxTask_MKA.SuspendLayout();
            this.groupBoxInputData_MKA.SuspendLayout();
            this.groupBoxOutputData_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.labelText2_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.labelText1_MKA);
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(541, 346);
            this.groupBoxTask_MKA.TabIndex = 0;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие";
            // 
            // labelText2_MKA
            // 
            this.labelText2_MKA.AutoSize = true;
            this.labelText2_MKA.Location = new System.Drawing.Point(6, 29);
            this.labelText2_MKA.Name = "labelText2_MKA";
            this.labelText2_MKA.Size = new System.Drawing.Size(190, 13);
            this.labelText2_MKA.TabIndex = 1;
            this.labelText2_MKA.Text = "Результат вывести в виде таблицы.";
            // 
            // labelText1_MKA
            // 
            this.labelText1_MKA.AutoSize = true;
            this.labelText1_MKA.Location = new System.Drawing.Point(6, 16);
            this.labelText1_MKA.Name = "labelText1_MKA";
            this.labelText1_MKA.Size = new System.Drawing.Size(405, 13);
            this.labelText1_MKA.TabIndex = 0;
            this.labelText1_MKA.Text = "Протобулировать функцию (sin(x)/x+1,2 ) -sin(x) * 2 - 2x на заданном диапазоне.";
            // 
            // groupBoxInputData_MKA
            // 
            this.groupBoxInputData_MKA.Controls.Add(this.textBoxStopStep_MKA);
            this.groupBoxInputData_MKA.Controls.Add(this.labelStop_MKA);
            this.groupBoxInputData_MKA.Controls.Add(this.textBoxStartStep_MKA);
            this.groupBoxInputData_MKA.Controls.Add(this.labelStart_MKA);
            this.groupBoxInputData_MKA.Location = new System.Drawing.Point(13, 365);
            this.groupBoxInputData_MKA.Name = "groupBoxInputData_MKA";
            this.groupBoxInputData_MKA.Size = new System.Drawing.Size(288, 73);
            this.groupBoxInputData_MKA.TabIndex = 1;
            this.groupBoxInputData_MKA.TabStop = false;
            this.groupBoxInputData_MKA.Text = "Ввод данных";
            // 
            // labelStart_MKA
            // 
            this.labelStart_MKA.AutoSize = true;
            this.labelStart_MKA.Location = new System.Drawing.Point(6, 21);
            this.labelStart_MKA.Name = "labelStart_MKA";
            this.labelStart_MKA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_MKA.TabIndex = 0;
            this.labelStart_MKA.Text = "Старт шага:";
            // 
            // textBoxStartStep_MKA
            // 
            this.textBoxStartStep_MKA.Location = new System.Drawing.Point(9, 38);
            this.textBoxStartStep_MKA.Name = "textBoxStartStep_MKA";
            this.textBoxStartStep_MKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_MKA.TabIndex = 1;
            this.textBoxStartStep_MKA.Text = "-5";
            // 
            // labelStop_MKA
            // 
            this.labelStop_MKA.AutoSize = true;
            this.labelStop_MKA.Location = new System.Drawing.Point(141, 21);
            this.labelStop_MKA.Name = "labelStop_MKA";
            this.labelStop_MKA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_MKA.TabIndex = 2;
            this.labelStop_MKA.Text = "Конец шага:";
            // 
            // textBoxStopStep_MKA
            // 
            this.textBoxStopStep_MKA.Location = new System.Drawing.Point(144, 38);
            this.textBoxStopStep_MKA.Name = "textBoxStopStep_MKA";
            this.textBoxStopStep_MKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_MKA.TabIndex = 3;
            this.textBoxStopStep_MKA.Text = "5";
            // 
            // groupBoxOutputData_MKA
            // 
            this.groupBoxOutputData_MKA.Controls.Add(this.textBoxRes_MKA);
            this.groupBoxOutputData_MKA.Controls.Add(this.labelRES_MKA);
            this.groupBoxOutputData_MKA.Location = new System.Drawing.Point(561, 13);
            this.groupBoxOutputData_MKA.Name = "groupBoxOutputData_MKA";
            this.groupBoxOutputData_MKA.Size = new System.Drawing.Size(227, 425);
            this.groupBoxOutputData_MKA.TabIndex = 2;
            this.groupBoxOutputData_MKA.TabStop = false;
            this.groupBoxOutputData_MKA.Text = "Вывод данных";
            // 
            // labelRES_MKA
            // 
            this.labelRES_MKA.AutoSize = true;
            this.labelRES_MKA.Location = new System.Drawing.Point(7, 16);
            this.labelRES_MKA.Name = "labelRES_MKA";
            this.labelRES_MKA.Size = new System.Drawing.Size(62, 13);
            this.labelRES_MKA.TabIndex = 0;
            this.labelRES_MKA.Text = "Результат:";
            // 
            // textBoxRes_MKA
            // 
            this.textBoxRes_MKA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_MKA.Location = new System.Drawing.Point(7, 29);
            this.textBoxRes_MKA.Multiline = true;
            this.textBoxRes_MKA.Name = "textBoxRes_MKA";
            this.textBoxRes_MKA.ReadOnly = true;
            this.textBoxRes_MKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_MKA.Size = new System.Drawing.Size(220, 390);
            this.textBoxRes_MKA.TabIndex = 1;
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_MKA.Location = new System.Drawing.Point(308, 366);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(93, 72);
            this.buttonHelp_MKA.TabIndex = 3;
            this.buttonHelp_MKA.Text = "Справка";
            this.buttonHelp_MKA.UseVisualStyleBackColor = false;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // buttonDone_MKA
            // 
            this.buttonDone_MKA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MKA.Location = new System.Drawing.Point(408, 366);
            this.buttonDone_MKA.Name = "buttonDone_MKA";
            this.buttonDone_MKA.Size = new System.Drawing.Size(146, 72);
            this.buttonDone_MKA.TabIndex = 4;
            this.buttonDone_MKA.Text = "Выполнить";
            this.buttonDone_MKA.UseVisualStyleBackColor = false;
            this.buttonDone_MKA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_MKA);
            this.Controls.Add(this.buttonHelp_MKA);
            this.Controls.Add(this.groupBoxOutputData_MKA);
            this.Controls.Add(this.groupBoxInputData_MKA);
            this.Controls.Add(this.groupBoxTask_MKA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 4 | Медведев К.А.";
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            this.groupBoxInputData_MKA.ResumeLayout(false);
            this.groupBoxInputData_MKA.PerformLayout();
            this.groupBoxOutputData_MKA.ResumeLayout(false);
            this.groupBoxOutputData_MKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.Label labelText2_MKA;
        private System.Windows.Forms.Label labelText1_MKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_MKA;
        private System.Windows.Forms.Label labelStart_MKA;
        private System.Windows.Forms.TextBox textBoxStopStep_MKA;
        private System.Windows.Forms.Label labelStop_MKA;
        private System.Windows.Forms.TextBox textBoxStartStep_MKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_MKA;
        private System.Windows.Forms.TextBox textBoxRes_MKA;
        private System.Windows.Forms.Label labelRES_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.Button buttonDone_MKA;
    }
}

