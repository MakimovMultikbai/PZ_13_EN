namespace ChainOfCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment payment1 = new() { Summ = 123, Direction = "88005553535" };
            Payment payment2 = new() { Summ = 123, Direction = "1234567890123456" };
            Payment payment3 = new() { Summ = 123, Direction = "123456789012345678901234" };
            Payment payment4 = new() { Summ = 123, Direction = "1" };
            PhoneTransaction phoneTransaction = new();
            CardTransaction cardTransaction = new();
            RequisiteTransaction requisiteTransaction = new();
            phoneTransaction.SetNext(cardTransaction);
            cardTransaction.SetNext(requisiteTransaction);

            bool t1 = phoneTransaction.Execute(payment1);
            Console.WriteLine($"{t1} \n");
            bool t2 = phoneTransaction.Execute(payment2);
            Console.WriteLine($"{t2} \n");
            bool t3 = phoneTransaction.Execute(payment3);
            Console.WriteLine($"{t3} \n");
            bool t4 = phoneTransaction.Execute(payment4);
            Console.WriteLine($"{t4} \n");
        }
    }
}
