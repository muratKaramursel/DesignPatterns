namespace DP.Prototype.Entity
{
    internal abstract class BasePerson : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public abstract BasePerson Clone();
    }
}