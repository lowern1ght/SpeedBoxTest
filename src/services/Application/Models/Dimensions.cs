using System.Text.Json.Serialization;

namespace Application.Models;

public record Dimensions
{
    public float Weight { get; init; }
    public float Lenght { get; init; }
    public float Width  { get; init; }
    public float Height { get; init; }
}