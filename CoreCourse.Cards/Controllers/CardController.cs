using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreCourse.Cards.Controllers
{
    public class CardController : Controller
    {
        private readonly CardService _cardService;

        public CardController(CardService cardService)
        {
            _cardService = cardService;
        }

        public ViewResult Index()
        {
            return View(_cardService.Get());
        }

        public ViewResult Card(int id)
        {
            return View(_cardService.Get(id));
        }
    }
}
