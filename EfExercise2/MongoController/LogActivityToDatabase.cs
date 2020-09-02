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
    class LogActivityToDatabase
    {
        AccessDatabase accessDatabase;

        public LogActivityToDatabase(Log log)
        {
            accessDatabase = new AccessDatabase();

            accessDatabase.AddToDatabase(log);
        }
    }
}