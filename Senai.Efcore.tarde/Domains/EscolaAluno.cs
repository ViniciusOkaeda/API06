using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Efcore.tarde.Domains
{
    public class EscolaAluno
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("IdEscola")]
        public Guid IdEscola { get; set; }
        
        [ForeignKey("IdAluno")]
        public Guid IdAluno { get; set; }

        public EscolaAluno() 
        {
            Id = Guid.NewGuid();
        }
    }
}
