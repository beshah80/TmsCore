string? region = "null";
//three ways 

// Null-conditional operator '?.' — skip the call if null
// If region is null, ToUpper() never executes. No crash.

string? upperRegion = region?.ToUpper();
Console.WriteLine($"Region (conditional): {upperRegion}");
