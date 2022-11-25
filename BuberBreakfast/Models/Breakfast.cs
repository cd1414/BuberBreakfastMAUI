using System;
namespace BuberBreakfast.Models
{
    public record Breakfast(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDataTime,
        Uri Image,
        List<string> Savory,
        List<string> Sweet);
}

