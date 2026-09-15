namespace Bank
{
    public class BankClass
    {
        // Klass är uppbyggt av Attribut och Metoder 

        // Dessa är attributer av klass Bank
        public string BankName;

        // Andra attribut
        public string OrganisationNumber;

        // Metoderna som bank klassen kan göra
        public void TransferMoney()
        {
            Console.WriteLine("Transfering money");
        }

        public void Login ()
        {
            Console.WriteLine("Trying to login");
        }
    }
}