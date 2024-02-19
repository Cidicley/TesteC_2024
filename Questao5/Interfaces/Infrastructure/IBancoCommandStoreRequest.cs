namespace Questao5.Interfaces.Infrastructure
{
    public interface IBancoCommandStoreRequest
    {
        Task<bool> MovimentacaoConta(string requisicao, int idContaCorrente, decimal valor, string idMovimento);
    }
}
