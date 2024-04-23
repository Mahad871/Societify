using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeProject
{
    internal class SocietyModel
    {
        public int SocietyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bio { get; set; }
        public int PresidentID { get; set; }
    }
}
