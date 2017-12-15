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
                         select creator(d.id_pac, d.Imie, d.nazwisko, b.status, b.data_rej, b.data_anul_zak, b.id_wiz);
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
                             select creator(d.id_pac, d.Imie, d.nazwisko, b.status, b.data_rej, b.data_anul_zak, b.id_wiz);
                return result;
            }
            else
            {
                var result = from d in dc.Patients
                             join b in dc.Visits on d.id_pac equals b.id_pac
                             where d.nazwisko.Contains(pattern) && b.status.Contains(pattern3)
                             select creator(d.id_pac, d.Imie, d.nazwisko, b.status, b.data_rej, b.data_anul_zak, b.id_wiz);
                return result;
            };
        }

        public static void UpdateVisitEnd(int id_wiz, System.DateTime data_zak, string opis, string dignoza)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Visit vis = (from v in dc.Visits
                         where v.id_wiz == id_wiz
                         select v).Single();

            if (vis.status != "ZAK")
            {
                vis.status = "ZAK";
                vis.data_anul_zak = data_zak;
                dc.SubmitChanges();
                dc.SubmitChanges();
            }
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
                dc.SubmitChanges();
            }
        }

    }
}