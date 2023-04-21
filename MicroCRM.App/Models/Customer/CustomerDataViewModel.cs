namespace MicroCRM.App.Models.Customer
{
    public class CustomerDataViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
