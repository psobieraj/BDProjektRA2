namespace PrzychodniaProjekt
{
    partial class Doctor_examination_phisical
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
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textKod = new System.Windows.Forms.TextBox();
            this.textNazwa = new System.Windows.Forms.TextBox();
            this.btnSelectKod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(33, 131);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(214, 92);
            this.textBoxComments.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Wynik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Wróc";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textKod
            // 
            this.textKod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textKod.Enabled = false;
            this.textKod.Location = new System.Drawing.Point(33, 24);
            this.textKod.Name = "textKod";
            this.textKod.Size = new System.Drawing.Size(100, 20);
            this.textKod.TabIndex = 28;
            // 
            // textNazwa
            // 
            this.textNazwa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textNazwa.Location = new System.Drawing.Point(33, 51);
            this.textNazwa.Name = "textNazwa";
            this.textNazwa.Size = new System.Drawing.Size(442, 20);
            this.textNazwa.TabIndex = 29;
            // 
            // btnSelectKod
            // 
            this.btnSelectKod.Location = new System.Drawing.Point(139, 24);
            this.btnSelectKod.Name = "btnSelectKod";
            this.btnSelectKod.Size = new System.Drawing.Size(75, 23);
            this.btnSelectKod.TabIndex = 30;
            this.btnSelectKod.Text = "...";
            this.btnSelectKod.UseVisualStyleBackColor = true;
            this.btnSelectKod.Click += new System.EventHandler(this.btnSelectKod_Click);
            // 
            // Doctor_examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 472);
            this.Controls.Add(this.btnSelectKod);
            this.Controls.Add(this.textNazwa);
            this.Controls.Add(this.textKod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxComments);
            this.Name = "Doctor_examination";
            this.Text = "Doctor_examination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textKod;
        private System.Windows.Forms.TextBox textNazwa;
        private System.Windows.Forms.Button btnSelectKod;
    }
}