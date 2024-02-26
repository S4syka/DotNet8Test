using Domain.DTOs;

namespace Domain.DTOs;

public class Food (string name, string price, string description, string imageBase64) : BaseDTO()
{
    public Food() : this("", "", "", "")
    {
    }

    public string Name { get; set; } = name;

    public string Price { get; set; } = price;

    public string Description { get; set; } = description;

    public string ImageBase64 { get; set; } = imageBase64;

    public bool Active { get; set; } = false;
}