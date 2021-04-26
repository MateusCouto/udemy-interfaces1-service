using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("Pagamento Básico: " + FormattedAmount(BasicPayment));
            sb.AppendLine("Tax: " + FormattedAmount(Tax));
            sb.AppendLine("Total Payament: " + FormattedAmount(TotalPayment));


            return sb.ToString();
        }
        public string FormattedAmount( double amount)
        {
            CultureInfo.CurrentCulture = new("pt-BR", false);
            return amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
