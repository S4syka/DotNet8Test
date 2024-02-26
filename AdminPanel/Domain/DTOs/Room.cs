namespace Domain.DTOs;

public class Room(string? name = null, string? description = null, string? price = null, string? imageBase64 = null) : BaseDTO
{
    public string? Name { get; set; } = name;

    public string? Description { get; set; } = description;

    public string? Price { get; set; } = price;

    public string? ImageBase64 { get; set; } = imageBase64;

    public bool Active { get; set; } = false;
}