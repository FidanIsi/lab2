namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var getCard = new GetCard(0.2m);
            getCard.CarrierName = "Bakcell";
            getCard.Number = "+994554242979";
            getCard.Balance = 10;
            

            Console.WriteLine(getCard.CarrierName);
            Console.WriteLine(getCard.Number);  
            Console.WriteLine(getCard.Balance); 
            Console.WriteLine(getCard.Tariff);

            getCard.IncreaseBalance(30.5m);
            Console.WriteLine(getCard.Balance);

            if (getCard.Call ())
            {
                Console.WriteLine("You can make a call!");
            }
            else
            {
                Console.WriteLine("not enough balance");
            }
        }
    }


    public class GetCard
    {
        public GetCard(decimal tariff)
        {
            Tariff = tariff;    
        }
        public string CarrierName { get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public decimal Tariff { get; private set; }

        public void IncreaseBalance(decimal amount)
        {
            if (amount <= 0) { return; }

            Balance += amount;
        }

        public bool Call()
        {
            if (Balance > Tariff)
            { 
                Balance -= Tariff;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}