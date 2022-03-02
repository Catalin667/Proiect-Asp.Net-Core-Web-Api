using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class CreateProfesorDTO
    {
        public int ProfesorId { get; set; }
        
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public String Data_angajarii { get; set; }

        public double Salariu { get; set; }

        public string Specializari { get; set; }

        public Sala Sala { get; set; }

    }
}
