﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPI.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string NomeLivro { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
    }
}