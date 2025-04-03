var builder = WebApplication.CreateBuilder(args);
//Servisler
//..
//..
//builder.Services.AddMvc(); //MVC yap�s�n� servise eklenmesini temsil eder.
builder.Services.AddControllersWithViews();




var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapGet("/hakkimizda", () => "Buras� hakk�m�zda sayfas�");

//Yap�lacak istekler i�in URL rotas�n� kullan�ma ald�k.

app.UseRouting();

app.UseEndpoints(x =>
{
    x.MapDefaultControllerRoute(); //Projede e�er Controllers isimli bir klas�r, bu klas�r i�erisinde HomeController isminde bir controller varsa ve bu controller i�erisinde Index isminde metot bulunuyorsa, varsay�lan istek buraya y�nlendirilir.

    //URL: localhost:{port}/ControllerAd/MetotAd
    //burda ilk kar��m�za ��kan yeri ayarl�yorsun?
});


app.Run();





