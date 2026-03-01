var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

// 1️⃣ Enforce HTTPS
app.UseHttpsRedirection();

// 2️⃣ Global Error Handling
app.UseExceptionHandler("/Error");

// 3️⃣ Logging Middleware
app.Use(async (context, next) =>
{
    Console.WriteLine($"Incoming Request: {context.Request.Method} {context.Request.Path}");

    await next();

    Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
});

// 4️⃣ Content Security Policy (CSP)
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy",
        "default-src 'self'; script-src 'self'; style-src 'self';");

    await next();
});

// 5️⃣ Serve Static Files
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
