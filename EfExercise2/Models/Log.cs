using System;

namespace EfExercise2.Models
{
    class Log
    {
        public Log()
        {
            NomeOriginal = "";
            NomeAlterado = "";
            AutorOriginal = "";
            AutorAlterado = "";
            CategoriaOriginal = "";
            CategoriaAlterada = "";
            AtivoOriginal = null;
            AtivoAlterado = null;
            Data = new DateTime();
            Acao = "";
        }

        public string NomeOriginal { get; set; }
        public string NomeAlterado { get; set; }
        public string AutorOriginal { get; set; }
        public string AutorAlterado { get; set; }
        public string CategoriaOriginal { get; set; }
        public string CategoriaAlterada { get; set; }
        public bool? AtivoOriginal { get; set; }
        public bool? AtivoAlterado { get; set; }
        public DateTime Data { get; set; }
        public string Acao { get; set; }

    }
}