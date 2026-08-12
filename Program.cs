using System.Numerics;

var b = WebApplication.CreateBuilder(args);
b.Configuration.Sources.Clear();
var app = b.Build();

app.MapGet("/safarahmed11_gmail_com", (HttpRequest r) =>
{
    var x = r.Query["x"].ToString();
    var y = r.Query["y"].ToString();

    if (!Natural(x) || !Natural(y))
        return Results.Text("NaN");

    var a = BigInteger.Parse(x);
    var c = BigInteger.Parse(y);
    var g = BigInteger.GreatestCommonDivisor(a, c);

    return Results.Text((a / g * c).ToString());
});

static bool Natural(string s)
{
    if (s.Length == 0)
        return false;

    foreach (var c in s)
        if (c < '0' || c > '9')
            return false;

    return s.TrimStart('0').Length > 0;
}

app.Run();