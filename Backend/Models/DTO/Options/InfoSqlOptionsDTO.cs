using System;

namespace SIGRH.Models.DTO;

public class InfoSqlOptionsDTO
{
    public string UserName { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public List<string> Servers { get; set; } = new List<string>();

    public List<string> Databases { get; set; } = new List<string>();
}
