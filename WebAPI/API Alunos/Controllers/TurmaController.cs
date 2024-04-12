using Application;
using Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API_Alunos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private TurmaService service;

        public TurmaController(TurmaService service)
        {
            this.service = service;
        }

        [HttpPost]
        public IActionResult Criar(TurmaRequest request)
        {
            if (ModelState.IsValid == false) return BadRequest();
            var turma = new Turma()
            {
                Id = new Guid(),
                Serie = request.Serie,
                Alunos = request.Alunos,
            };


            var turmaCriada = this.service.CriarTurma(turma);
            TurmaResponse response = TurmaParaResponse(turmaCriada);

            return Created($"/turma/{response.Id}", response);

        }

        [HttpGet("{id}")]
        public IActionResult ObterTurma(Guid id)
        {
            var turma = this.service.ObterTurma(id);

            if (turma == null)
                return NotFound();

            var response = TurmaParaResponse(turma);

            return Ok(response);

        }

        [HttpGet()]
        public IActionResult ObterTurmas()
        {
            var turmas = this.service.ObterTurmas();

            if (turmas == null)
                return NotFound();

            var response = turmas;

            return Ok(response);

        }

        private TurmaResponse TurmaParaResponse(Turma turmaCriada)
        {
            var response = new TurmaResponse()
            {
                Id = new Guid(),
                Serie = turmaCriada.Serie,
                Alunos = turmaCriada.Alunos,
            };

            return response;
        }

    }
}
