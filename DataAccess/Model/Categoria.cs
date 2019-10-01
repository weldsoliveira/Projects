using System;
using System.Collections.Generic;

namespace DataAccess.Model
{
    public partial class Categoria
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
