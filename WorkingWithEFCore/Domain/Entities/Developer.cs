namespace Domain.Entities;

public class Developer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal? Salary { get; set; }
    public Organization? Organization { get; set; }
}
