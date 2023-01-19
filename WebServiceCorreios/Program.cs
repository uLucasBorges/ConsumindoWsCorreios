// See https://aka.ms/new-console-template for more information

using WebServiceCorreios.Models;
using WebServiceCorreios.Services;

var _correioService = new CorreiosService();

#region Frete via WebService Correios

var cepRequest = new CepRequest("", "", "40010", "05275052", "02855050", "1", 1, 16, 5, 15, 0, "s", 200, "n");
var frete = _correioService.ConsultaFrete(cepRequest);

Console.WriteLine("o valor da entrega é de {0} , data prevista de chegada: {1}" , frete.Valor , frete.DataEntrega);

#endregion


#region Consultar Cep via WebServiceCorreios

// o cep deve ser passado no formato 'XXXXX-XXX'
var cep = _correioService.ConsultarCep("05275-052");
Console.WriteLine(cep.Bairro);

#endregion
