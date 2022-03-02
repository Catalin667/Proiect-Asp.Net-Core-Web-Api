using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Entitati.DTOs;
using WebApplication_Lacatus_Catalin.Repositories.GenericRepository;
using WebApplication_Lacatus_Catalin.Repositories.ProfesorDisciplinaElevRepository;

namespace WebApplication_Lacatus_Catalin.Repositories.ProfDisElevRepository
{
    public class ProfDisElevRepository : GenericRepository<ProfesorDisciplinaElev>, IProfDisElevRepository
    {
        public ProfDisElevRepository(Context context) : base(context) { }
        
        public async Task<List<ProfesorDisciplinaElev>> GetAllInformations()
        {
             return await _context.ProfesorDisciplinaElev.ToListAsync();
        }
 
        
public async Task<List<objectProfesorDisciplinaElev>> GetDisciplineWithProfesori()
{
    
   var ResultToReturn  =new  List<objectProfesorDisciplinaElev>();
   var disciplinaInfo = (from x in _context.ProfesorDisciplinaElev
                         join y in _context.Profesor on x.ProfesorId equals y.ProfesorId
                         join z in _context.Disciplina on x.DisciplinaId equals z.DisciplinaId
                         select new objectProfesorDisciplinaElev
                         {
                                Denumire_disciplina = (string)z.Denumire_disciplina,
                                Nr_ore_sapt = (int)z.Nr_ore_sapt,
                                Nr_examene = (int)z.Nr_examene,
                                Nume_Profesor = (string)y.Nume,
                                Prenume_Profesor = (string)y.Prenume,
                                Telefon = (string)y.Telefon
                         }).Distinct().ToListAsync();

            foreach(var var in await disciplinaInfo.ConfigureAwait(false))
            {   
                var disciplinaInfoCuProfesor = new objectProfesorDisciplinaElev();
                
                disciplinaInfoCuProfesor.Denumire_disciplina = (string)var.Denumire_disciplina;
                disciplinaInfoCuProfesor.Nr_ore_sapt = (int)var.Nr_ore_sapt;
                disciplinaInfoCuProfesor.Nr_examene = (int)var.Nr_examene;
                disciplinaInfoCuProfesor. Nume_Profesor = (string)var.Nume_Profesor;
                disciplinaInfoCuProfesor.Prenume_Profesor = (string)var.Prenume_Profesor;
                disciplinaInfoCuProfesor.Telefon = (string)var.Telefon;

                Console.Write(disciplinaInfoCuProfesor.Denumire_disciplina);
                ResultToReturn.Add(disciplinaInfoCuProfesor);
            }
            
            return  ResultToReturn;
    }
        
        public async Task<List<ProfesorDisciplinaElev>> GetProfesorWithDisciplineAndElevi()
        {
            return await _context.ProfesorDisciplinaElev
                .Include(p => p.Profesor)
                .Include(d => d.Disciplina)
                .Include(e =>e.Elev).ToListAsync();
        }

      
    }

}