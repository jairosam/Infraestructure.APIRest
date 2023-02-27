using AutoMapper;
using Infraestructure.API.Context;
using Infraestructure.API.DTO;
using Infraestructure.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;

namespace Infraestructure.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UsuarioController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> CrearUsuario([FromBody] UsuarioCreacionDTO usuarioDTO)
        {
            var existe = await context.Usuario.AnyAsync(x => x.correo.Equals(usuarioDTO.correo));

            if (existe)
            {
                return BadRequest($"El usuario con el correo {usuarioDTO.correo} ya se encuentra registrado");
            }

            var usuario = mapper.Map<Usuario>(usuarioDTO);
            context.Add(usuario);
            await context.SaveChangesAsync();
            return Ok(usuario);
        }

        [HttpGet("{correo}")]
        public async Task<ActionResult<UsuarioConsultaDTO>> consultarUsuario([FromRoute] string correo)
        {
            var usuario = await context.Usuario.FirstOrDefaultAsync(x => x.correo.Equals(correo));
            if (usuario == null)
            {
                return BadRequest($"El usuario con el correo {correo} no fue encontrado en la plataforma");
            }
            var usuarioConsultaDTO = mapper.Map<UsuarioConsultaDTO>(usuario);
            return usuarioConsultaDTO;
        }

    }
}
