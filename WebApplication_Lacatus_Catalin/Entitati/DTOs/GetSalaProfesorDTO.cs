using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Lacatus_Catalin.Entitati.DTOs
{
    public class GetSalaProfesorDTO
    {
        
        //public Sala Sala { get; set; } /// Un profesor are o sala de curs
        public int? Nr_sala { get; set; }
        public int? Etaj { get; set; }


        public GetSalaProfesorDTO(Sala sala)
        { 
            this.Nr_sala = sala.Nr_sala;
            this.Etaj = sala.Etaj;
        }
    }
}
