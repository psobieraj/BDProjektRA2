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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelListOfExams = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.textLab = new System.Windows.Forms.TextBox();
            this.labelLab = new System.Windows.Forms.Label();
            this.textMD = new System.Windows.Forms.TextBox();
            this.labelMD = new System.Windows.Forms.Label();
            this.przychodniaDataSet3 = new PrzychodniaProjekt.PrzychodniaDataSet3();
            this.przychodniaDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            buttonShowExams = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowExams
            // 
            buttonShowExams.Location = new System.Drawing.Point(714, 41);
            buttonShowExams.Name = "buttonShowExams";
            buttonShowExams.Size = new System.Drawing.Size(127, 23);
            buttonShowExams.TabIndex = 5;
            buttonShowExams.Text = "Wyświetl badania";
            buttonShowExams.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.przychodniaDataSet3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(714, 105);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(127, 23);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Zatwierdź badanie";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(714, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Anuluj badanie";
            this.buttonCancel.UseVisualStyleBackColor = true;
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
            this.comboBoxState.Location = new System.Drawing.Point(610, 41);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(86, 21);
            this.comboBoxState.TabIndex = 6;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(564, 46);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(40, 13);
            this.labelState.TabIndex = 7;
            this.labelState.Text = "Status:";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(470, 41);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(70, 20);
            this.textCode.TabIndex = 8;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(394, 46);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(70, 13);
            this.labelCode.TabIndex = 9;
            this.labelCode.Text = "Kod badania:";
            // 
            // textLab
            // 
            this.textLab.Location = new System.Drawing.Point(250, 42);
            this.textLab.Name = "textLab";
            this.textLab.Size = new System.Drawing.Size(100, 20);
            this.textLab.TabIndex = 10;
            // 
            // labelLab
            // 
            this.labelLab.AutoSize = true;
            this.labelLab.Location = new System.Drawing.Point(192, 46);
            this.labelLab.Name = "labelLab";
            this.labelLab.Size = new System.Drawing.Size(52, 13);
            this.labelLab.TabIndex = 11;
            this.labelLab.Text = "Laborant:";
            // 
            // textMD
            // 
            this.textMD.Location = new System.Drawing.Point(57, 41);
            this.textMD.Name = "textMD";
            this.textMD.Size = new System.Drawing.Size(90, 20);
            this.textMD.TabIndex = 12;
            // 
            // labelMD
            // 
            this.labelMD.AutoSize = true;
            this.labelMD.Location = new System.Drawing.Point(12, 45);
            this.labelMD.Name = "labelMD";
            this.labelMD.Size = new System.Drawing.Size(39, 13);
            this.labelMD.TabIndex = 13;
            this.labelMD.Text = "Lekarz";
            // 
            // przychodniaDataSet3
            // 
            this.przychodniaDataSet3.DataSetName = "PrzychodniaDataSet3";
            this.przychodniaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przychodniaDataSet3BindingSource
            // 
            this.przychodniaDataSet3BindingSource.DataSource = this.przychodniaDataSet3;
            this.przychodniaDataSet3BindingSource.Position = 0;
            // 
            // Supervisor_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 445);
            this.Controls.Add(this.labelMD);
            this.Controls.Add(this.textMD);
            this.Controls.Add(this.labelLab);
            this.Controls.Add(this.textLab);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(buttonShowExams);
            this.Controls.Add(this.labelListOfExams);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Supervisor_lab";
            this.Text = "Supervisor_lab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelListOfExams;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textLab;
        private System.Windows.Forms.Label labelLab;
        private System.Windows.Forms.TextBox textMD;
        private System.Windows.Forms.Label labelMD;
        private System.Windows.Forms.BindingSource przychodniaDataSet3BindingSource;
        private PrzychodniaDataSet3 przychodniaDataSet3;
    }
}