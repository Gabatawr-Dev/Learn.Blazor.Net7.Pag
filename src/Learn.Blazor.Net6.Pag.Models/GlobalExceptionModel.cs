﻿namespace Learn.Blazor.Net6.Pag.Models;

[Serializable]
public class GlobalExceptionModel
{
    public string Type { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string? StackTrace { get; set; }

}