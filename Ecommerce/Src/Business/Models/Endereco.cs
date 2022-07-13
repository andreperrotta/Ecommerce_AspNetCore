using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models //representa uma tabela no banco de dados
{
    public class Endereco : Entity //: Entity herda dados do entity
    {
        // prop tab tab
        public Guid FornecedorID { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        
        // EF Relacionamento
        public Fornecedor Fornecedor { get; set; }
        // Clrt D copia
    }
}
