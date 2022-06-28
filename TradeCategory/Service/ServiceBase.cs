using System.Text;

namespace TradeCategory.Service
{
    public class ServiceBase : IServiceBase
    {
        public void GetData(string file)
        {

            using var fileStream = new FileStream(@file, FileMode.Open, FileAccess.Read);
            using var streamReader = new StreamReader(fileStream, Encoding.UTF8);
            string? line;

            while ((line = streamReader.ReadLine()) != null)
            {
                var reg = line.Split(' ');
                if (!IsDate(line) && !IsNum(line))
                {
                    Console.WriteLine(string.Format("{0}", CheckRisk(reg[0], reg[2])));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Done!");
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

        string CheckRisk(string value, string date)
        {
            var msg = string.Empty;
            var vlr = Convert.ToDouble(value);
            var dt = Convert.ToDateTime(date);
            switch (vlr)
            {
                case > 100000.00:
                    msg = "HIGH RISK"; break;
                case < 100000.00:
                    msg = "MEDIUM RISK"; break;
            }
            return DateTime.Now.Subtract(dt).Days > 30 ? msg = $"EXPIRED\n{msg}" : msg;
        }
    }
}