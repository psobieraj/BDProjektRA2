namespace PrzychodniaProjekt
{
    partial class Doctor_main
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
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.dateTimeRegistration = new System.Windows.Forms.DateTimePicker();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data_rej:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.AllowDrop = true;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "REJ",
            "ANUL",
            "ZAK",
            ""});
            this.comboBoxState.Location = new System.Drawing.Point(564, 47);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(86, 21);
            this.comboBoxState.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Status:";
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Location = new System.Drawing.Point(38, 134);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.Size = new System.Drawing.Size(625, 184);
            this.dataGridViewVisits.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lista wizyt:";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(685, 345);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(95, 29);
            this.buttonChoose.TabIndex = 22;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(685, 73);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 29);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "nazwisko";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(104, 48);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 27;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char_Press);
            // 
            // dateTimeRegistration
            // 
            this.dateTimeRegistration.Location = new System.Drawing.Point(312, 50);
            this.dateTimeRegistration.Name = "dateTimeRegistration";
            this.dateTimeRegistration.ShowCheckBox = true;
            this.dateTimeRegistration.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRegistration.TabIndex = 28;
            this.dateTimeRegistration.Value = new System.DateTime(2017, 12, 15, 11, 5, 0, 0);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(705, 134);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 29;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Doctor_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 476);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.dateTimeRegistration);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewVisits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.label1);
            this.Name = "Doctor_main";
            this.Text = "Doctor_main";
            this.Load += new System.EventHandler(this.Doctor_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DateTimePicker dateTimeRegistration;
        private System.Windows.Forms.Button buttonLogOut;
    }
}