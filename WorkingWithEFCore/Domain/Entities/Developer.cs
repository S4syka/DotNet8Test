namespace Domain.Entities;

public class Developer(string name, string email, decimal? salary)
{
    public int Id { get; set; } 

    public string Name { get; set; } = name;

    public string Email { get; set; } = email;

    public decimal? Salary { get; set; } = salary;

    public Organization? Organization { get; set; }
}
