﻿namespace AutoMotoApp.Entities;

public class Employee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public override string ToString()
    {
        return ($" ID: {Id}, Firstname: {FirstName}");
    }
}