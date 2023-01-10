﻿using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.DTO
{
    public class BookDTO
    {
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public int QuantidadePagina { get; set; }
        public string NomeAutor { get; set; }
        public string Categoria { get; set; }
    }
}