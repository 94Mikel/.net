using _1.proyecto.Servicios;
using Portafolio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*
Hemos utilizado AddTransient para configurar nuestro repositorio IRepositorioProyectos
No todos los servicios son iguales
Servicios: Clases que tenemos registradas en el sistema de inyeccion de dependencias,
que podemos utilizar atraves de un constructor de una clase.

Lo servicios pueden variar por el tiempo de vida.
Algunos servicios viven mas que otros servicios.
En general hay 3 tipos de servicios:
    - Los transient (transitorio): Son los servicios que viven por menos tiempo.
    - scoped (delimitado): Son los servicios cuyo tiempo de vida vive delimitado por una petición http.
    - Singleton (único): Es el servicio que vive por mas tiempo. De echo vive para siempre.
    Solamente se renueva si la aplicación es reiniciada.

*/

builder.Services.AddTransient<IRepositorioProyectos, RepositorioProyectos>();
builder.Services.AddTransient<IServicioEmail, ServicioEmailSendGripd>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
