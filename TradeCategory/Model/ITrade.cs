namespace TradeCategory.Model
{
    public interface ITrade
    {
        double Value { get; } //indica o valor da transação em dólares
        string ClientSector { get; }//indica o setor do cliente que pode ser "Público" ou "Privado"
        DateTime NextPaymentDate { get; } //indica quando é esperado o próximo pagamento do cliente ao banco
    }
}
