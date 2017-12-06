using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public class Bizz_Clinic
    {
        public static IQueryable<User> SearchUser(string login, string haslo)
        {
            string hash = Bizz_MD5hash.GetHash(haslo);
            DataClassesClinicDataContext dc = new DataClassesClinicDataContext();
            var user = (from u in dc.Users
                        where u.login == login && u.haslo == hash
                        select u);
            return user;
        }
    }
}
