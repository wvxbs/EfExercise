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

        public RetrieveConnectionString()
        {
            ReadConnectionString();
        }

        private void ReadConnectionString()
        {
            using (StreamReader st = new StreamReader("ConnectionString.txt"))
            {
                ConnectionString = st.ReadToEnd();
            }
        }

        public string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
