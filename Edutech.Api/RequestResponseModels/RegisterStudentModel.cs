using System;

namespace Edutech.Api.RequestResponseModels;

public class RegisterStudentModel
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}
