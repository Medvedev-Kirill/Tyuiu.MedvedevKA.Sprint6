
namespace Tyuiu.MedvedevKA.Sprint6.Task0.V4
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
            this.groupBoxTask_MKA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MKA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_MKA = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_MKA = new System.Windows.Forms.GroupBox();
            this.labelVarX_MKA = new System.Windows.Forms.Label();
            this.textBoxVarX_MKA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_MKA = new System.Windows.Forms.GroupBox();
            this.labelRes_MKA = new System.Windows.Forms.Label();
            this.textBoxRes_MKA = new System.Windows.Forms.TextBox();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.buttonDoneClick_MKA = new System.Windows.Forms.Button();
            this.groupBoxTask_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MKA)).BeginInit();
            this.groupBoxInputData_MKA.SuspendLayout();
            this.groupBoxOutputData_MKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.pictureBoxFormula_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.textBoxTask_MKA);
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(775, 186);
            this.groupBoxTask_MKA.TabIndex = 0;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие";
            // 
            // textBoxTask_MKA
            // 
            this.textBoxTask_MKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_MKA.Multiline = true;
            this.textBoxTask_MKA.Name = "textBoxTask_MKA";
            this.textBoxTask_MKA.ReadOnly = true;
            this.textBoxTask_MKA.Size = new System.Drawing.Size(308, 121);
            this.textBoxTask_MKA.TabIndex = 0;
            this.textBoxTask_MKA.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBoxFormula_MKA
            // 
            this.pictureBoxFormula_MKA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_MKA.Image")));
            this.pictureBoxFormula_MKA.Location = new System.Drawing.Point(321, 20);
            this.pictureBoxFormula_MKA.Name = "pictureBoxFormula_MKA";
            this.pictureBoxFormula_MKA.Size = new System.Drawing.Size(454, 121);
            this.pictureBoxFormula_MKA.TabIndex = 1;
            this.pictureBoxFormula_MKA.TabStop = false;
            // 
            // groupBoxInputData_MKA
            // 
            this.groupBoxInputData_MKA.Controls.Add(this.textBoxVarX_MKA);
            this.groupBoxInputData_MKA.Controls.Add(this.labelVarX_MKA);
            this.groupBoxInputData_MKA.Location = new System.Drawing.Point(13, 205);
            this.groupBoxInputData_MKA.Name = "groupBoxInputData_MKA";
            this.groupBoxInputData_MKA.Size = new System.Drawing.Size(315, 131);
            this.groupBoxInputData_MKA.TabIndex = 2;
            this.groupBoxInputData_MKA.TabStop = false;
            this.groupBoxInputData_MKA.Text = "Ввод данных";
            // 
            // labelVarX_MKA
            // 
            this.labelVarX_MKA.AutoSize = true;
            this.labelVarX_MKA.Location = new System.Drawing.Point(7, 20);
            this.labelVarX_MKA.Name = "labelVarX_MKA";
            this.labelVarX_MKA.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_MKA.TabIndex = 0;
            this.labelVarX_MKA.Text = "Переменная X:";
            // 
            // textBoxVarX_MKA
            // 
            this.textBoxVarX_MKA.Location = new System.Drawing.Point(10, 37);
            this.textBoxVarX_MKA.Name = "textBoxVarX_MKA";
            this.textBoxVarX_MKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_MKA.TabIndex = 1;
            this.textBoxVarX_MKA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_MKA_KeyPress);
            // 
            // groupBoxOutputData_MKA
            // 
            this.groupBoxOutputData_MKA.Controls.Add(this.textBoxRes_MKA);
            this.groupBoxOutputData_MKA.Controls.Add(this.labelRes_MKA);
            this.groupBoxOutputData_MKA.Location = new System.Drawing.Point(334, 205);
            this.groupBoxOutputData_MKA.Name = "groupBoxOutputData_MKA";
            this.groupBoxOutputData_MKA.Size = new System.Drawing.Size(454, 131);
            this.groupBoxOutputData_MKA.TabIndex = 3;
            this.groupBoxOutputData_MKA.TabStop = false;
            this.groupBoxOutputData_MKA.Text = "Вывод данных";
            // 
            // labelRes_MKA
            // 
            this.labelRes_MKA.AutoSize = true;
            this.labelRes_MKA.Location = new System.Drawing.Point(7, 20);
            this.labelRes_MKA.Name = "labelRes_MKA";
            this.labelRes_MKA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_MKA.TabIndex = 0;
            this.labelRes_MKA.Text = "Результат:";
            // 
            // textBoxRes_MKA
            // 
            this.textBoxRes_MKA.Location = new System.Drawing.Point(7, 37);
            this.textBoxRes_MKA.Name = "textBoxRes_MKA";
            this.textBoxRes_MKA.ReadOnly = true;
            this.textBoxRes_MKA.Size = new System.Drawing.Size(131, 20);
            this.textBoxRes_MKA.TabIndex = 1;
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MKA.Location = new System.Drawing.Point(334, 342);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(55, 51);
            this.buttonHelp_MKA.TabIndex = 4;
            this.buttonHelp_MKA.Text = "?";
            this.buttonHelp_MKA.UseVisualStyleBackColor = true;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // buttonDoneClick_MKA
            // 
            this.buttonDoneClick_MKA.Location = new System.Drawing.Point(395, 342);
            this.buttonDoneClick_MKA.Name = "buttonDoneClick_MKA";
            this.buttonDoneClick_MKA.Size = new System.Drawing.Size(154, 51);
            this.buttonDoneClick_MKA.TabIndex = 2;
            this.buttonDoneClick_MKA.Text = "Выполнить";
            this.buttonDoneClick_MKA.UseVisualStyleBackColor = true;
            this.buttonDoneClick_MKA.Click += new System.EventHandler(this.buttonDoneClick_MKA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDoneClick_MKA);
            this.Controls.Add(this.buttonHelp_MKA);
            this.Controls.Add(this.groupBoxOutputData_MKA);
            this.Controls.Add(this.groupBoxInputData_MKA);
            this.Controls.Add(this.groupBoxTask_MKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 4 | Медведев К.А.";
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MKA)).EndInit();
            this.groupBoxInputData_MKA.ResumeLayout(false);
            this.groupBoxInputData_MKA.PerformLayout();
            this.groupBoxOutputData_MKA.ResumeLayout(false);
            this.groupBoxOutputData_MKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_MKA;
        private System.Windows.Forms.TextBox textBoxTask_MKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_MKA;
        private System.Windows.Forms.TextBox textBoxVarX_MKA;
        private System.Windows.Forms.Label labelVarX_MKA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_MKA;
        private System.Windows.Forms.TextBox textBoxRes_MKA;
        private System.Windows.Forms.Label labelRes_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.Button buttonDoneClick_MKA;
    }
}

