using Microsoft.Extensions.Configuration;
using Azure.Storage.Blobs;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer;

public class Container
{
    private string _connectionString;

    public string ContainerName { get; set; }

    [Required]
    public BlobContainerClient BlobContainer { get; set; }

    public Container(string containerName)
    {
        ContainerName = containerName;

        _connectionString = GetConnectionString();
        BlobServiceClient blobServiceClient = new (_connectionString);
        BlobContainer = blobServiceClient.GetBlobContainerClient(ContainerName);
    }

    private string GetConnectionString()
    {
        string settingsFile = Path.Combine("Settings", "ConnectionConfigs.json");
        string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);

        ConfigurationBuilder builder = new();
        builder.AddJsonFile(settingsPath);

        return builder.Build().GetSection("ConnectionString").Value!;
    }
}