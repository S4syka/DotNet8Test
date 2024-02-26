namespace Domain.DTOs;

public class Room(string name, string description, string price, string imageBase64) : BaseDTO
{
    public Room() : this("", "", "", "")
    {
    }

    public string Name { get; set; } = name;

    public string Description { get; set; } = description;

    public string Price { get; set; } = price;

    public string ImageBase64 { get; set; } = imageBase64;

    public bool Active { get; set; } = false;
}