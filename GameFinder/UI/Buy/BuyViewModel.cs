using GameFinder.Domain.Model;
using GameFinder.Data.Repository;
using GameFinder.DI;
using System.Collections.Generic;
using System.Linq;
using GameFinder.Domain;
using MongoDB.Driver;
using GameFinder.Model;

namespace GameFinder.UI.Buy
{
    public class BuyViewModel
    {
        private GameRepository gameRepository;

        private ManufacturerRepository manufacturerRepository;
         
        private StoreRepository storeRepository;

        private List<GameUnion> searchResult;
        public List<GameUnion> SearchResult => searchResult.ToList();

        private Cart cart;

        public BuyViewModel(RepositoryModule repositoryModule)
        {
            gameRepository = repositoryModule.GameRepository;
            manufacturerRepository = repositoryModule.ManufacturerRepository;
            storeRepository = repositoryModule.StoreRepository;
            cart = new Cart();
        }

        public List<string> GetManufacturerOptions()
        {
            var manufacturerNames = manufacturerRepository.GetAll().ToList()
                .ConvertAll(m => m.Name);
            manufacturerNames.Insert(0, "");
            return manufacturerNames;
        }

        public void OnSearch(string name, string manufacturerName, bool sortByPrice)
        {
            List<Game> games = gameRepository.GetByName(name).Where(g => g.Count > 0).ToList();
            if (sortByPrice)
                games = games.OrderBy(g => g.Price).ToList();

            List<Manufacturer> manufacturers = new List<Manufacturer>();
            if (string.IsNullOrWhiteSpace(manufacturerName))
                manufacturers = manufacturerRepository.GetAll();
            else
                manufacturers.Add(
                    manufacturerRepository.GetByName(manufacturerName)
                );

            List<Store> stores = storeRepository.GetAll();

            List<GameUnion> gameUnions = new List<GameUnion>();
            foreach (Game game in games)
            {
                var manufacturer = manufacturers.Find(m => m.Id == game.ManufacturerId);
                if (manufacturer != null)
                {
                    gameUnions.Add(new GameUnion(
                        game,
                        manufacturer,
                        stores.Find(store => store.Id == game.StoreId)
                    ));
                }
            }

            searchResult = gameUnions;
        }

        public int GetCartTotal() => cart.GetTotal();

        public Dictionary<GameUnion, int> GetCartItems() => cart.Items;

        public void OnGameAddToCart(int selectedGameIndex, int count)
        {
            GameUnion union = searchResult[selectedGameIndex];
            cart.Add(union, count);
        }

        public void OnRemoveFromCart(int selectedGameIndex)
        {
            GameUnion union = cart.Items.Keys.ToArray()[selectedGameIndex];
            cart.Remove(union);
        }

        public void OnCartClear() => cart.Clear();

        public bool OnCheckout()
        {
            if (cart.Items.Count == 0)
                return false;

            foreach (GameUnion union in cart.Items.Keys)
            {
                var update = Builders<Game>.Update
                    .Set(g => g.Count, union.Game.Count - cart.Items[union]);
                gameRepository.UpdateById(union.Game.Id, update);
            }
            cart.Clear();
            return true;
        }
    }
}
