using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class Bizz_admin
    {
        public static IQueryable<User> FilterUser(string pattern)
        {
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var user = (from u in dc.Users
                        where u.login.Contains(pattern)
                        select u);
            return user;
        }
    }
}
