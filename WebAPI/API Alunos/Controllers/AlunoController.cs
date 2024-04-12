using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API_Alunos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private AlunoService service;

        public AlunoController(AlunoService service)
        {
            this.service = service;
        }

        [HttpGet("{id}")]
        public IActionResult ObterAluno(Guid id)
        {
            var aluno = this.service.ObterAluno(id);

            if (aluno == null)
                return NotFound();

            var response = AlunoParaResponse(aluno);

            return Ok(response);

        }

        private AlunoResponse AlunoParaResponse(Aluno alunoCriada)
        {
            var response = new AlunoResponse()
            {
                Id = alunoCriada.Id,
                Nome = alunoCriada.Nome,
                CPF = alunoCriada.CPF
            };

            return response;
        }
    }
}
