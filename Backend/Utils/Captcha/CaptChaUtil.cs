using System;
using SIGRH.Models.DTO;

namespace SIGRH.Utils.Captcha;

public class CaptChaUtil
{
    private readonly IConfiguration _configuration;

    public CaptChaUtil(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<bool> ValidarCaptchaASync(string token)
    {
        var captcha = _configuration.GetSection("ReCaptCha");
        var secret = captcha["SecretKey"];
        using var client = new HttpClient();
        var response = await client.PostAsync($"{captcha["Url"]}?secret{secret}&response={token}", null);
        var result = await response.Content.ReadFromJsonAsync<CaptchaResultDTO>();
        return result?.Success ?? false;
    }
}
