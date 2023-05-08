namespace DP.Prototype.Entity
{
    internal class Customer : BasePerson
    {
        public string? CreditCardNumber { get; set; }

        public override BasePerson Clone()
        {
            return (Customer) MemberwiseClone();
        }
    }
}