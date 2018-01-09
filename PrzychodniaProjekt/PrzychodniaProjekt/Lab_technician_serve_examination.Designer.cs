namespace PrzychodniaProjekt
{
    partial class Lab_technician_serve_examination
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
            this.textBoxExaminationResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExaminationCode = new System.Windows.Forms.TextBox();
            this.textBoxExaminationName = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonServe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxDoctorComments = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxExaminationResult
            // 
            this.textBoxExaminationResult.Location = new System.Drawing.Point(12, 60);
            this.textBoxExaminationResult.Multiline = true;
            this.textBoxExaminationResult.Name = "textBoxExaminationResult";
            this.textBoxExaminationResult.Size = new System.Drawing.Size(408, 97);
            this.textBoxExaminationResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wynik badania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwa badania";
            // 
            // textBoxExaminationCode
            // 
            this.textBoxExaminationCode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxExaminationCode.Enabled = false;
            this.textBoxExaminationCode.Location = new System.Drawing.Point(82, 6);
            this.textBoxExaminationCode.Name = "textBoxExaminationCode";
            this.textBoxExaminationCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxExaminationCode.TabIndex = 4;
            // 
            // textBoxExaminationName
            // 
            this.textBoxExaminationName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxExaminationName.Enabled = false;
            this.textBoxExaminationName.Location = new System.Drawing.Point(275, 6);
            this.textBoxExaminationName.Name = "textBoxExaminationName";
            this.textBoxExaminationName.Size = new System.Drawing.Size(100, 20);
            this.textBoxExaminationName.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(293, 305);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonServe
            // 
            this.buttonServe.Location = new System.Drawing.Point(58, 305);
            this.buttonServe.Name = "buttonServe";
            this.buttonServe.Size = new System.Drawing.Size(75, 23);
            this.buttonServe.TabIndex = 6;
            this.buttonServe.Text = "Wykonaj";
            this.buttonServe.UseVisualStyleBackColor = true;
            this.buttonServe.Click += new System.EventHandler(this.buttonServe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kod badania";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(180, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxDoctorComments
            // 
            this.textBoxDoctorComments.Enabled = false;
            this.textBoxDoctorComments.Location = new System.Drawing.Point(12, 187);
            this.textBoxDoctorComments.Multiline = true;
            this.textBoxDoctorComments.Name = "textBoxDoctorComments";
            this.textBoxDoctorComments.Size = new System.Drawing.Size(408, 92);
            this.textBoxDoctorComments.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Uwagi lekarza:";
            // 
            // Lab_technician_serve_examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDoctorComments);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonServe);
            this.Controls.Add(this.textBoxExaminationName);
            this.Controls.Add(this.textBoxExaminationCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExaminationResult);
            this.Name = "Lab_technician_serve_examination";
            this.Text = "Lab_technician_serve_examination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExaminationResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExaminationCode;
        private System.Windows.Forms.TextBox textBoxExaminationName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonServe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxDoctorComments;
        private System.Windows.Forms.Label label4;
    }
}