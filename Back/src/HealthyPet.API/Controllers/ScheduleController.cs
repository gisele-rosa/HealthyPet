using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HealthyPet.API.Data;
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
        private readonly DataContext _context;
        public ScheduleController(DataContext context)
        {
            _context = context;

        }
        
        [HttpGet]
        public IEnumerable<VetConsult> Get()
        {
           return _context.VetConsults;
        }

        [HttpGet("{id}")]
        public VetConsult GetById(int id)
        {
           return _context.VetConsults.FirstOrDefault(ev => ev.VetConsultId == id);
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
