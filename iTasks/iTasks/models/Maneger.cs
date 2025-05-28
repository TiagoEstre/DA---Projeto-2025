using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.models
{
    public class Maneger : Users
    { 
        public Department Department { get; set; }
        public string GenerateUser { get; set; }

        public Maneger()
        {
            
        }
    }
}
