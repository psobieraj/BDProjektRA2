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
            this.textBoxExaminationRes = new System.Windows.Forms.TextBox();
            this.textBoxExaminationCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDoctorComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExaminationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirmExam
            // 
            this.buttonConfirmExam.Location = new System.Drawing.Point(43, 430);
            this.buttonConfirmExam.Name = "buttonConfirmExam";
            this.buttonConfirmExam.Size = new System.Drawing.Size(108, 23);
            this.buttonConfirmExam.TabIndex = 0;
            this.buttonConfirmExam.Text = "Zatwierdź badanie";
            this.buttonConfirmExam.UseVisualStyleBackColor = true;
            this.buttonConfirmExam.Click += new System.EventHandler(this.buttonConfirmExam_Click);
            // 
            // buttonCancelExam
            // 
            this.buttonCancelExam.Location = new System.Drawing.Point(184, 429);
            this.buttonCancelExam.Name = "buttonCancelExam";
            this.buttonCancelExam.Size = new System.Drawing.Size(109, 23);
            this.buttonCancelExam.TabIndex = 1;
            this.buttonCancelExam.Text = "Anuluj badanie";
            this.buttonCancelExam.UseVisualStyleBackColor = true;
            this.buttonCancelExam.Click += new System.EventHandler(this.buttonCancelExam_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(330, 429);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxExaminationRes
            // 
            this.textBoxExaminationRes.Location = new System.Drawing.Point(42, 106);
            this.textBoxExaminationRes.Multiline = true;
            this.textBoxExaminationRes.Name = "textBoxExaminationRes";
            this.textBoxExaminationRes.ReadOnly = true;
            this.textBoxExaminationRes.Size = new System.Drawing.Size(340, 39);
            this.textBoxExaminationRes.TabIndex = 3;
            // 
            // textBoxExaminationCode
            // 
            this.textBoxExaminationCode.Location = new System.Drawing.Point(111, 31);
            this.textBoxExaminationCode.Name = "textBoxExaminationCode";
            this.textBoxExaminationCode.ReadOnly = true;
            this.textBoxExaminationCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxExaminationCode.TabIndex = 4;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(39, 34);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(29, 13);
            this.labelCode.TabIndex = 5;
            this.labelCode.Text = "Kod:";
            this.labelCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wynik:";
            // 
            // textBoxDoctorComments
            // 
            this.textBoxDoctorComments.Location = new System.Drawing.Point(42, 182);
            this.textBoxDoctorComments.Multiline = true;
            this.textBoxDoctorComments.Name = "textBoxDoctorComments";
            this.textBoxDoctorComments.ReadOnly = true;
            this.textBoxDoctorComments.Size = new System.Drawing.Size(340, 42);
            this.textBoxDoctorComments.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Uwagi lekarza:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(43, 353);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(339, 45);
            this.textBoxNotes.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Twoje uwagi";
            // 
            // textBoxExaminationName
            // 
            this.textBoxExaminationName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxExaminationName.Location = new System.Drawing.Point(314, 31);
            this.textBoxExaminationName.Name = "textBoxExaminationName";
            this.textBoxExaminationName.Size = new System.Drawing.Size(100, 20);
            this.textBoxExaminationName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nazwa badania";
            // 
            // Supervisor_lab_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 478);
            this.Controls.Add(this.textBoxExaminationName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDoctorComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxExaminationCode);
            this.Controls.Add(this.textBoxExaminationRes);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCancelExam);
            this.Controls.Add(this.buttonConfirmExam);
            this.Name = "Supervisor_lab_manage";
            this.Text = "Supervisor_lab_manage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmExam;
        private System.Windows.Forms.Button buttonCancelExam;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxExaminationRes;
        private System.Windows.Forms.TextBox textBoxExaminationCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDoctorComments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxExaminationName;
        private System.Windows.Forms.Label label3;
    }
}