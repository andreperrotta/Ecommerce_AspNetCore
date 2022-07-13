using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorID { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Ativo { get; set; }

        // EF Relacionamento
        public Fornecedor Fornecedor { get; set; }



    }

}