namespace Domain.DTOs;

public class HomePicture(string imagebase64) : BaseDTO()
{
    public string ImageBase64 { get; set; } = imagebase64;

    public bool Active { get; set; } = false;
}