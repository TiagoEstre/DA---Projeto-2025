using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.models
{
    public class Programmer: Users
    {
        
        public ExperienceLevel ExperienceLevel { get; set; }

        public Maneger idManeger {  get; set; }

        public Programmer()
        {
        }
    }
}
