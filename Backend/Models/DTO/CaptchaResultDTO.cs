using System;
using System.Text.Json.Serialization;

namespace SIGRH.Models.DTO;

public class CaptchaResultDTO
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("challenge_ts")]
    public DateTime ChallengeTs { get; set; }

    [JsonPropertyName("hostname")]
    public string Hostname { get; set; } = string.Empty;

    [JsonPropertyName("error-codes")]
    public float Score { get; set; }
}
