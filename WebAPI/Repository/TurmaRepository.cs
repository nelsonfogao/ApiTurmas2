using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TurmaRepository
    {
        private static List<Turma> Turmas { get; set; } = new List<Turma>();

        public TurmaRepository()
        {

        }

        public void Save(Turma turma)
        {
            turma.Id = Guid.NewGuid();
            Turmas.Add(turma);
        }

        public Turma GetTurma(Guid id)
        {
            return Turmas.Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Turma> GetTurmas()
        {
            return Turmas;
        }

        public void Update(Turma turma)
        {
            Turmas.Remove(turma);
            Turmas.Add(turma);
        }

        public void Remove(Turma turma)
        {
            Turmas.Remove(turma);
        }
    }
}
