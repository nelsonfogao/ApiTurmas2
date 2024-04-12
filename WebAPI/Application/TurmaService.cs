using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class TurmaService
    {
        private TurmaRepository turmaRepository;

        public TurmaService(TurmaRepository turmaRepository)
        {
            this.turmaRepository = turmaRepository;
        }

        public Turma CriarTurma(Turma turma)
        {
            this.turmaRepository.Save(turma);

            return turma;

        }

        public Turma ObterTurma(Guid id)
        {
            var turma = this.turmaRepository.GetTurma(id);
            return turma;
        }
        public List<Turma> ObterTurmas()
        {
            var turmas = this.turmaRepository.GetTurmas();
            return turmas;
        }
    }
}
