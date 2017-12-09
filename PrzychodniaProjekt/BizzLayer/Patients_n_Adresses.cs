using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    /// https://stackoverflow.com/questions/42256412/entity-framework-returning-iqueryable-of-join-of-two-tables
    
    public class Patients_n_Adresses
    {
        public Patient Patient { get; set; }
        public Address Address { get; set; }

    }
}
