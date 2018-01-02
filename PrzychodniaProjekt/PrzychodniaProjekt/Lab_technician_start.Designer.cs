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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminations)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Location = new System.Drawing.Point(103, 11);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // dropdownChooseStatusStatus
            // 
            this.dropdownChooseStatusStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownChooseStatusStatus.FormattingEnabled = true;
            this.dropdownChooseStatusStatus.Items.AddRange(new object[] {
            "ZLEC",
            "WYK",
            "ZATW",
            "AN_L",
            "AN_K",
            ""});
            this.dropdownChooseStatusStatus.Location = new System.Drawing.Point(377, 11);
            this.dropdownChooseStatusStatus.Name = "dropdownChooseStatusStatus";
            this.dropdownChooseStatusStatus.Size = new System.Drawing.Size(93, 21);
            this.dropdownChooseStatusStatus.TabIndex = 1;
            // 
            // dataGridViewExaminations
            // 
            this.dataGridViewExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExaminations.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewExaminations.Name = "dataGridViewExaminations";
            this.dataGridViewExaminations.Size = new System.Drawing.Size(551, 290);
            this.dataGridViewExaminations.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(488, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonServe
            // 
            this.buttonServe.Location = new System.Drawing.Point(197, 335);
            this.buttonServe.Name = "buttonServe";
            this.buttonServe.Size = new System.Drawing.Size(75, 23);
            this.buttonServe.TabIndex = 4;
            this.buttonServe.Text = "Obsłuż";
            this.buttonServe.UseVisualStyleBackColor = true;
            this.buttonServe.Click += new System.EventHandler(this.buttonServe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data zlecenia:";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(300, 336);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Lab_technician_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 370);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox dropdownChooseStatusStatus;
        private System.Windows.Forms.DataGridView dataGridViewExaminations;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonServe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogOut;
    }
}