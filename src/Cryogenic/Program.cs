namespace Cryogenic;

using Serilog;

using System;

public class Program{
    private const string SUPPORTED_EXE_CHECKSUM = "5F30AEB84D67CF2E053A83C09C2890F010F2E25EE877EBEC58EA15C5B30CFFF9";


    private const string LogFormat = "[{Timestamp:HH:mm:ss} {Level:u3} {Properties}] {Message:lj}{NewLine}{Exception}";
    private static readonly ILogger _logger = new LoggerConfiguration()
        .WriteTo.Console(outputTemplate: LogFormat)
        .WriteTo.Debug(outputTemplate: LogFormat)
        .MinimumLevel.Debug()
        .CreateLogger();

    static Program() {
        Log.Logger = _logger;
    }
    public static void Main(String[] args) {
        Spice86.Program.RunWithOverrides(args, new DuneCdOverrideSupplier(), SUPPORTED_EXE_CHECKSUM);
    }
}