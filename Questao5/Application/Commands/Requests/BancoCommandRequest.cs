using Questao5.Interfaces.Application;

namespace Questao5.Application.Commands.Requests
{
    public class BancoCommandRequest : IBancoCommandRequest
    {
        public async Task<bool> MovimentacaoConta(string requisicao, int idContaCorrente, decimal valor, string idMovimento)
        {
            throw new NotImplementedException();
        }
    }
}
