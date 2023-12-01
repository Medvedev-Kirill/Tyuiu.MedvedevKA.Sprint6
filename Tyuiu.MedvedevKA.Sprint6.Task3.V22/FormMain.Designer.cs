
namespace Tyuiu.MedvedevKA.Sprint6.Task3.V22
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
            this.dataGridViewMatrix_MKA = new System.Windows.Forms.DataGridView();
            this.buttonHelp_MKA = new System.Windows.Forms.Button();
            this.buttonDone_MKA = new System.Windows.Forms.Button();
            this.groupBoxTask_MKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MKA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_MKA
            // 
            this.groupBoxTask_MKA.Controls.Add(this.buttonDone_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.dataGridViewMatrix_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.buttonHelp_MKA);
            this.groupBoxTask_MKA.Controls.Add(this.textBoxTask_MKA);
            this.groupBoxTask_MKA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_MKA.Name = "groupBoxTask_MKA";
            this.groupBoxTask_MKA.Size = new System.Drawing.Size(685, 425);
            this.groupBoxTask_MKA.TabIndex = 0;
            this.groupBoxTask_MKA.TabStop = false;
            this.groupBoxTask_MKA.Text = "Условие";
            // 
            // textBoxTask_MKA
            // 
            this.textBoxTask_MKA.Location = new System.Drawing.Point(7, 11);
            this.textBoxTask_MKA.Multiline = true;
            this.textBoxTask_MKA.Name = "textBoxTask_MKA";
            this.textBoxTask_MKA.ReadOnly = true;
            this.textBoxTask_MKA.Size = new System.Drawing.Size(419, 350);
            this.textBoxTask_MKA.TabIndex = 0;
            this.textBoxTask_MKA.Text = resources.GetString("textBoxTask_MKA.Text");
            // 
            // dataGridViewMatrix_MKA
            // 
            this.dataGridViewMatrix_MKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_MKA.Location = new System.Drawing.Point(433, 11);
            this.dataGridViewMatrix_MKA.Name = "dataGridViewMatrix_MKA";
            this.dataGridViewMatrix_MKA.RowHeadersVisible = false;
            this.dataGridViewMatrix_MKA.Size = new System.Drawing.Size(246, 408);
            this.dataGridViewMatrix_MKA.TabIndex = 1;
            // 
            // buttonHelp_MKA
            // 
            this.buttonHelp_MKA.Location = new System.Drawing.Point(7, 367);
            this.buttonHelp_MKA.Name = "buttonHelp_MKA";
            this.buttonHelp_MKA.Size = new System.Drawing.Size(61, 52);
            this.buttonHelp_MKA.TabIndex = 2;
            this.buttonHelp_MKA.Text = "?";
            this.buttonHelp_MKA.UseVisualStyleBackColor = true;
            this.buttonHelp_MKA.Click += new System.EventHandler(this.buttonHelp_MKA_Click);
            // 
            // buttonDone_MKA
            // 
            this.buttonDone_MKA.Location = new System.Drawing.Point(284, 367);
            this.buttonDone_MKA.Name = "buttonDone_MKA";
            this.buttonDone_MKA.Size = new System.Drawing.Size(142, 51);
            this.buttonDone_MKA.TabIndex = 3;
            this.buttonDone_MKA.Text = "Выполнить";
            this.buttonDone_MKA.UseVisualStyleBackColor = true;
            this.buttonDone_MKA.Click += new System.EventHandler(this.buttonDone_MKA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.groupBoxTask_MKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 22 | Медведев К.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_MKA.ResumeLayout(false);
            this.groupBoxTask_MKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_MKA;
        private System.Windows.Forms.TextBox textBoxTask_MKA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_MKA;
        private System.Windows.Forms.Button buttonHelp_MKA;
        private System.Windows.Forms.Button buttonDone_MKA;
    }
}

