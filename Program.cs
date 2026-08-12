using System.Numerics;

var b = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    EnvironmentName = "Production"
});

b.Configuration.Sources.Clear();

var app = b.Build();

app.MapGet("/safarahmed11_gmail_com", (string? x, string? y) =>
{
    if (!BigInteger.TryParse(x, out var a) ||
        !BigInteger.TryParse(y, out var c) ||
        a <= 0 || c <= 0)
        return Results.Text("NaN");

    var g = BigInteger.GreatestCommonDivisor(a, c);
    return Results.Text((a / g * c).ToString());
});

app.Run();