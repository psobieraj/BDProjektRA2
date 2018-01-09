namespace PrzychodniaProjekt
{
    partial class Doctor_examination_laboratory
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
            this.btnSelectCode = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExecuteOrOrder = new System.Windows.Forms.Button();
            this.labelResultsOrComments = new System.Windows.Forms.Label();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectCode
            // 
            this.btnSelectCode.Location = new System.Drawing.Point(139, 24);
            this.btnSelectCode.Name = "btnSelectCode";
            this.btnSelectCode.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCode.TabIndex = 37;
            this.btnSelectCode.Text = "...";
            this.btnSelectCode.UseVisualStyleBackColor = true;
            this.btnSelectCode.Click += new System.EventHandler(this.btnSelectCode_Click);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(33, 51);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(442, 20);
            this.textName.TabIndex = 36;
            // 
            // textCode
            // 
            this.textCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textCode.Enabled = false;
            this.textCode.Location = new System.Drawing.Point(33, 24);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(100, 20);
            this.textCode.TabIndex = 35;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(265, 229);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(95, 24);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Wróc";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExecuteOrOrder
            // 
            this.buttonExecuteOrOrder.Location = new System.Drawing.Point(139, 229);
            this.buttonExecuteOrOrder.Name = "buttonExecuteOrOrder";
            this.buttonExecuteOrOrder.Size = new System.Drawing.Size(95, 24);
            this.buttonExecuteOrOrder.TabIndex = 33;
            this.buttonExecuteOrOrder.Text = "Zleć";
            this.buttonExecuteOrOrder.UseVisualStyleBackColor = true;
            this.buttonExecuteOrOrder.Click += new System.EventHandler(this.buttonExecuteOrOrder_Click);
            // 
            // labelResultsOrComments
            // 
            this.labelResultsOrComments.AutoSize = true;
            this.labelResultsOrComments.Location = new System.Drawing.Point(30, 104);
            this.labelResultsOrComments.Name = "labelResultsOrComments";
            this.labelResultsOrComments.Size = new System.Drawing.Size(74, 13);
            this.labelResultsOrComments.TabIndex = 32;
            this.labelResultsOrComments.Text = "Uwagi lekarza";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(33, 131);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(442, 92);
            this.textBoxComments.TabIndex = 31;
            // 
            // Doctor_examination_laboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 311);
            this.Controls.Add(this.btnSelectCode);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExecuteOrOrder);
            this.Controls.Add(this.labelResultsOrComments);
            this.Controls.Add(this.textBoxComments);
            this.Name = "Doctor_examination_laboratory";
            this.Text = "Doctor_examination_laboratory";
            this.Load += new System.EventHandler(this.Doctor_examination_laboratory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectCode;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExecuteOrOrder;
        private System.Windows.Forms.Label labelResultsOrComments;
        private System.Windows.Forms.TextBox textBoxComments;
    }
}