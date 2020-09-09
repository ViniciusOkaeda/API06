using Microsoft.EntityFrameworkCore;
using Senai.Efcore.tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Efcore.tarde.Context
{
    public class EscolaContext : DbContext
    {
        public DbSet<Escola> Escolas { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<EscolaAluno> EscolasAlunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=.\SqlExpress; Initial Catalog=Db_Senai_Escola_Tarde_Dev; user id=sa; password=sa132");
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
