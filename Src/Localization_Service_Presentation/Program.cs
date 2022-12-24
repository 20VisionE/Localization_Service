try
{
    var builder = WebApplication.CreateBuilder(args);
    #region Localization
    builder.Services.AddLocalization();
    #endregion
    #region Add Other Layers services
    builder.Services.AddLayersConfigureService();
    #endregion
    #region AddSerilogToBuilder
    // Builder for Serilog
    Log.Logger = new LoggerConfiguration()
        .WriteTo.Console()
        .CreateBootstrapLogger();

    Log.Information("Starting up");


    builder.Host.UseSerilog((ctx, lc) => lc
        .WriteTo.Console()
        .ReadFrom.Configuration(ctx.Configuration));
    #endregion
    #region AddService To configuration
    builder.Services.AddControllers();
    #endregion
    #region Swagger Configuration
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    var app = builder.Build();

    #endregion
    #region Localization
    var supportedCultures = new[]
       {
            new CultureInfo("en-US"),
            new CultureInfo("ar"),
            new CultureInfo("fa-IR"),
    };

    app.UseRequestLocalization(new RequestLocalizationOptions
    {
        DefaultRequestCulture = new RequestCulture("en-US"),
        // Formatting numbers, dates, etc.
        SupportedCultures = supportedCultures,
        // UI strings that we have localized.
        SupportedUICultures = supportedCultures
    });
    #endregion
    #region Configure the HTTP request pipeline.


    // Configure the HTTP request pipeline.
    app.UseSerilogRequestLogging();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
    #endregion
}
catch (Exception ex)
{
    Log.Information($"Occurred an error on line 51 in the program.cs with message: {ex.Message} " +
      $"In line 53 class [program.cs]");
}