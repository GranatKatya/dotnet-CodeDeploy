var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/roll", () =>
{
    var random = new Random();
    var roll1 = random.Next(1, 7);
    var roll2 = random.Next(1, 7);
    return new int[] { roll1, roll2};
});

app.Run();


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
