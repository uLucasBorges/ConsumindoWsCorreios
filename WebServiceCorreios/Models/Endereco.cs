
using System.ComponentModel.DataAnnotations;


namespace WebServiceCorreios.Models
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Descricao { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
