using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HealthyPet.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;

namespace HealthyPet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : ControllerBase
    {
        public ScheduleController(ILogger<ScheduleController> logger)
        {

        }
        public IEnumerable<VetConsult> _vetConsult = new VetConsult[]{
            new VetConsult(){
                VetConsultId = 1,
                Local = "Rua 123, bairro Novo",
                VetConsultDate = DateTime.Now.AddDays(2).ToString(),
                Type = "Normal",
                Veterinarian = "Maria",
                Phone = "(11) 00000000",
                ProfilePhoto = "foto.png"
            },

            new VetConsult(){
                VetConsultId = 2,
                Local = "Rua 123, bairro das Flores",
                VetConsultDate = DateTime.Now.AddDays(2).ToString(),
                Type = "Normal",
                Veterinarian = "Joana",
                Phone = "(11) 00000000",
                ProfilePhoto = "foto1.png"
            },
            };

        [HttpGet]
        public IEnumerable<VetConsult> Get()
        {
           return _vetConsult;
        }

        [HttpGet("{id}")]
        public IEnumerable<VetConsult> GetById(int id)
        {
           return _vetConsult.Where(ev => ev.VetConsultId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
