using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webapidotnetcore.Data;
using webapidotnetcore.Dto;
using webapidotnetcore.Models;

namespace webapidotnetcore.Controller
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IWebApiRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(IWebApiRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null)
            {
                return Ok(commandItem);
            }
            return NotFound();
        }
    }
}