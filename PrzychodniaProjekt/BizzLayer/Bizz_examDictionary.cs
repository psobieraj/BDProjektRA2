using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class Bizz_examDictionary
    {

        public static IQueryable<Exam_dictionary> GetExams()
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var exams = (from u in dc.Exam_dictionaries
                         //tymczasowe rozwiazanie//where u.typ=="fiz"
                         select u);
            return exams;
        }
    }
}
