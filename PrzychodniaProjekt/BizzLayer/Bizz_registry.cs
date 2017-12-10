﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class Bizz_registry
    {
        public static IQueryable<Visit> GetVisits()
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var vis = (from v in dc.Visits
                       select v);
            return vis;
        }

        public static IQueryable<Patient> FilterPatient(string pattern, string pattern2, string pattern3)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var pat = (from p in dc.Patients
                        where p.nazwisko.Contains(pattern) && p.Imie.Contains(pattern2) && p.PESEL.Contains(pattern3)
                        select p);
            return pat;
        }

        public static IQueryable<TResult> GetPatients<TResult>(Func<object, object, object, object, object, object, object, object, object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = from d in dc.Patients
                         join b in dc.Addresses on d.id_pac equals b.id_pac
                         select creator(d.id_pac, d.Imie, d.nazwisko, d.PESEL, b.id_adresu,b.miejscowosc, b.ulica, b.nr_domu, b.nr_lokalu);
            return result;
        }



        public static void UpdateVisit(int id_wiz, System.DateTime data_anul)
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

        public static IQueryable<Doctor> GetDoctors()
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var doc = (from d in dc.Doctors
                       select d);
            return doc;
        }
        public static void AddVisit(int id_pac, int id_rec, int id_lek, System.DateTime data_rej)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            Visit vis = new Visit();

            vis.data_rej = data_rej;
            vis.id_pac = id_pac;
            vis.id_lek = id_lek;
            vis.id_rec = id_rec;
            vis.status = "REJ";
            
            dc.Visits.InsertOnSubmit(vis);
            dc.SubmitChanges();

        }

        public static void EditPatient(int id_pac, string Imie, string Nazwisko, string PESEL, int id_adresu,string Miejscowosc, string Ulica, string Nr_domu, string Nr_lokalu)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Patient pat = (from p in dc.Patients
                         where p.id_pac == id_pac
                         select p).Single();

            pat.Imie = Imie;
            pat.nazwisko = Nazwisko;
            pat.PESEL = PESEL;

            Address adr = (from ad in dc.Addresses
                           where ad.id_adresu==id_adresu
                           select ad).Single();

            adr.miejscowosc = Miejscowosc;
            adr.ulica = Ulica;
            adr.nr_domu = Nr_domu;
            adr.nr_lokalu = Nr_lokalu;

            dc.SubmitChanges();
            dc.SubmitChanges();
        }

        public static void AddPatient(string Imie, string Nazwisko, string PESEL, string Miejscowosc, string Ulica, string Nr_domu, string Nr_lokalu)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();

            Patient pat = new Patient();

            pat.Imie = Imie;
            pat.nazwisko = Nazwisko;
            pat.PESEL = PESEL;


            Address adr = new Address();

            adr.miejscowosc = Miejscowosc;
            adr.ulica = Ulica;
            adr.nr_domu = Nr_domu;
            adr.nr_lokalu = Nr_lokalu;

            dc.Patients.InsertOnSubmit(pat);
            dc.Addresses.InsertOnSubmit(adr);
            dc.SubmitChanges();
        }

    }

    }
