using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Alunos
{
    public class TurmaResponse
    {
        public Guid Id { get; set; }
        public string Serie { get; set; }
        public List<Aluno> Alunos { get; set; }
    }
}
