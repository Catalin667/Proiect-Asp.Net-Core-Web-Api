using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati
{
    public class Sala
    {
#nullable enable
        public int SalaId { get; set; }
        public int? Nr_sala { get; set; }
        public int? Etaj { get; set; }
       
#nullable disable 
        public int ProfesorId { get; set; } /// O sala apartine unui singur profesor
        public Profesor Profesor { get; set; }
        public int OrarId { get; set; }
        public Orar Orar { get; set; }
    }
}
