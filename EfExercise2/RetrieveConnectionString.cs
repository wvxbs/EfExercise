using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EfExercise2
{
    public class RetrieveConnectionString
    {
        string ConnectionString = "";
        string MongoConnectionString = "";

        public RetrieveConnectionString()
        {
            ReadConnectionString();
            ReadMongoConnectionString();
        }

        private void ReadConnectionString()
        {
            using (StreamReader st = new StreamReader("ConnectionString.txt"))
            {
                ConnectionString = st.ReadToEnd();
            }
        }

        private void ReadMongoConnectionString()
        {
            using (StreamReader st = new StreamReader("MongoConnectionString.txt"))
            {
                MongoConnectionString = st.ReadToEnd();
            }
        }

        public string GetConnectionString()
        {
            return ConnectionString;
        }

        public string GetMongoConnectionString()
        {
            return MongoConnectionString;
        }
    }
}
