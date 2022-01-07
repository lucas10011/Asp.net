using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAspNetMvc.Models
{
    public class EscolaContext : DbContext
    {
        public EscolaContext() : base("Escola")
        {
            Database.CreateIfNotExists();
        }
        //A propriedade dessa classe Alunos nao necessariamente tem q ser o mesmo nome da tabela
        //Como a classe Aluno tem um Data Notation que indica qual o nome da tabela, entao ele ja sabe qual tabela ele esta referenciando        
        public DbSet<Aluno> Alunos { get; set; }
    }
}