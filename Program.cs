using System.Numerics;

var app = WebApplication.CreateBuilder(args).Build();

app.MapGet("/safarahmed11_gmail_com", (string? x, string? y) =>
{
    if (!BigInteger.TryParse(x, out var a) ||
        !BigInteger.TryParse(y, out var b) ||
        a <= 0 || b <= 0)
        return Results.Text("NaN");

    var g = BigInteger.GreatestCommonDivisor(a, b);
    return Results.Text((a / g * b).ToString());
});

app.Run();