using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceCorreios.Models
{
    public class CepRequest
    {
        public string nCdEmpresa { get; set; }
        public string sDsSenha { get; set; }
        public string nCdServico { get; set; }
        public string sCepOrigem { get; set; }
        public string sCepDestino { get; set; }
        public string nVlPeso { get; set; }
        public int nCdFormato { get; set; }
        public decimal nCdComprimento { get; set; }
        public decimal nVlAltura { get; set; }
        public decimal nVlLargura { get; set; }
        public decimal nVlDiametro{ get; set; }
        public string sCdMaoPropria { get; set; }
        public decimal nVlValorDeclarado { get; set; }
        public string sCdAvisoRecebimento { get; set; }

        public CepRequest(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nCdComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento)
        {
            this.nCdEmpresa = nCdEmpresa;
            this.sDsSenha = sDsSenha;
            this.nCdServico = nCdServico;
            this.sCepOrigem = sCepOrigem;
            this.sCepDestino = sCepDestino;
            this.nVlPeso = nVlPeso;
            this.nCdFormato = nCdFormato;
            this.nCdComprimento = nCdComprimento;
            this.nVlAltura = nVlAltura;
            this.nVlLargura = nVlLargura;
            this.nVlDiametro = nVlDiametro;
            this.sCdMaoPropria = sCdMaoPropria;
            this.nVlValorDeclarado = nVlValorDeclarado;
            this.sCdAvisoRecebimento = sCdAvisoRecebimento;
        }
    }
}
