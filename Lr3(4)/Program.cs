namespace Fourth
{
    public class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1000,"Someone", "Name","+");
            invoice.Calc();
        }

    }
}
