using GameFinder.Model;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.Domain
{
    class Cart
    {
        private Dictionary<GameUnion, int> items;
        public Dictionary<GameUnion, int> Items => 
            items.ToDictionary(i => i.Key, i => i.Value);

        public Cart() {
            items = new Dictionary<GameUnion, int>();
        }

        public int GetTotal() => items.Sum(u => u.Key.Game.Price * u.Value);

        public void Add(GameUnion union, int count) => items[union] = count;

        public void Remove(GameUnion union) => items.Remove(union);

        public void Clear() => items.Clear();
    }
}
