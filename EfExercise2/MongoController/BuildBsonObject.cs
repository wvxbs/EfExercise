using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EfExercise2.Models;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace EfExercise2.MongoController
{
    class BuildBsonObject
    {
        Log log = new Log();

        private string NomeOriginal;
        private string NomeAlterado;
        private string AutorOriginal;
        private string AutorAlterado;
        private string CategoriaOriginal;
        private string CategoriaAlterada;
        private bool AtivoOriginal;
        private bool AtivoAlterado;
        private DateTime Data;
        private string Acao;

        public BuildBsonObject(string nomeOriginal, string nomeAlterado, string autorOriginal, string autorAlterado, string categoriaOriginal, string categoriaAlterada, bool ativoOriginal, bool ativoAlterado, DateTime date, string acao)
        {
            NomeOriginal = nomeOriginal;
            NomeAlterado = nomeAlterado;
            AutorOriginal = autorOriginal;
            AutorAlterado = autorAlterado;
            CategoriaOriginal = categoriaOriginal;
            CategoriaAlterada = categoriaAlterada;
            AtivoOriginal = ativoOriginal;
            AtivoAlterado = ativoAlterado;
            Data = date;
            Acao = acao;

            ParseBsonObject();
        }

        private void ParseBsonObject()
        {
                        
        }

        public Bson GetParsedBsonObject()
        {
            return 
        }
    }
}