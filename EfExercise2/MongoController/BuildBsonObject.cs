using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EfExercise2.Models;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using MongoDB.Bson;
using System.Collections.ObjectModel;
using SQLitePCL;

namespace EfExercise2.MongoController
{
    class BuildBsonObject
    {
        Log log;
        BsonDocument Document;

        public BuildBsonObject(Log _log)
        {
            log = _log;
            CreateBsonDocument();
        }

        private void CreateBsonDocument()
        {
            Document =  new BsonDocument
            {
                { "NomeOriginal" , log.NomeOriginal },
                { "NomeAlterado" , log.NomeAlterado },
                { "AutorOriginal" , log.AutorOriginal },
                { "AutorAlterado" , log.AutorAlterado },
                { "CategoriaOriginal" , log.CategoriaOriginal },
                { "CategoriaAlterado" , log.CategoriaAlterada },
                { "AtivoOriginal" , log.AtivoOriginal},
                { "AtivoAlterado" , log.AtivoAlterado},
                { "Data" , log.Data},
                { "Acao" , log.Acao }
            };
        }

        public BsonDocument GetCreatedBsonDocument()
        {
            return Document;
        }
    }
}