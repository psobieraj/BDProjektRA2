namespace PrzychodniaProjekt
{
    partial class Doctor_examination_psychical
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
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.labelResultsOrComments = new System.Windows.Forms.Label();
            this.buttonExecuteOrOrder = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnSelectCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(33, 131);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(214, 92);
            this.textBoxComments.TabIndex = 21;
            // 
            // labelResultsOrComments
            // 
            this.labelResultsOrComments.AutoSize = true;
            this.labelResultsOrComments.Location = new System.Drawing.Point(30, 104);
            this.labelResultsOrComments.Name = "labelResultsOrComments";
            this.labelResultsOrComments.Size = new System.Drawing.Size(37, 13);
            this.labelResultsOrComments.TabIndex = 23;
            this.labelResultsOrComments.Text = "Wynik";
            // 
            // buttonExecuteOrOrder
            // 
            this.buttonExecuteOrOrder.Location = new System.Drawing.Point(157, 261);
            this.buttonExecuteOrOrder.Name = "buttonExecuteOrOrder";
            this.buttonExecuteOrOrder.Size = new System.Drawing.Size(95, 29);
            this.buttonExecuteOrOrder.TabIndex = 25;
            this.buttonExecuteOrOrder.Text = "Wykonaj";
            this.buttonExecuteOrOrder.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(38, 261);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(95, 29);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.Text = "Wróc";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // textCode
            // 
            this.textCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textCode.Enabled = false;
            this.textCode.Location = new System.Drawing.Point(33, 24);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(100, 20);
            this.textCode.TabIndex = 28;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textName.Location = new System.Drawing.Point(33, 51);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(442, 20);
            this.textName.TabIndex = 29;
            // 
            // btnSelectCode
            // 
            this.btnSelectCode.Location = new System.Drawing.Point(139, 24);
            this.btnSelectCode.Name = "btnSelectCode";
            this.btnSelectCode.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCode.TabIndex = 30;
            this.btnSelectCode.Text = "...";
            this.btnSelectCode.UseVisualStyleBackColor = true;
            this.btnSelectCode.Click += new System.EventHandler(this.btnSelectKod_Click);
            // 
            // Doctor_examination_psychical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 472);
            this.Controls.Add(this.btnSelectCode);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExecuteOrOrder);
            this.Controls.Add(this.labelResultsOrComments);
            this.Controls.Add(this.textBoxComments);
            this.Name = "Doctor_examination_psychical";
            this.Text = "Doctor_examination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.Label labelResultsOrComments;
        private System.Windows.Forms.Button buttonExecuteOrOrder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnSelectCode;
    }
}