namespace PrzychodniaProjekt
{
    partial class Registry_register
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
            this.textDoctor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet1 = new PrzychodniaProjekt.PrzychodniaDataSet1();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.doctorTableAdapter = new PrzychodniaProjekt.PrzychodniaDataSet1TableAdapters.DoctorTableAdapter();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPesel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.textIDdoctor = new System.Windows.Forms.TextBox();
            this.textIDpatient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textDoctor
            // 
            this.textDoctor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textDoctor.Enabled = false;
            this.textDoctor.Location = new System.Drawing.Point(126, 85);
            this.textDoctor.Name = "textDoctor";
            this.textDoctor.Size = new System.Drawing.Size(125, 20);
            this.textDoctor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lekarz";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(93, 136);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(92, 28);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Zatwierdź";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(208, 136);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(92, 28);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Location = new System.Drawing.Point(365, 53);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.Size = new System.Drawing.Size(445, 111);
            this.dgvDoctors.TabIndex = 6;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.przychodniaDataSet1;
            // 
            // przychodniaDataSet1
            // 
            this.przychodniaDataSet1.DataSetName = "PrzychodniaDataSet1";
            this.przychodniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(93, 56);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // textSurname
            // 
            this.textSurname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textSurname.Enabled = false;
            this.textSurname.Location = new System.Drawing.Point(93, 12);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(125, 20);
            this.textSurname.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(308, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(125, 20);
            this.textName.TabIndex = 9;
            // 
            // textPesel
            // 
            this.textPesel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textPesel.Enabled = false;
            this.textPesel.Location = new System.Drawing.Point(520, 12);
            this.textPesel.Name = "textPesel";
            this.textPesel.Size = new System.Drawing.Size(125, 20);
            this.textPesel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Imię";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pesel";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(532, 170);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(92, 28);
            this.btnChoose.TabIndex = 14;
            this.btnChoose.Text = "Wybierz lekarza";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // textIDdoctor
            // 
            this.textIDdoctor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textIDdoctor.Enabled = false;
            this.textIDdoctor.Location = new System.Drawing.Point(93, 85);
            this.textIDdoctor.Name = "textIDdoctor";
            this.textIDdoctor.Size = new System.Drawing.Size(27, 20);
            this.textIDdoctor.TabIndex = 15;
            // 
            // textIDpatient
            // 
            this.textIDpatient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textIDpatient.Enabled = false;
            this.textIDpatient.Location = new System.Drawing.Point(696, 12);
            this.textIDpatient.Name = "textIDpatient";
            this.textIDpatient.Size = new System.Drawing.Size(38, 20);
            this.textIDpatient.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Registry_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 230);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textIDpatient);
            this.Controls.Add(this.textIDdoctor);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPesel);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvDoctors);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDoctor);
            this.Name = "Registry_register";
            this.Text = "Registry_register";
            this.Load += new System.EventHandler(this.Registry_register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private PrzychodniaDataSet1 przychodniaDataSet1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PrzychodniaDataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPesel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox textIDdoctor;
        private System.Windows.Forms.TextBox textIDpatient;
        private System.Windows.Forms.Label label6;
    }
}