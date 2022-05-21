using GameFinder.Domain.Model;
using GameFinder.Data.Repository;
using MongoDB.Driver;

namespace GameFinder.DI
{
    public class RepositoryModule
    {

        private const string DATABASE_NAME = "gamestores";

        private const string CONNECTION_STRING = "mongodb://localhost:27017";

        public GameRepository GameRepository { get; }

        public ManufacturerRepository ManufacturerRepository { get; }

        public StoreRepository StoreRepository { get; }

        public RepositoryModule()
        {
            MongoClient mongoClient = new MongoClient(CONNECTION_STRING);

            bool databaseExisted = mongoClient.ListDatabaseNames().ToList().IndexOf(DATABASE_NAME) >= 0;
            IMongoDatabase database = mongoClient.GetDatabase(DATABASE_NAME);

            if (!databaseExisted)
            {
                database.CreateCollection("games");
                database.CreateCollection("manufacturers");
                database.CreateCollection("stores");
            }
            
            GameRepository = new GameRepository(database.GetCollection<Game>("games"));
            ManufacturerRepository = new ManufacturerRepository(
                    database.GetCollection<Manufacturer>("manufacturers")
            );
            StoreRepository = new StoreRepository(database.GetCollection<Store>("stores"));

            if (!databaseExisted)
            {
                StoreRepository.FillWithDefault();
                ManufacturerRepository.FillWithDefault();
                GameRepository.FillWithDefault();
            }
        }
    }
}
