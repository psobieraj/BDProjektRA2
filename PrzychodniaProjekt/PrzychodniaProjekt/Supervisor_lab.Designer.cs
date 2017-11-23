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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagi_lek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wynik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagi_kier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_zl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_wyk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_zatw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonComments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lekarz,
            this.uwagi_lek,
            this.kod,
            this.status,
            this.wynik,
            this.laborant,
            this.uwagi_kier,
            this.data_zl,
            this.data_wyk,
            this.data_zatw});
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1047, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // lekarz
            // 
            this.lekarz.HeaderText = "Lekarz";
            this.lekarz.Name = "lekarz";
            // 
            // uwagi_lek
            // 
            this.uwagi_lek.HeaderText = "Uwagi lekarza";
            this.uwagi_lek.Name = "uwagi_lek";
            // 
            // kod
            // 
            this.kod.HeaderText = "Kod";
            this.kod.Name = "kod";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // wynik
            // 
            this.wynik.HeaderText = "Wynik";
            this.wynik.Name = "wynik";
            // 
            // laborant
            // 
            this.laborant.HeaderText = "Laborant";
            this.laborant.Name = "laborant";
            // 
            // uwagi_kier
            // 
            this.uwagi_kier.HeaderText = "Uwagi kier.";
            this.uwagi_kier.Name = "uwagi_kier";
            // 
            // data_zl
            // 
            this.data_zl.HeaderText = "Data zlecenia";
            this.data_zl.Name = "data_zl";
            // 
            // data_wyk
            // 
            this.data_wyk.HeaderText = "Data wykonania";
            this.data_wyk.Name = "data_wyk";
            // 
            // data_zatw
            // 
            this.data_zatw.HeaderText = "Data zatw.";
            this.data_zatw.Name = "data_zatw";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(12, 306);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(127, 23);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "Zatwierdź badanie";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(177, 306);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Anuluj badanie";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonComments
            // 
            this.buttonComments.Location = new System.Drawing.Point(12, 349);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(75, 23);
            this.buttonComments.TabIndex = 3;
            this.buttonComments.Text = "Uwagi";
            this.buttonComments.UseVisualStyleBackColor = true;
            // 
            // Supervisor_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 421);
            this.Controls.Add(this.buttonComments);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Supervisor_lab";
            this.Text = "Supervisor_lab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lekarz;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagi_lek;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn wynik;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborant;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagi_kier;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_zl;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_wyk;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_zatw;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonComments;
    }
}