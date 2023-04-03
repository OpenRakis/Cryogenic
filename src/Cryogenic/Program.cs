using Cryogenic;

using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();
services.AddLogging();
ServiceProvider serviceProvider = services.BuildServiceProvider();
Program.ServiceProvider = serviceProvider;

// Put the SHA256 checksum of your target DOS program here.
Spice86.Program.RunWithOverrides<DuneCdOverrideSupplier>(args, "5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9");

public partial class Program {
    public static ServiceProvider? ServiceProvider { get; set; }
}