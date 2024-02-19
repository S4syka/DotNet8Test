namespace Domain.DTOs;

public class Gallery(string name, string description, string imageBase64) : BaseDTO()
{
    public string Name { get; set; } = name;

    public string Description { get; set; } = description;

    public string ImageBase64 { get; set; } = imageBase64;

    public bool Active { get; set; } = false;
}
