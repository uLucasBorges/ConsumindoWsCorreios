using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cep;
using Frete;
using WebServiceCorreios.Models;
using static Frete.CalcPrecoPrazoWSSoapClient;

namespace WebServiceCorreios.Services
{
    public class CorreiosService
    {
        public FreteResult ConsultaFrete(CepRequest cep)
        {
            var wsfrete = new CalcPrecoPrazoWSSoapClient(new EndpointConfiguration());

            var simulacao = wsfrete.CalcPrecoPrazoAsync(
                cep.nCdEmpresa,
                cep.sDsSenha,
                cep.nCdServico,
                cep.sCepOrigem,
                cep.sCepDestino,
                cep.nVlPeso, 
                cep.nCdFormato,
                cep.nCdComprimento,
                cep.nVlAltura,
                cep.nVlLargura,
                cep.nVlDiametro,
                cep.sCdMaoPropria,
                cep.nVlValorDeclarado,
                cep.sCdAvisoRecebimento).Result;

            var t = wsfrete.CalcPrazoAsync(cep.nCdServico, cep.sCepOrigem, cep.sCepDestino).Result;      
            
           

            foreach (var item in t.Servicos)
            {
                foreach (var i in simulacao.Servicos)
                {
                    i.DataMaxEntrega = item.DataMaxEntrega;
                }
            }

            var obj = simulacao.Servicos.FirstOrDefault();
            return new FreteResult() { Valor = obj.Valor, DataEntrega = obj.DataMaxEntrega };

        }


        public Endereco ConsultarCep(string cep)
        {
            //consulta o endereço atraves do cep
            var correios = new AtendeClienteClient();

            var result = correios.consultaCEPAsync(cep.Replace("-", "")).Result;

            if (result != null)
            {
                var endereco = new Endereco()
                {
                    Logradouro = result.@return.end,
                    Complemento = result.@return.complemento2,
                    Bairro = result.@return.bairro,
                    Cidade = result.@return.cidade,
                    UF = result.@return.uf
                };

                return endereco;
            }

            throw new System.Exception();
        }
    }
}
