using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class ElevDTO
    {
   

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public int Varsta { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public string Ocupatia { get; set; }

        public ElevDTO(Elev elev)
        {
            this.Nume = elev.Nume;
            this.Prenume =  elev.Prenume;
            this.Varsta =  elev.Varsta;
            this.Telefon = elev.Telefon;
            this.Email = elev.Email;
            this.Ocupatia = elev.Ocupatia;

        }
    }
}
