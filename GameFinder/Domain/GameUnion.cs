using GameFinder.Domain.Model;
using System.Collections.Generic;

namespace GameFinder.Model
{
    public class GameUnion
    {
        public Game Game { get; private set; }

        public Manufacturer Manufacturer { get; private set; }

        public Store Store { get; private set; }

        public GameUnion(
            Game game, 
            Manufacturer manufacturer, 
            Store store)
        {
            Game = game;
            Manufacturer = manufacturer;
            Store = store;
        }

        public List<string> ToStringList()
        {
            List<string> str = new List<string>();
            str.Add(Game.Name);
            str.Add(Manufacturer.Name);
            str.Add(Game.Year.ToString());
            str.Add(string.Join(", ", Game.Genres));
            str.Add(string.Join(", ", Game.Languages));
            str.Add(Store.Name);
            str.Add(Game.Price.ToString());
            return str;
        }
    }
}
