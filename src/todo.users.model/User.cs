﻿namespace todo.users.model;

public class User
{
    public Guid ExternalId { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string FamilyName { get; set; }
    public string Email { get; set; }

    public User()
    {
        ExternalId = new Guid();
        Username = "";
        FirstName = "";
        FamilyName = "";
        Email = "";
    }
}