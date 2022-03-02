using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati
{
    public class Orar
    {
#nullable enable
        public int OrarId { get; set; }
        public string? Ora_inceput { get; set; }
        public string? Ora_final { get; set; }
        public string? An_Scolar { get; set; }
#nullable disable
        public ICollection<Sala> Sala  { get; set; }

    }
}
