using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class Bizz_technician
    {
        public static IQueryable<TResult> GetExams<TResult>(Func<object, object, object, object, object, object, object, object, object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = from d in dc.Laboratory_exams
                         where d.status != "ZATW"
                         select creator(d.kod, d.data_zlec.ToString().Substring(0, 10), d.data_wyk_anul.ToString().Substring(0, 10), d.data_zatw_anul.ToString().Substring(0, 10), d.uwagi_lek, d.wynik, d.uwagi_kier, d.status, d.id_bad_lab);
            return result;
        }

        public static IQueryable<TResult> GetExamsSupervisor<TResult>(Func<object, object, object, object, object, object, object, object, object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = from d in dc.Laboratory_exams
                         where d.status != "ZLEC"
                         select creator(d.kod, d.data_zlec.ToString().Substring(0, 10), d.data_wyk_anul.ToString().Substring(0, 10), d.data_zatw_anul.ToString().Substring(0, 10), d.uwagi_lek, d.wynik, d.uwagi_kier, d.status, d.id_bad_lab);
            return result;
        }

        public static IQueryable<TResult> FilterExams<TResult>(DateTime data, string status, bool check, 
            Func<object, object, object, object, object, object, object, object, object, TResult> creator)
        {
                DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            if (!check)
            {
                var result = from d in dc.Laboratory_exams
                             where d.status.Contains(status) && d.status != "ZATW"
                             select creator(d.kod, d.data_zlec.ToString().Substring(0, 10), d.data_wyk_anul.ToString().Substring(0, 10), d.data_zatw_anul.ToString().Substring(0, 10), d.uwagi_lek, d.wynik, d.uwagi_kier, d.status, d.id_bad_lab);
                return result;
            }
            else
            {
                var result = from d in dc.Laboratory_exams
                             where d.status.Contains(status) && d.status != "ZATW"
                             where d.data_zlec == data
                             select creator(d.kod, d.data_zlec.ToString().Substring(0, 10), d.data_wyk_anul.ToString().Substring(0, 10), d.data_zatw_anul.ToString().Substring(0, 10), d.uwagi_lek, d.wynik, d.uwagi_kier, d.status, d.id_bad_lab);
                return result;
            }
        }

        public static string GetExamName(string kod)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Exam_dictionary exam = (from e in dc.Exam_dictionaries
                                    where e.kod == kod
                         select e).Single();

            return exam.nazwa;
        }// public static string GetExamName

        public static string GetResult(int id_bad)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Laboratory_exam exam = (from e in dc.Laboratory_exams
                                    where e.id_bad_lab == id_bad
                                    select e).Single();

            return exam.wynik;
        }// public static string GetExamName

        public static void PerformExam(int id_bad, string wynik)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Laboratory_exam exam = (from e in dc.Laboratory_exams
                         where e.id_bad_lab == id_bad
                         select e).Single();

            //if (vis.status == "ANUL") return;   /// jak anulowana, nie wprowadzac zadnych zmian

            exam.wynik = wynik;
            

            if (exam.status == "ZLEC" || exam.status == "AN_K") //jeszcze chyba trzeba dodać że jeśli jest AN_K to żeby po ponownym wykonaniu nadpisało
            {
                exam.status = "WYK";
                exam.data_wyk_anul = DateTime.Now.Date;
            }
            dc.SubmitChanges();
            //dc.SubmitChanges();


        }

        public static void CancelExam(int id_bad, string wynik)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Laboratory_exam exam = (from e in dc.Laboratory_exams
                                    where e.id_bad_lab == id_bad
                                    select e).Single();

            exam.wynik = wynik;

            if (exam.status == "ZLEC")
            {
                exam.status = "AN_L";       /// ewentualnie do poprawy, w bazie jest varchar(4)
                exam.data_wyk_anul = DateTime.Now.Date;
            }
            dc.SubmitChanges();
         }

        public static IQueryable<TResult> FilterExamsSupervisor<TResult>(DateTime data, string status, bool check,
        Func<object, object, object, object, object, object, object, object, object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            if (!check)
            {
                var result = from d in dc.Laboratory_exams
                             where d.status.Contains(status) && d.status!="ZLEC"
                             select creator(d.kod, d.data_zlec.ToString().Substring(0, 10), d.data_wyk_anul.ToString().Substring(0, 10), d.data_zatw_anul.ToString().Substring(0, 10), d.uwagi_lek, d.wynik, d.uwagi_kier, d.status, d.id_bad_lab);
                return result;
            }
            else
            {
                var result = from d in dc.Laboratory_exams
                             where d.status.Contains(status) && d.status != "ZLEC"
                             where d.data_wyk_anul == data 
                             select creator(d.kod, d.data_zlec.ToString().Substring(0, 10), d.data_wyk_anul.ToString().Substring(0, 10), d.data_zatw_anul.ToString().Substring(0, 10), d.uwagi_lek, d.wynik, d.uwagi_kier, d.status, d.id_bad_lab);
                return result;
            }
        }


        public static void ManageExam(int id_bad, string uwagi, string manage)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Laboratory_exam exam = (from e in dc.Laboratory_exams
                                    where e.id_bad_lab == id_bad
                                    select e).Single();

            //if (vis.status == "ANUL") return;   /// jak anulowana, nie wprowadzac zadnych zmian

            exam.uwagi_kier = uwagi;


            if (exam.status == "WYK")
            {
                if (manage == "confirm")
                {
                    exam.status = "ZATW";
                    exam.data_zatw_anul = DateTime.Now.Date;
                }

                if (manage == "cancel")
                {
                    exam.status = "AN_K";
                    exam.data_zatw_anul = DateTime.Now.Date;
                }
            }
            dc.SubmitChanges();
            //dc.SubmitChanges();


        }





    }
}
