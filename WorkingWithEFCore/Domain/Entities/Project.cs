﻿namespace Domain.Entities;

public class Project
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public Organization? Organization { get; set; }

    public List<Project>? Developer { get; set; }

    public DateTime Started { get; set; }
}
