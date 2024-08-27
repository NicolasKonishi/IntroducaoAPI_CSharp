﻿using Microsoft.AspNetCore.Mvc;
using WebAPI.Curso_DIO.Entities;

namespace WebAPI.Curso_DIO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController:ControllerBase
    {

        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new { mensagem });
        }

        
    }
}
