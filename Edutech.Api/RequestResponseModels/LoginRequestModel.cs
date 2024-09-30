using System;

namespace Edutech.Api.RequestResponseModels;

public class LoginRequestModel
{
    public required string Username { get; set; }
    public  required string Password { get; set; }
}
