using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase //Alterar tudo que tava antes com WeatherForecast para Evento
    {

        //Teste de API
        // public IEnumerable<Evento> _evento = new Evento[] { //Enumerar por evento 
        //         new Evento() {
        //             EventoId = 1,
        //             Tema = "Angular e .NET Core",
        //             Local = "Belo Horizonte",
        //             Lote = "1°Lote",
        //             QtdPessoas = 250,
        //             DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //             ImagemURL = "foto.png"
        //         },
        //         new Evento() {
        //             EventoId = 2,
        //             Tema = "Angular e Suas Novidades",
        //             Local = "São Paulo",
        //             Lote = "2°Lote",
        //             QtdPessoas = 350,
        //             DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
        //             ImagemURL = "foto1.png"
        //         }
        // };
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
 
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {   
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {   
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);       
        }

        [HttpPost]
        public string Post()
        {   
            return "valuePost";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {   
            return $"valuePut com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {   
            return $"valueDelete com id = {id}";
        }
    }
}
