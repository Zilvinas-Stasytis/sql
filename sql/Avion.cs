using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviabaze
{
    public class Avion
    {
        public Guid Id { get; set; }
        public string Registr { get; set; }
        public int Countt { get; set; }

    public string Country { get; set; }
        public Avion(int countt,string registr,string country)
        {
            Id = Guid.NewGuid();
            Registr = registr;
            Countt = countt;
            Country = country;
        }
    }
}