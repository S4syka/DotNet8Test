using DataAccessLayer.Repositories;
using Domain.DTOs;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;

Food food = new Food("badrijani", "20 lali", "Desctipt", "fotoa");
Gallery gallery = new Gallery("Fotoa", "descp", "foto");
HomePicture homePicture = new HomePicture("Fotos");
Room room = new Room("otaxi", "desc", "fasi", "Foto");

string foodjson = JsonSerializer.Serialize(food);
string galleryjson = JsonSerializer.Serialize(gallery);
string homePicturejson = JsonSerializer.Serialize(homePicture);
string roomjson = JsonSerializer.Serialize(room);

FoodRepository foodRepository = new();

HomePictureRepository homePictureRepository = new();
GalleryRepository galleryRepository = new();
RoomRepository roomRepository = new();

foodRepository.Create(food);
galleryRepository.Create(gallery);
homePictureRepository.Create(homePicture);
roomRepository.Create(room);

Console.WriteLine(foodjson);
Console.WriteLine(galleryjson);
Console.WriteLine(homePicturejson);
Console.WriteLine(roomjson);

Console.ReadKey();