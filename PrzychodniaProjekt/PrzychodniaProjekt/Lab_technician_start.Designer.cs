namespace PrzychodniaProjekt
{
    partial class Lab_technician_start
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dropdownChooseStatusStatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewExaminations = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonServe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminations)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // dropdownChooseStatusStatus
            // 
            this.dropdownChooseStatusStatus.FormattingEnabled = true;
            this.dropdownChooseStatusStatus.Location = new System.Drawing.Point(218, 12);
            this.dropdownChooseStatusStatus.Name = "dropdownChooseStatusStatus";
            this.dropdownChooseStatusStatus.Size = new System.Drawing.Size(121, 21);
            this.dropdownChooseStatusStatus.TabIndex = 1;
            // 
            // dataGridViewExaminations
            // 
            this.dataGridViewExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExaminations.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewExaminations.Name = "dataGridViewExaminations";
            this.dataGridViewExaminations.Size = new System.Drawing.Size(408, 163);
            this.dataGridViewExaminations.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(345, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonServe
            // 
            this.buttonServe.Location = new System.Drawing.Point(183, 208);
            this.buttonServe.Name = "buttonServe";
            this.buttonServe.Size = new System.Drawing.Size(75, 23);
            this.buttonServe.TabIndex = 4;
            this.buttonServe.Text = "Obsłuż";
            this.buttonServe.UseVisualStyleBackColor = true;
            // 
            // Lab_technician_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 244);
            this.Controls.Add(this.buttonServe);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewExaminations);
            this.Controls.Add(this.dropdownChooseStatusStatus);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Lab_technician_start";
            this.Text = "Lab_technician_start";
            this.Load += new System.EventHandler(this.Lab_technician_start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox dropdownChooseStatusStatus;
        private System.Windows.Forms.DataGridView dataGridViewExaminations;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonServe;
    }
}