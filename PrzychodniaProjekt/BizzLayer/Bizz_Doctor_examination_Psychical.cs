using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BizzLayer
{
    public class Bizz_Doctor_examination_Psychical
    {
        public static void AddExam(string wynik, int id_wiz, string kod)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            Physical_exam ex = new Physical_exam();

            ex.wynik = wynik;
            ex.id_wiz = id_wiz;
            ex.kod = kod;

            dc.Physical_exams.InsertOnSubmit(ex);
            dc.SubmitChanges();

        }
    }
}
