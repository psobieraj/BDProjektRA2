namespace PrzychodniaProjekt
{
    partial class Registry_cancel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dtpCancel = new System.Windows.Forms.DateTimePicker();
            this.textIdVisit = new System.Windows.Forms.TextBox();
            this.textIdPatient = new System.Windows.Forms.TextBox();
            this.textPatName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPESEL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wizyta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data anulowania";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(134, 133);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(95, 29);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Zatwierdź";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(256, 133);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(95, 29);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // dtpCancel
            // 
            this.dtpCancel.Location = new System.Drawing.Point(136, 74);
            this.dtpCancel.Name = "dtpCancel";
            this.dtpCancel.Size = new System.Drawing.Size(215, 20);
            this.dtpCancel.TabIndex = 6;
            // 
            // textIdVisit
            // 
            this.textIdVisit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textIdVisit.Enabled = false;
            this.textIdVisit.Location = new System.Drawing.Point(134, 42);
            this.textIdVisit.Name = "textIdVisit";
            this.textIdVisit.Size = new System.Drawing.Size(35, 20);
            this.textIdVisit.TabIndex = 2;
            // 
            // textIdPatient
            // 
            this.textIdPatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textIdPatient.Enabled = false;
            this.textIdPatient.Location = new System.Drawing.Point(273, 42);
            this.textIdPatient.Name = "textIdPatient";
            this.textIdPatient.Size = new System.Drawing.Size(35, 20);
            this.textIdPatient.TabIndex = 7;
            // 
            // textPatName
            // 
            this.textPatName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textPatName.Enabled = false;
            this.textPatName.Location = new System.Drawing.Point(396, 42);
            this.textPatName.Name = "textPatName";
            this.textPatName.Size = new System.Drawing.Size(102, 20);
            this.textPatName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pacjent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwisko";
            // 
            // textPESEL
            // 
            this.textPESEL.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textPESEL.Enabled = false;
            this.textPESEL.Location = new System.Drawing.Point(396, 16);
            this.textPESEL.Name = "textPESEL";
            this.textPESEL.Size = new System.Drawing.Size(102, 20);
            this.textPESEL.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pesel";
            // 
            // Registry_cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPESEL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPatName);
            this.Controls.Add(this.textIdPatient);
            this.Controls.Add(this.dtpCancel);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textIdVisit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registry_cancel";
            this.Text = "Registry_cancel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DateTimePicker dtpCancel;
        private System.Windows.Forms.TextBox textIdVisit;
        private System.Windows.Forms.TextBox textIdPatient;
        private System.Windows.Forms.TextBox textPatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPESEL;
        private System.Windows.Forms.Label label5;
    }
}