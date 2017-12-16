namespace PrzychodniaProjekt
{
    partial class Exam_dictionary
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
            this.dataGridViewExamDictionaryList = new System.Windows.Forms.DataGridView();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamDictionaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExamDictionaryList
            // 
            this.dataGridViewExamDictionaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamDictionaryList.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewExamDictionaryList.Name = "dataGridViewExamDictionaryList";
            this.dataGridViewExamDictionaryList.Size = new System.Drawing.Size(341, 150);
            this.dataGridViewExamDictionaryList.TabIndex = 0;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(40, 193);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(249, 192);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Wróć";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // Exam_dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 347);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.dataGridViewExamDictionaryList);
            this.Name = "Exam_dictionary";
            this.Text = "Exam_dictionary";
            this.Load += new System.EventHandler(this.Exam_dictionary_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamDictionaryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExamDictionaryList;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonBack;
    }
}