namespace PrzychodniaProjekt
{
    partial class Supervisor_lab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button buttonShowExams;
            this.przychodniaDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet3 = new PrzychodniaProjekt.PrzychodniaDataSet3();
            this.labelListOfExams = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonManage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDone = new System.Windows.Forms.DateTimePicker();
            this.dgvExaminations = new System.Windows.Forms.DataGridView();
            this.buttonLogOut = new System.Windows.Forms.Button();
            buttonShowExams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowExams
            // 
            buttonShowExams.Location = new System.Drawing.Point(603, 42);
            buttonShowExams.Name = "buttonShowExams";
            buttonShowExams.Size = new System.Drawing.Size(109, 23);
            buttonShowExams.TabIndex = 5;
            buttonShowExams.Text = "Wyświetl badania";
            buttonShowExams.UseVisualStyleBackColor = true;
            buttonShowExams.Click += new System.EventHandler(this.buttonShowExams_Click);
            // 
            // przychodniaDataSet3BindingSource
            // 
            this.przychodniaDataSet3BindingSource.DataSource = this.przychodniaDataSet3;
            this.przychodniaDataSet3BindingSource.Position = 0;
            // 
            // przychodniaDataSet3
            // 
            this.przychodniaDataSet3.DataSetName = "PrzychodniaDataSet3";
            this.przychodniaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelListOfExams
            // 
            this.labelListOfExams.AutoSize = true;
            this.labelListOfExams.Location = new System.Drawing.Point(9, 88);
            this.labelListOfExams.Name = "labelListOfExams";
            this.labelListOfExams.Size = new System.Drawing.Size(65, 13);
            this.labelListOfExams.TabIndex = 4;
            this.labelListOfExams.Text = "Lista badań:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "WYK",
            ""});
            this.comboBoxState.Location = new System.Drawing.Point(499, 42);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(86, 21);
            this.comboBoxState.TabIndex = 6;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(453, 47);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(40, 13);
            this.labelState.TabIndex = 7;
            this.labelState.Text = "Status:";
            // 
            // buttonManage
            // 
            this.buttonManage.Location = new System.Drawing.Point(603, 105);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(109, 24);
            this.buttonManage.TabIndex = 14;
            this.buttonManage.Text = "Obsłuż";
            this.buttonManage.UseVisualStyleBackColor = true;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data wykonania:";
            // 
            // dtpDone
            // 
            this.dtpDone.Checked = false;
            this.dtpDone.Location = new System.Drawing.Point(213, 43);
            this.dtpDone.Name = "dtpDone";
            this.dtpDone.ShowCheckBox = true;
            this.dtpDone.Size = new System.Drawing.Size(200, 20);
            this.dtpDone.TabIndex = 15;
            // 
            // dgvExaminations
            // 
            this.dgvExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExaminations.Location = new System.Drawing.Point(12, 104);
            this.dgvExaminations.Name = "dgvExaminations";
            this.dgvExaminations.Size = new System.Drawing.Size(578, 318);
            this.dgvExaminations.TabIndex = 17;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(621, 145);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 18;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Supervisor_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 445);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.dgvExaminations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDone);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(buttonShowExams);
            this.Controls.Add(this.labelListOfExams);
            this.Name = "Supervisor_lab";
            this.Text = "Supervisor_lab";
            this.Load += new System.EventHandler(this.Supervisor_lab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExaminations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListOfExams;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.BindingSource przychodniaDataSet3BindingSource;
        private PrzychodniaDataSet3 przychodniaDataSet3;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDone;
        private System.Windows.Forms.DataGridView dgvExaminations;
        private System.Windows.Forms.Button buttonLogOut;
    }
}