using TradeCategory.Model;
using System.Text;
namespace TradeCategory.Service
{
    public interface ITradeService
    {
        List<Business> StoreData(StreamReader streamReader);
    }
}
