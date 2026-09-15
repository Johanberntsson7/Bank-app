namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");

            // Här vill jag skapa ett objekt av klass Bank
            BankClass bank1 = new BankClass();


            bank1.OrganisationNumber = "123456789";
            bank1.BankName = "nordea";

            

            // Här kallar jag på bank1 metod som är transfer
            bank1.TransferMoney();

            // HÄR SKA MAN LÄGGA TILL SAKER
        }

    }
}