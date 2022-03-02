using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Lacatus_Catalin.Entitati;
using WebApplication_Lacatus_Catalin.Modules.Entity_Modules;

namespace WebApplication_Lacatus_Catalin
{
    public class Context : IdentityDbContext<User, Role, int,
                                    IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
                                    IdentityRoleClaim<int>, IdentityUserToken<int>> 
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            

            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });

                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId); ///Relatie Many To Many
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);

            });

            /// One to One
            modelBuilder.Entity<Profesor>()
                .HasOne(a => a.Sala)
                .WithOne(p => p.Profesor);

            ///One to Many 
            modelBuilder.Entity<Orar>()
                .HasMany(a => a.Sala)
                .WithOne(o => o.Orar);

            ///Many to Many
            modelBuilder.Entity<ProfesorDisciplinaElev>()
                .HasKey(pde =>new { pde.ProfesorId, pde.DisciplinaId, pde.ElevId });

            modelBuilder.Entity<ProfesorDisciplinaElev>()
                .HasOne(pde => pde.Profesor)
                .WithMany(b => b.ProfesorDisciplinaElev)
                .HasForeignKey(pde => pde.ProfesorId);

            modelBuilder.Entity<ProfesorDisciplinaElev>()
               .HasOne(pde => pde.Disciplina)
               .WithMany(b => b.ProfesorDisciplinaElev)
               .HasForeignKey(pde => pde.DisciplinaId);

            modelBuilder.Entity<ProfesorDisciplinaElev>()
               .HasOne(pde => pde.Elev)
               .WithMany(b => b.ProfesorDisciplinaElev)
               .HasForeignKey(pde => pde.ElevId);

          
        }

       

        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Orar> Orar { get; set; }
        public DbSet<Elev> Elev { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<ProfesorDisciplinaElev> ProfesorDisciplinaElev { get; set; } 
        public DbSet<User> User { get; set; }
        public DbSet<SessionToken> SessionTokens { get; set; }
    }
  }

