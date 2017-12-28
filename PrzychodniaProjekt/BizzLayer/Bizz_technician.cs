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
        public static IQueryable<TResult> GetExams<TResult>(Func<object, object, object, object, object, object, object, object, TResult> creator)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var result = from d in dc.Laboratory_exams
                         select creator(d.kod, d.data_zlec, d.data_wyk_anul, d.data_zatw_anul, d.uwagi_lek, d.wynik, d.uwagi_kier, d.status);
            return result;
        }
    }
}
