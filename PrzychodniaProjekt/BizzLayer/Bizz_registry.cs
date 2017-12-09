using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class Bizz_registry
    {

        public static IQueryable<Patients_n_Adresses> FilterPatient(string pattern)
        {
            //DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            //var patient = (from p in dc.Patients
            //            where p.nazwisko.Contains(pattern)
            //            select p);
            //return patient;

            //return (from i1 in DBContext.Table1
            //        join j1 in DBContext.Table2 on i1.GroupID equals j1.GroupID
            //        where i1.RecID.Equals(RecID)
            //        select new TableJoinResult { Table1 = i1, Table2 = j1 }).SingleOrDefault();

            //DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            //IQueryable<Patients_n_Adresses> result = (from p in dc.Patients
            //              join a in dc.Addresses
            //                on p.id_pac equals a.id_pac
            //              where p.nazwisko.Contains(pattern)
            //              select new Patients_n_Adresses { Patient =p, Address =a }).SingleOrDefault();
            //return result;

            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = (from p in dc.Patients
                                                      join a in dc.Addresses
                                                      on p.id_pac equals a.id_pac
                                                      where p.nazwisko.Contains(pattern)
                                                      select new { Patient = p,  Address = a });
            return result;


        }
    }
}
