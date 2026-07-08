string? region = "null";
//three ways 

/// Null-coalescing assignment '??=' — assign only if currently null
// Useful for lazy initialization.

region ??= "Addis Ababa"; // Assigns "addis Ababa" only if region is null
Console.WriteLine($"Region after null-coalescing assignment: {region}");