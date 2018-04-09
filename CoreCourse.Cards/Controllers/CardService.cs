using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.Cards.Controllers
{
    public class CardService
    {
        private static Card[] Cards = new Card[]
        {
            new Card
            {
                Id = 0,
                FirstName = "Skipper",
                LastName = "--",
                DateOfBirth = new DateTime(2012, 10, 12),
                Department = "Boss Department",
                ImageUrl = "/images/P1.png"
            },
            new Card
            {
                Id = 1,
                FirstName = "Rico",
                LastName = "--",
                DateOfBirth = new DateTime(2013, 11, 2),
                Department = "Team Department",
                ImageUrl = "/images/P2.png"
            },
            new Card
            {
                Id = 2,
                FirstName = "Kovalski",
                LastName = "--",
                DateOfBirth = new DateTime(2013, 4, 4),
                Department = "Team Department",
                ImageUrl = "/images/P3.png"
            },
            new Card
            {
                Id = 3,
                FirstName = "Private",
                LastName = "--",
                DateOfBirth = new DateTime(2016, 1, 1),
                Department = "Team Department",
                ImageUrl = "/images/P4.png"
            },
        };

        public Card Get(int id)
        {
            if (id < 0 || id >= Cards.Length)
            {
                return null;
            }

            return Cards[id];
        }
       

        public List<Card> Get()
        {
            return Cards.ToList();
        }
    }
}
