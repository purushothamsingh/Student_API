namespace Student_api.Data
{
    public class Address
    {
        public Guid Id { get; set; }

        public string? PhysicalAddress { get; set; }

        public string? PostalAddress { get; set; }

        // navigation
        public Guid StudentId { get; set; }
    }
}
