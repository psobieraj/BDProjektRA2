﻿namespace PrzychodniaProjekt
{
    partial class Registry_AddEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textPesel = new System.Windows.Forms.TextBox();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.textHouse = new System.Windows.Forms.TextBox();
            this.textApartment = new System.Windows.Forms.TextBox();
            this.textIDpat = new System.Windows.Forms.TextBox();
            this.textIDadr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imię";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Miejscowość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ulica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nr lokalu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nr domu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Pesel";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(158, 168);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 39);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(311, 168);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(110, 39);
            this.buttonModify.TabIndex = 14;
            this.buttonModify.Text = "Zatwierdź zmiany";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(455, 168);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(110, 39);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "Wróć";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(143, 47);
            this.textName.MaxLength = 40;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(103, 20);
            this.textName.TabIndex = 16;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char_Press);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(325, 47);
            this.textSurname.MaxLength = 40;
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(103, 20);
            this.textSurname.TabIndex = 17;
            this.textSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char_Press);
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(143, 101);
            this.textCity.MaxLength = 40;
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(103, 20);
            this.textCity.TabIndex = 18;
            this.textCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char_Press);
            // 
            // textPesel
            // 
            this.textPesel.Location = new System.Drawing.Point(491, 47);
            this.textPesel.MaxLength = 11;
            this.textPesel.Name = "textPesel";
            this.textPesel.Size = new System.Drawing.Size(103, 20);
            this.textPesel.TabIndex = 19;
            this.textPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number_Press);
            // 
            // textStreet
            // 
            this.textStreet.Location = new System.Drawing.Point(314, 104);
            this.textStreet.MaxLength = 40;
            this.textStreet.Name = "textStreet";
            this.textStreet.Size = new System.Drawing.Size(103, 20);
            this.textStreet.TabIndex = 21;
            this.textStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char_Press);
            // 
            // textHouse
            // 
            this.textHouse.Location = new System.Drawing.Point(491, 104);
            this.textHouse.MaxLength = 40;
            this.textHouse.Name = "textHouse";
            this.textHouse.Size = new System.Drawing.Size(30, 20);
            this.textHouse.TabIndex = 24;
            this.textHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number_Letter_Press);
            // 
            // textApartment
            // 
            this.textApartment.Location = new System.Drawing.Point(593, 104);
            this.textApartment.MaxLength = 40;
            this.textApartment.Name = "textApartment";
            this.textApartment.Size = new System.Drawing.Size(30, 20);
            this.textApartment.TabIndex = 25;
            this.textApartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number_Press);
            // 
            // textIDpat
            // 
            this.textIDpat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textIDpat.Enabled = false;
            this.textIDpat.ForeColor = System.Drawing.SystemColors.Window;
            this.textIDpat.Location = new System.Drawing.Point(216, 12);
            this.textIDpat.Name = "textIDpat";
            this.textIDpat.Size = new System.Drawing.Size(30, 20);
            this.textIDpat.TabIndex = 26;
            // 
            // textIDadr
            // 
            this.textIDadr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textIDadr.Enabled = false;
            this.textIDadr.Location = new System.Drawing.Point(379, 12);
            this.textIDadr.Name = "textIDadr";
            this.textIDadr.Size = new System.Drawing.Size(30, 20);
            this.textIDadr.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Id pacjenta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Id adresu";
            // 
            // Registry_AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 247);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textIDadr);
            this.Controls.Add(this.textIDpat);
            this.Controls.Add(this.textApartment);
            this.Controls.Add(this.textHouse);
            this.Controls.Add(this.textStreet);
            this.Controls.Add(this.textPesel);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Registry_AddEdit";
            this.Text = "Registry_AddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textPesel;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.TextBox textHouse;
        private System.Windows.Forms.TextBox textApartment;
        private System.Windows.Forms.TextBox textIDpat;
        private System.Windows.Forms.TextBox textIDadr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}