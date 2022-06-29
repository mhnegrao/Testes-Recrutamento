using TradeCategory.Model;
using System.Text;
namespace TradeCategory.Service
{
    public class TradeService : ITradeService
    {

        public List<Business> StoreData(StreamReader streamReader)
        {
            var businessList = new List<Business>();

            string line = string.Empty;

            while ((line = streamReader.ReadLine()) != null)
            {
                var occur = new Business();
                if (IsDate(line.Substring(0, 10)))
                {
                    occur.DateRef = Convert.ToDateTime(line.Substring(0, 10));
                    streamReader.ReadLine();
                }
                else if (IsNum(line.Substring(0, 10)))
                {
                    occur.IdBusiness = Convert.ToInt32(line.Substring(0, 10));
                    streamReader.ReadLine();
                }
                var reg = line.Split(' ');
                if (!IsDate(line) && !IsNum(line))
                {
                    occur.Trades.Add(new Trade
                    {
                        Value = Convert.ToDouble(reg[0]),
                        ClientSector = reg[1],
                        NextPaymentDate = Convert.ToDateTime(reg[2])
                    });
                    businessList.Add(occur);
                }

            }

            return businessList;
        }

        bool IsDate(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                DateTime dt;
                return (DateTime.TryParse(input, out dt));
            }
            return false;

        }
        bool IsNum(string input) => input.All(char.IsNumber);


    }
}
