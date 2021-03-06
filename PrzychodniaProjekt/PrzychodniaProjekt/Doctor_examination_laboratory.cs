﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer;

namespace PrzychodniaProjekt
{
    public partial class Doctor_examination_laboratory : Form
    {
        public Doctor_examination_laboratory()
        {
            InitializeComponent();
        }

        private void btnSelectCode_Click(object sender, EventArgs e)
        {
            Exam_dictionary exam_dictionary = new Exam_dictionary();
            exam_dictionary.ShowDialog();
        }

        public void fillForms(string code, string name)
        {
            textCode.Text = code;
            textName.Text = name;
        }

        private void buttonExecuteOrOrder_Click(object sender, EventArgs e)
        {
            Bizz_Doctor.AddLabExam(textBoxComments.Text, Doctor_visit.id_wiz, textCode.Text);

            PatientLabExamList obj = (PatientLabExamList)Application.OpenForms["PatientLabExamList"];

            obj.refreshLab();

            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Doctor_examination_laboratory_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
