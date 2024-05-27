namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int corectPassword = 1234;
            decimal cardBalance = 1500;
            int maxCount = 3;
            int count = 0;
            while (count <maxCount)
            {
                Console.Write($"Enter your password:");
                int cardPassword = Convert.ToInt32(Console.ReadLine());

                if (cardPassword == corectPassword)
                {
                    Console.WriteLine($"{count+1}.Tebrikler, Sisteme daxil oldunuz.");
                    Console.WriteLine($"Kartinizin Balansi: {cardBalance}");
                    count = 0;
                    break;
                }
                else
                {
                    count++;
                    if (count <maxCount)
                    {
                        Console.Write($"{count+1} .cehdiniz ");
                    }
                    else if(count<maxCount)
                    {
                        Console.WriteLine($"{count+1} .cehdiniz ");
                    }
                    else
                    {
                        Console.WriteLine("Kartiniz bloklandi");
                    }
                }
            }
                
        }
    }
}
