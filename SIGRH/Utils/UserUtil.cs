using System;
using System.Data;
using SIGRH.Models.DTO.Request;

namespace SIGRH.Utils;

public class UserUtil
{
    public Boolean ValidarUsuario(UserLoginRequest request)
    {
        return true;
    }

    public Dictionary<int, string> Roles(string user_name = "")
    {

        return new Dictionary<int, string>();

    }
}
