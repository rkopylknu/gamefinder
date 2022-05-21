using GameFinder.Data.Repository;
using GameFinder.DI;
using GameFinder.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace GameFinder.UI.Storage.Create
{
    public class CreateViewModel
    {
        private GameRepository gameRepository;

        private ManufacturerRepository manufacturerRepository;

        private StoreRepository storeRepository;

        public CreateViewModel(RepositoryModule repositoryModule)
        {
            gameRepository = repositoryModule.GameRepository;
            manufacturerRepository = repositoryModule.ManufacturerRepository;
            storeRepository = repositoryModule.StoreRepository;
        }

        public List<string> GetManufacturerNames() =>
            manufacturerRepository.GetAll().ToList().ConvertAll(m => m.Name);

        public List<string> GetStoreNames() =>
            storeRepository.GetAll().ToList().ConvertAll(s => s.Name);

        public void CreateStore(string name, string address) =>
            storeRepository.Insert(
                new Store(name, address)
            );

        public void CreateManufacturer(string name, string country, string website) =>
            manufacturerRepository.Insert(
                new Manufacturer(name, country, website)
            );

        public void CreateGame(
            string name,
            string manufacturerName,
            string storeName,
            List<string> genres,
            int year,
            int price,
            List<string> languages,
            int count
        )
        {
            Manufacturer manufacturer = manufacturerRepository.GetByName(manufacturerName);
            Store store = storeRepository.GetByName(storeName);

            gameRepository.Insert(
                new Game(
                    name,
                    manufacturer.Id,
                    store.Id,
                    genres,
                    year,
                    price,
                    languages,
                    count
                )
            );
        }
    }
}
