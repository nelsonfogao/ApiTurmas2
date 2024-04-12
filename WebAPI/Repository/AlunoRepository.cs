using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AlunoRepository
    {
        private static List<Aluno> Alunos { get; set; } = new List<Aluno>();
        private static List<Turma> Turmas { get; set; } = new List<Turma>();

        private TurmaRepository turmaRepository;

        public AlunoRepository(TurmaRepository turmaRepository)
        {
            this.turmaRepository = turmaRepository;
        }


        public Aluno GetAluno(Guid id)
        {
            Turmas = turmaRepository.GetTurmas();
            Alunos = Turmas.SelectMany(turma => turma.Alunos.SelectMany(x=> turma.Alunos)).ToList();
            return Alunos.Where(x => x.Id == id).FirstOrDefault();
        }


    }
}
