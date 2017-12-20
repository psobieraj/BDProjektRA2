using System;
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
    public partial class Doctor_examination_psychical : Form
    {
        public Doctor_examination_psychical()
        {
            InitializeComponent();
        }

        private void btnSelectKod_Click(object sender, EventArgs e)
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
            Bizz_Doctor.AddExam(textBoxComments.Text, Doctor_visit.id_wiz, textCode.Text);
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
