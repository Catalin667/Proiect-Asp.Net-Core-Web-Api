using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class ProfesorDTO
    {
        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public String Data_angajarii { get; set; }

        public double Salariu { get; set; }

        public string Specializari { get; set; }
        public Sala Sala { get; set; } /// Un profesor are o sala de curs
     

        public ProfesorDTO(Profesor profesor)
        {
            this.Nume = profesor.Nume;
            this.Prenume = profesor.Prenume;
            this.Telefon = profesor.Telefon;
            this.Email = profesor.Email;
            this.Data_angajarii = profesor.Data_angajarii;
            this.Salariu = (double)profesor.Salariu;
            this.Specializari = profesor.Specializari;
            this.Sala = profesor.Sala;
           
        }
    }
}
