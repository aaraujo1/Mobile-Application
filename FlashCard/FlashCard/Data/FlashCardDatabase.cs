using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace FlashCard.Data
{
    public class FlashCardDatabase
    {
        readonly SQLiteAsyncConnection database;

        //original list
        public List<Card> cards = new List<Card>()
        {
            new Card(1,"duck", "Duck", "Ente"),
            new Card(2,"squirrel", "Squirrel", "Eichhörnchen"),
            new Card(3,"cow", "Cow", "Kuh"),
            new Card(4,"chicken", "Chicken", "Hähnchen")
        };




        public FlashCardDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Card>().Wait();

            //build DB from list
            foreach(Card c in cards)
            {
                SaveItemAsync(c);
            }
    
    
        }

        //get all items
        public Task<List<Card>> GetItemsAsync()
        {
            return database.Table<Card>().ToListAsync();
        }

        //add item
        public Task<int> SaveItemAsync(Card card)
        {
            if (card.ID != 0)
            {
                return database.UpdateAsync(card);
            }
            else
            {
                return database.InsertAsync(card);
            }
        }
    }
}