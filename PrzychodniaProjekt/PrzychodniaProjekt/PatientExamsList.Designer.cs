namespace PrzychodniaProjekt
{
    partial class Form1
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
            this.dataGridViewExams = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNextExam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExams)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExams
            // 
            this.dataGridViewExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExams.Location = new System.Drawing.Point(95, 46);
            this.dataGridViewExams.Name = "dataGridViewExams";
            this.dataGridViewExams.Size = new System.Drawing.Size(605, 184);
            this.dataGridViewExams.TabIndex = 21;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(233, 259);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNextExam
            // 
            this.buttonNextExam.Location = new System.Drawing.Point(368, 259);
            this.buttonNextExam.Name = "buttonNextExam";
            this.buttonNextExam.Size = new System.Drawing.Size(229, 23);
            this.buttonNextExam.TabIndex = 24;
            this.buttonNextExam.Text = "Wykonaj następne badanie";
            this.buttonNextExam.UseVisualStyleBackColor = true;
            this.buttonNextExam.Click += new System.EventHandler(this.buttonNextExam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Wykonane Badania";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNextExam);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewExams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExams;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNextExam;
        private System.Windows.Forms.Label label1;
    }
}