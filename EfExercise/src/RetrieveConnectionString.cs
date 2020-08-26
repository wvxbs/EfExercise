using System;
using System.Configuration;
using System.IO;

namespace EfExercise.src
{
    public class RetrieveConnectionString
    {
        private string Path = "";
        private string ConnectionString = "";
        
        public RetrieveConnectionString()
        {
            LoadPathFromConfigFile();
            ReadConnectionStringFile();
        }

        private void LoadPathFromConfigFile()
        {
              try
             {                 
                 Path =  ConfigurationManager.AppSettings["ConnectionStringPath"];
             }
             catch
             {
              throw;
             }
        }

        private void ReadConnectionStringFile()
        {
            using (StreamReader f = new StreamReader(@Path))
            {
                ConnectionString = f.ReadToEnd();
            }
        }

        public string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}