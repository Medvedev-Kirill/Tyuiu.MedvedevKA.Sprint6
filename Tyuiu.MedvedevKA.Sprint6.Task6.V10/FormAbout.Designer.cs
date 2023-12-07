
namespace Tyuiu.MedvedevKA.Sprint6.Task6.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_MKA = new System.Windows.Forms.PictureBox();
            this.labelInfo_MKA = new System.Windows.Forms.Label();
            this.buttonOK_MKA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MKA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_MKA
            // 
            this.pictureBoxAvatar_MKA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_MKA.Image")));
            this.pictureBoxAvatar_MKA.Location = new System.Drawing.Point(12, 34);
            this.pictureBoxAvatar_MKA.Name = "pictureBoxAvatar_MKA";
            this.pictureBoxAvatar_MKA.Size = new System.Drawing.Size(129, 130);
            this.pictureBoxAvatar_MKA.TabIndex = 0;
            this.pictureBoxAvatar_MKA.TabStop = false;
            // 
            // labelInfo_MKA
            // 
            this.labelInfo_MKA.AutoSize = true;
            this.labelInfo_MKA.Location = new System.Drawing.Point(147, 12);
            this.labelInfo_MKA.Name = "labelInfo_MKA";
            this.labelInfo_MKA.Size = new System.Drawing.Size(290, 117);
            this.labelInfo_MKA.TabIndex = 1;
            this.labelInfo_MKA.Text = resources.GetString("labelInfo_MKA.Text");
            // 
            // buttonOK_MKA
            // 
            this.buttonOK_MKA.Location = new System.Drawing.Point(362, 141);
            this.buttonOK_MKA.Name = "buttonOK_MKA";
            this.buttonOK_MKA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_MKA.TabIndex = 2;
            this.buttonOK_MKA.Text = "OK";
            this.buttonOK_MKA.UseVisualStyleBackColor = true;
            this.buttonOK_MKA.Click += new System.EventHandler(this.buttonOK_MKA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 180);
            this.Controls.Add(this.buttonOK_MKA);
            this.Controls.Add(this.labelInfo_MKA);
            this.Controls.Add(this.pictureBoxAvatar_MKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_MKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_MKA;
        private System.Windows.Forms.Label labelInfo_MKA;
        private System.Windows.Forms.Button buttonOK_MKA;
    }
}