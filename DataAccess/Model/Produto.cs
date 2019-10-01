using System;
using System.Collections.Generic;

namespace DataAccess.Model
{
    public partial class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long? IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
