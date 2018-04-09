using Microsoft.AspNetCore.Mvc;
using CoreCourse.Cards.Controllers;
using System.Threading.Tasks;

namespace CoreCourse.Cards.ViewCoponents
{
    public class CardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Card card, bool showDrilldown)
        {
            var viewModel = new CardViewModel
            {
                Card = card,
                ShowDrilldown = showDrilldown
            };

            return View(viewModel);
        }
    }

    public class CardViewModel
    {
        public Card Card { get; set; }

        public bool ShowDrilldown { get; set; }
    }
}
