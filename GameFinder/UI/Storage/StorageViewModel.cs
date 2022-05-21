using GameFinder.Data.Repository;
using GameFinder.DI;
using GameFinder.Domain.Model;
using GameFinder.Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.UI.Storage
{
    public class StorageViewModel
    {
        private GameRepository gameRepository;

        private ManufacturerRepository manufacturerRepository;

        private StoreRepository storeRepository;

        public StorageViewModel(RepositoryModule repositoryModule)
        {
            gameRepository = repositoryModule.GameRepository;
            manufacturerRepository = repositoryModule.ManufacturerRepository;
            storeRepository = repositoryModule.StoreRepository;
        }

        public List<Manufacturer> GetManufacturers() => manufacturerRepository.GetAll().ToList();

        public List<Store> GetStores() => storeRepository.GetAll().ToList();

        public List<GameUnion> GetGameUnions()
        {
            List<Game> games = gameRepository.GetAll();
            List<Manufacturer> manufacturers = manufacturerRepository.GetAll();
            List<Store> stores = storeRepository.GetAll();

            List<GameUnion> gameUnions = new List<GameUnion>();
            foreach (Game game in games)
            {
                gameUnions.Add(new GameUnion(
                    game,
                    manufacturers.Find(m => m.Id == game.ManufacturerId),
                    stores.Find(store => store.Id == game.StoreId)
                ));
            }
            return gameUnions;
        }

        public void OnIncreaseGameCount(int selectedGameIndex)
        {
            Game game = gameRepository.GetAll()[selectedGameIndex];
            var countUpdate = Builders<Game>.Update.Set(g => g.Count, game.Count + 1);
            gameRepository.UpdateById(game.Id, countUpdate);
        }

        public void OnDecreaseGameCount(int selectedGameIndex)
        {
            Game game = gameRepository.GetAll()[selectedGameIndex];
            if (game.Count > 0)
            {
                var countUpdate = Builders<Game>.Update.Set(g => g.Count, game.Count - 1);
                gameRepository.UpdateById(game.Id, countUpdate);
            }
        }

        public void OnDeleteStore(int selectedStoreIndex)
        {
            Store store = storeRepository.GetAll()[selectedStoreIndex];
            gameRepository.DeleteByStoreId(store.Id);
            storeRepository.DeleteById(store.Id);
        }

        public void OnDeleteManufacturer(int selectedManufacturerIndex)
        {
            Manufacturer manufacturer = manufacturerRepository.GetAll()[selectedManufacturerIndex];
            gameRepository.DeleteByManufacturerId(manufacturer.Id);
            manufacturerRepository.DeleteById(manufacturer.Id);
        }

        public void OnDeleteGame(int selectedGameIndex)
        {
            Game game = gameRepository.GetAll()[selectedGameIndex];
            gameRepository.DeleteById(game.Id);
        }
    }
}
