using System.Numerics;

var app = WebApplication.CreateBuilder(args).Build();

app.MapGet("/safarahmed11_gmail_com", (HttpRequest r) =>
{
    var x = r.Query["x"].ToString();
    var y = r.Query["y"].ToString();

    if (!Natural(x) || !Natural(y))
        return Results.Text("NaN");

    var a = BigInteger.Parse(x);
    var b = BigInteger.Parse(y);
    var g = BigInteger.GreatestCommonDivisor(a, b);

    return Results.Text((a / g * b).ToString());
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