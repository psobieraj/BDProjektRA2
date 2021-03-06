﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer; 

namespace BizzLayer
{
    public class Bizz_Doctor
    {

        public static IQueryable<TResult> GetVisits<TResult>(Func<object, object, object, object, object, object,object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = from d in dc.Patients
                         join b in dc.Visits on d.id_pac equals b.id_pac
                         select creator(d.id_pac, d.Imie, d.nazwisko, b.status, b.data_rej.ToString().Substring(0, 10), b.data_anul_zak.ToString().Substring(0, 10), b.id_wiz);
            return result;
        }

        public static IQueryable<TResult> FilterVisits<TResult>(string pattern, DateTime pattern2, string pattern3, bool check,
                  Func<object, object, object, object, object, object,object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            if (check)
            {
                var result = from d in dc.Patients
                             join b in dc.Visits on d.id_pac equals b.id_pac
                             where d.nazwisko.Contains(pattern) && b.data_rej.Equals(pattern2) && b.status.Contains(pattern3)
                             select creator(d.id_pac, d.Imie, d.nazwisko, b.status, b.data_rej.ToString().Substring(0, 10), b.data_anul_zak.ToString().Substring(0, 10), b.id_wiz);
                return result;
            }
            else
            {
                var result = from d in dc.Patients
                             join b in dc.Visits on d.id_pac equals b.id_pac
                             where d.nazwisko.Contains(pattern) && b.status.Contains(pattern3)
                             select creator(d.id_pac, d.Imie, d.nazwisko, b.status, b.data_rej.ToString().Substring(0, 10), b.data_anul_zak.ToString().Substring(0, 10), b.id_wiz);
                return result;
            };
        }

        public static void UpdateVisitEnd(int id_wiz, System.DateTime data_zak, string opis, string diagnoza)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Visit vis = (from v in dc.Visits
                         where v.id_wiz == id_wiz
                         select v).Single();

            if (vis.status == "ANUL") return;

            vis.opis = opis;
            vis.diagnoza = diagnoza;

            if (vis.status == "REJ")    
            {
                vis.status = "ZAK";
                vis.data_anul_zak = data_zak;
            }
            dc.SubmitChanges();
        }

        public static void UpdateVisitCancel(int id_wiz, System.DateTime data_anul, string opis, string dignoza)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Visit vis = (from v in dc.Visits
                         where v.id_wiz == id_wiz
                         select v).Single();

            if (vis.status != "ANUL")
            {
                vis.status = "ANUL";
                vis.data_anul_zak = data_anul;
                dc.SubmitChanges();
            }
        }

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

        public static void AddLabExam(string uwagi, int id_wiz, string kod) 
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            Laboratory_exam ex = new Laboratory_exam();
            ex.uwagi_lek = uwagi;
            ex.id_wiz = id_wiz;
            ex.kod = kod;

            ex.id_lab = 1;
            ex.id_klab = 1;
            ex.status = "ZLEC";
            ex.data_zlec = System.DateTime.Today;

            dc.Laboratory_exams.InsertOnSubmit(ex);
            dc.SubmitChanges();
        }

        public static IQueryable<TResult> GetPhisicalExaminationList<TResult>(int id_pac, int id_wiz, Func<object, object, object, object, object, object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = from p in dc.Patients
                         join v in dc.Visits on p.id_pac equals v.id_pac
                         join ph in dc.Physical_exams on v.id_wiz equals ph.id_wiz
                         join di in dc.Exam_dictionaries on ph.kod equals di.kod

                         where p.id_pac == id_pac
                         where di.typ == "fiz"
                         where v.id_wiz == id_wiz

                         select creator(p.id_pac, p.nazwisko, v.data_anul_zak.ToString().Substring(0, 10), di.kod, di.nazwa, ph.wynik);
            return result;
        }

        public static IQueryable<TResult> GetLaboratoryExaminationList<TResult>(int id_pac, Func<object, object, object, object, object, object, object, object, object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = from p in dc.Patients
                         join v in dc.Visits on p.id_pac equals v.id_pac
                         join lab in dc.Laboratory_exams on v.id_wiz equals lab.id_wiz
                         join di in dc.Exam_dictionaries on lab.kod equals di.kod

                         where p.id_pac == id_pac
                         where di.typ == "lab"

                         select creator(p.id_pac, p.nazwisko, lab.data_wyk_anul.ToString().Substring(0, 10), lab.data_zlec.ToString().Substring(0, 10), di.kod, di.nazwa, lab.uwagi_lek, lab.wynik, lab.status);
            return result;
        }//GetLaboratoryExaminationList

        public static string GetDescription(int id_wiz)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Visit vis = (from v in dc.Visits
                         where v.id_wiz == id_wiz
                         select v).Single();

            return vis.opis;
        }//GetDescription

        public static string GetDiagnosis(int id_wiz)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Visit vis = (from v in dc.Visits
                         where v.id_wiz == id_wiz
                         select v).Single();

            return vis.diagnoza;
        }//GetDiagnosis

    }//public class Bizz_Doctor
}
