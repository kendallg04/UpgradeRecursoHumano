using System;

namespace SIGRH.Models.DTO.Response;

public class LoginResponse
{
    public TokenResponse InfoToken { get; set; } = new();

    public UserResponse Usuario { get; set; } = new();
}
