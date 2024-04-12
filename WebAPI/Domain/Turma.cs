using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Turma
    {
        public Guid Id { get; set; }
        public string Serie { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}
