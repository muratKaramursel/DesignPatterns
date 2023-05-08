namespace DP.Prototype.Entity
{
    internal class Employee : BasePerson
    {
        public decimal Salary { get; set; }

        public override BasePerson Clone()
        {
            return (Employee) MemberwiseClone();
        }
    }
}