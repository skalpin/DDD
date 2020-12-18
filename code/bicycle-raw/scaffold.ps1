# Generate EF classes
# Note: The "Dummy" console app. does nothing but is needed by EF
# Run this script from the NuGet Package Manager Console
# Set "Default Project" to "Magenic.Bicycle.Raw.EF"

Scaffold-DbContext -Connection "Server=tcp:localhost,1466;Database=Bicycle;User Id=sa;Password=ddd20demoSQL-;" -Provider "Microsoft.EntityFrameworkCore.SqlServer" -Context "BicycleContext" -OutputDir "C:\code\blitz\DDD-HowTo\code\bicycle-raw\Magenic.Bicycle.Raw.EF\" -DataAnnotations -Force