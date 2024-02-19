using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Domain.DTOs;
using Domain.Interfaces;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DataAccessLayer.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseDTO
{
    protected abstract string GetContainerName();

    [Required]
    private Container ContainerClient { get; set; }

    public BaseRepository()
    {
        ContainerClient = new Container(GetContainerName());
    }

    public IEnumerable<TEntity> Load()
    {
        Collection<TEntity> res = new();

        foreach (var blobItem in ContainerClient.BlobContainer.GetBlobs())
        {
            BlobClient blobClient = ContainerClient.BlobContainer.GetBlobClient(blobItem.Name);

            var downloadResponse = blobClient.Download();
            var jsonStream = downloadResponse.Value.Content;

            using var reader = new StreamReader(jsonStream);
            string jsonString = reader.ReadToEnd();

            TEntity jsonObject = JsonConvert.DeserializeObject<TEntity>(jsonString)!;
            res.Add(jsonObject);
        }

        return res;
    }

    public void Create(TEntity entity)
    {
        BlobClient blobClient = ContainerClient.BlobContainer.GetBlobClient($"{GetContainerName()}-{entity.Id}");

        string json = JsonConvert.SerializeObject(entity);
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
        blobClient.Upload(stream, true);
    }

    public TEntity Read(Guid id)
    {
        BlobClient blobClient = ContainerClient.BlobContainer.GetBlobClient($"{GetContainerName()}-{id}");

        var downloadResponse = blobClient.Download();
        var jsonStream = downloadResponse.Value.Content;

        using var reader = new StreamReader(jsonStream);
        string jsonString = reader.ReadToEnd();

        return JsonConvert.DeserializeObject<TEntity>(jsonString)!;
    }

    public void Update(TEntity entity)
    {
        BlobClient blobClient = ContainerClient.BlobContainer.GetBlobClient($"{GetContainerName()}-{entity.Id}");

        var json = JsonConvert.SerializeObject(entity);

        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(json));
        blobClient.Upload(stream, true);
    }

    public void Delete(Guid id)
    {
        BlobClient blobClient = ContainerClient.BlobContainer.GetBlobClient($"{GetContainerName()}-{id}");

        blobClient.DeleteIfExists();
    }
}