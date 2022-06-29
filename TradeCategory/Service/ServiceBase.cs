using System.Text;


namespace TradeCategory.Service
{
    public class ServiceBase : IServiceBase
    {

        ITradeService _serv;

        public ServiceBase(ITradeService serv)
        {
            _serv = serv;
        }

        public void GetData(string file)
        {

            using var fileStream = new FileStream(@file, FileMode.Open, FileAccess.Read);
            using var streamReader = new StreamReader(fileStream, Encoding.UTF8);

            var result = _serv.StoreData(streamReader);
            //scan results
            result.ForEach(f =>
            {
                f.Trades.ForEach(t =>
                {
                    Console.WriteLine(string.Format("{0}", CheckRisk(t.NextPaymentDate, t.Value)));
                });
            });

            Console.WriteLine();
            
        }

        string CheckRisk(DateTime date, double value)
        {
            var msg = string.Empty;

            switch (value)
            {
                case > 100000.00:
                    msg = "HIGH RISK"; break;
                case < 100000.00:
                    msg = "MEDIUM RISK"; break;
            }
            return DateTime.Now.Subtract(date).Days > 30 ? msg = $"EXPIRED\n{msg}" : msg;
        }
    }
}