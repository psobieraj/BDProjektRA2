namespace PrzychodniaProjekt
{
    partial class Registry_main
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przychodniaDataSet = new PrzychodniaProjekt.PrzychodniaDataSet();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPesel = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.patientTableAdapter = new PrzychodniaProjekt.PrzychodniaDataSetTableAdapters.PatientTableAdapter();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.btnShowVisits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(57, 94);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.Size = new System.Drawing.Size(625, 184);
            this.dgvPatients.TabIndex = 0;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.przychodniaDataSet;
            // 
            // przychodniaDataSet
            // 
            this.przychodniaDataSet.DataSetName = "PrzychodniaDataSet";
            this.przychodniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvVisits
            // 
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Location = new System.Drawing.Point(57, 340);
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.Size = new System.Drawing.Size(625, 184);
            this.dgvVisits.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista pacjentów:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista wizyt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Imię:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pesel:";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(116, 43);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(159, 20);
            this.textSurname.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(316, 43);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(159, 20);
            this.textName.TabIndex = 8;
            // 
            // textPesel
            // 
            this.textPesel.Location = new System.Drawing.Point(523, 43);
            this.textPesel.Name = "textPesel";
            this.textPesel.Size = new System.Drawing.Size(159, 20);
            this.textPesel.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(717, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(93, 20);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Szukaj pacjenta";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(717, 146);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(93, 20);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "Rejestruj";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(717, 340);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 20);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Anuluj wizytę";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(717, 94);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 20);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Dodaj pacjenta";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(717, 120);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(93, 20);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edytuj pacjenta";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // btnShowVisits
            // 
            this.btnShowVisits.Location = new System.Drawing.Point(316, 299);
            this.btnShowVisits.Name = "btnShowVisits";
            this.btnShowVisits.Size = new System.Drawing.Size(142, 20);
            this.btnShowVisits.TabIndex = 16;
            this.btnShowVisits.Text = "Pokaż pacjentów/wizyty";
            this.btnShowVisits.UseVisualStyleBackColor = true;
            this.btnShowVisits.Click += new System.EventHandler(this.btnShowVisits_Click);
            // 
            // Registry_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 570);
            this.Controls.Add(this.btnShowVisits);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textPesel);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVisits);
            this.Controls.Add(this.dgvPatients);
            this.Name = "Registry_main";
            this.Text = "Registry_main";
            this.Load += new System.EventHandler(this.Registry_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPesel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private PrzychodniaDataSet przychodniaDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private PrzychodniaDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button btnShowVisits;
    }
}