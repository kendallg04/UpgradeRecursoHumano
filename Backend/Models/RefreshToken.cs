using System;

namespace SIGRH.Models;

public class RefreshToken
{
    public string Id { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public DateTime Expiracion { get; set; }
    public bool IsExpired => DateTime.UtcNow >= Expiracion;
    public DateTime Creada { get; set; }
    public DateTime? Revocada { get; set; }
    public string ReemplazoToken { get; set; } = string.Empty;
    public bool IsActived => Revocada == null && !IsExpired;
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
