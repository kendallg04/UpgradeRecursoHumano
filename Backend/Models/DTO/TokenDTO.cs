using System;

namespace SIGRH.Models.DTO;

public class TokenDTO
{
    public string Token { get; set; } = string.Empty;

    public int ExpiraInSegundos { get; set; }
}
