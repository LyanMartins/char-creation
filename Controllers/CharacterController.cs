using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using char_creation.Models;
using char_creation.Repositories;
using char_creation.Models.ViewModel;

namespace char_creation.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ILogger<CharacterController> _logger;
        private readonly ICharacterRepository _characterRepository;

        public CharacterController(ILogger<CharacterController> logger,ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Character character)
        {
            try
            {
                ThrowIfInvalidParams(character);
                
                var character1 = _characterRepository.create(character);
                CharacterViewModel characterViewModel = new CharacterViewModel(character1);
                return View("create",characterViewModel);
            }
            catch (Exception e)
            {
                CharacterViewModel characterViewModel = new CharacterViewModel(e.Message);
                return View("create",characterViewModel);
            }
            
        }

        public void ThrowIfInvalidParams(Character character){
            if(string.IsNullOrWhiteSpace(character.name)
                || string.IsNullOrWhiteSpace(character.appearence)
            )
                throw new Exception("Fill in the fields correctly");
        }
    }
}
