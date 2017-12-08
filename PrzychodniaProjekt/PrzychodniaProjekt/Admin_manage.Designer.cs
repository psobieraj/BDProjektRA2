namespace PrzychodniaProjekt
{
    partial class Admin_manage
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.dateTimePickerExpired = new System.Windows.Forms.DateTimePicker();
            this.przychodniaDataSet2 = new PrzychodniaProjekt.PrzychodniaDataSet2();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new PrzychodniaProjekt.PrzychodniaDataSet2TableAdapters.UserTableAdapter();
            this.checkBoxUserActive = new System.Windows.Forms.CheckBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(115, 41);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(84, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(115, 96);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(84, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "rec ",
            "doc ",
            "lab ",
            "klab"});
            this.comboBoxRole.Location = new System.Drawing.Point(115, 152);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRole.TabIndex = 2;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(89, 217);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Zatwierdź";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(184, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(31, 44);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Login:";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(31, 99);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(66, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Zmień hasło";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(31, 155);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(32, 13);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "Rola:";
            // 
            // dateTimePickerExpired
            // 
            this.dateTimePickerExpired.Enabled = false;
            this.dateTimePickerExpired.Location = new System.Drawing.Point(34, 179);
            this.dateTimePickerExpired.Name = "dateTimePickerExpired";
            this.dateTimePickerExpired.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerExpired.TabIndex = 8;
            // 
            // przychodniaDataSet2
            // 
            this.przychodniaDataSet2.DataSetName = "PrzychodniaDataSet2";
            this.przychodniaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.przychodniaDataSet2;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxUserActive
            // 
            this.checkBoxUserActive.AutoSize = true;
            this.checkBoxUserActive.Location = new System.Drawing.Point(240, 179);
            this.checkBoxUserActive.Name = "checkBoxUserActive";
            this.checkBoxUserActive.Size = new System.Drawing.Size(81, 17);
            this.checkBoxUserActive.TabIndex = 9;
            this.checkBoxUserActive.Text = "Niekatywny";
            this.checkBoxUserActive.UseVisualStyleBackColor = true;
            this.checkBoxUserActive.CheckedChanged += new System.EventHandler(this.checkBoxUserActive_CheckedChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(115, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id:";
            // 
            // Admin_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.checkBoxUserActive);
            this.Controls.Add(this.dateTimePickerExpired);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Admin_manage";
            this.Text = "Admin_manage";
            this.Load += new System.EventHandler(this.Admin_manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.przychodniaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpired;
        private PrzychodniaDataSet2 przychodniaDataSet2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private PrzychodniaDataSet2TableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxUserActive;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
    }
}