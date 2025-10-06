using System;

namespace SIGRH.Models.DTO.Response;

public class GeneralResponse<T>
{
    public T? Data { get; set; }

    public string? Message { get; set; }

    public bool Success { get; set; }

    public GeneralResponse(T? data)
    {
        Data = data;
        Message = null;
        Success = true;
    }

    public GeneralResponse()
    {
        Message = null;
        Success = true;
    }
}
