using System.Collections.Generic;

namespace Lounge.Web.Models.ViewModels
{
    public class StatsPlayerViewModel
    {
        public List<Player> Players { get; init; }

<<<<<<< HEAD
        public record Player(string Name, int? Mmr, string CountryCode);
=======
        public record Player(string Name, int? Mmr, string? CountryCode);
>>>>>>> 12ec0fb7e7cc3cfb8c9dd2b4ec57a8afd0ec182b

    }
}