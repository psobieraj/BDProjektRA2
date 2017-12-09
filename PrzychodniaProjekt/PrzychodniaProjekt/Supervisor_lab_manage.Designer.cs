namespace PrzychodniaProjekt
{
    partial class Supervisor_lab_manage
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
            this.buttonConfirmExam = new System.Windows.Forms.Button();
            this.buttonCancelExam = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfirmExam
            // 
            this.buttonConfirmExam.Location = new System.Drawing.Point(60, 254);
            this.buttonConfirmExam.Name = "buttonConfirmExam";
            this.buttonConfirmExam.Size = new System.Drawing.Size(108, 23);
            this.buttonConfirmExam.TabIndex = 0;
            this.buttonConfirmExam.Text = "Zatwierdź badanie";
            this.buttonConfirmExam.UseVisualStyleBackColor = true;
            // 
            // buttonCancelExam
            // 
            this.buttonCancelExam.Location = new System.Drawing.Point(201, 253);
            this.buttonCancelExam.Name = "buttonCancelExam";
            this.buttonCancelExam.Size = new System.Drawing.Size(109, 23);
            this.buttonCancelExam.TabIndex = 1;
            this.buttonCancelExam.Text = "Anuluj badanie";
            this.buttonCancelExam.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(347, 253);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // Supervisor_lab_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 325);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCancelExam);
            this.Controls.Add(this.buttonConfirmExam);
            this.Name = "Supervisor_lab_manage";
            this.Text = "Supervisor_lab_manage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmExam;
        private System.Windows.Forms.Button buttonCancelExam;
        private System.Windows.Forms.Button buttonBack;
    }
}