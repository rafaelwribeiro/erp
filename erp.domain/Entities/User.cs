﻿namespace erp.domain.Entities;

public sealed class User : Entity
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
