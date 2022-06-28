namespace TradeCategory.Model
{
public class Trade
{
    double Value { get; set; } //indica o valor da transação em dólares
    string? ClientSector { get; set; }//indica o setor do cliente que pode ser "Público" ou "Privado"
    DateTime NextPaymentDate { get; set; } //indi
}
}
