namespace Questao5.Interfaces.Application
{
    public interface IBancoCommandRequest
    {
        Task<bool> MovimentacaoConta(string requisicao, int idContaCorrente, decimal valor, string idMovimento);
    }
}
