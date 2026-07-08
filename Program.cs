string? region = "null";
//three ways 

// Null-coalescing operator '??' — provide a fallback value
// If region is null, use "Unassigned" instead.


string displayRegion = region ?? "Unassigned";
Console.WriteLine($"Region: {displayRegion}");