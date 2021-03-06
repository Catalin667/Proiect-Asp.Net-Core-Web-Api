using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati
{
    public class Elev
    {
#nullable enable
        public int Id { get; set; }

        public string? Nume { get; set; }

        public string? Prenume { get; set; }

        public int Varsta { get; set; } 

        public string? Telefon { get; set; }

        public string? Email { get; set; }

        public string? Ocupatia { get; set; }
#nullable disable
        public ICollection<ProfesorDisciplinaElev> ProfesorDisciplinaElev { get; set; }
    }
}
