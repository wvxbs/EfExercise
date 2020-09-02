using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EfExercise2.Models;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using MongoDB.Driver;

namespace EfExercise2.MongoController
{
    class AccessDatabase
    {

        IMongoDatabase database;

        public AccessDatabase()
        {
            ConnectToDatabase();
        }

        private void ConnectToDatabase()
        {
            RetrieveConnectionString retrieveConnectionString = new RetrieveConnectionString();

            var client = new MongoClient(retrieveConnectionString.GetMongoConnectionString());

            database = client.GetDatabase("test");
        }

        public void AddToDatabase(Log log)
        {
            BuildBsonObject buildBsonObject = new BuildBsonObject(log);
        }
    }
}