var builder = WebApplication.CreateBuilder(args);
//Servisler
//..
//..
//builder.Services.AddMvc(); //MVC yapýsýný servise eklenmesini temsil eder.
builder.Services.AddControllersWithViews();




var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapGet("/hakkimizda", () => "Burasý hakkýmýzda sayfasý");

//Yapýlacak istekler için URL rotasýný kullanýma aldýk.

app.UseRouting();

app.UseEndpoints(x =>
{
    x.MapDefaultControllerRoute(); //Projede eðer Controllers isimli bir klasör, bu klasör içerisinde HomeController isminde bir controller varsa ve bu controller içerisinde Index isminde metot bulunuyorsa, varsayýlan istek buraya yönlendirilir.

    //URL: localhost:{port}/ControllerAd/MetotAd
    //burda ilk karþýmýza çýkan yeri ayarlýyorsun?
});


app.Run();





