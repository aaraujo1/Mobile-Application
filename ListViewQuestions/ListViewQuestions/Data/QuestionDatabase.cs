using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace ListViewQuestions.Data
{
    public class QuestionDatabase
    {
        readonly SQLiteAsyncConnection database;

        public List<Question> questions = new List<Question>()
        {
            new Question("Duck", "Ente"),
            new Question("Squirrel", "Eichhörnchen"),
            new Question("Cow", "Kuh"),
            new Question("Chicken", "Hähnchen")
        };


        public QuestionDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Question>().Wait();

            //build DB from list
            foreach (Question q in questions)
            {
                SaveItemAsync(q);
            }
        }

        public Task<List<Question>> GetItemsAsync()
        {
            return database.Table<Question>().ToListAsync();
        }

        public Task<int> SaveItemAsync(Question question)
        {
            if (question.ID != 0)
            {
                return database.UpdateAsync(question);
            }
            else
            {
                return database.InsertAsync(question);
            }
        }

    }
}
