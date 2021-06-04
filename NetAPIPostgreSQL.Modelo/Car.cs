using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAPIPostgreSQL.Modelo
{
    public class Car
    {
        public int Id { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }

        public int Year { get; set; }

        public int Doors { get; set; }
    }
}
