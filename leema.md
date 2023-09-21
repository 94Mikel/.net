# 1 Proyecto. 
### Con ASP .NET CORE MVC realizaremos un portafolio

> # Definiciones
> - Portafolio:
> 	- Es una especie de landing page en el cual intentamos
> 	  mostrar nuestras habilidades al mundo.
> - Landing page:
> 	- Es una pagina simple en la cual mostramos un producto, una
> 	  persona...
> 

> # Aprenderemos
> - Controladores modelos y vistas MVC.
> - Layouts, vistas parciales
> - Codigo de raizor
> - Como enviar datos del contralador a la vista y como enviar datos de la
> vista al controlador.
> - Inyección de dependencias
> - ciclod e vida de los servicios.
> - I logger.
> - Realizaremos un simple formulario de contacto(los usuarios podran enviar
> un email a nosotros).


> # Que haremos
> - Crear un portafolio de aplicaciones.
> - Sera una pagina web con distintas partes.
> - Formulario.
> - Twilio. (Para enviar emails).

> # Que son
> - appsettings.json
>   - Nos permiten guardar datos de configuración que nuestro proyecto va a usar sin tener que mostrar esos datos de configuración en nuestro codigo C#.
>   - Se utiliza en el ambiente de producción.
> - appsettings.Development.json
>   - Se utiliza en el ambiente de desarrollo. En local.
> - Program.cs
>   - Se encuentra la pieza centrar de nuestro proyecto MVC.
>   - Para configurar los servicios de nuestra aplicación.
>   - También los midelwares.
> - Archivos vista .cshtml
>   - Convinación de c# con html.
>   - En este archivo puede haber codigo de c# convinado con el de html.

> # ViewBag
> Es un objeto el cual me va a permitir transmitir información desde el contralador hacia la vista.
> - Es dinámico, lo cual se puede utilizar cualquier propiedad sin problema.
> - Se declara el modelo en el controlador con ViewBag.(modelo).
>   - Este modelo es accesible solo en la vista que devolmemos en la funcion.
> - En el index se obtiene el data con @ ya que estamos en cshtml.
> - Para pasar de html a c# utilizamos el @.

> # Modelos fuertemente tipados
> Se declaran las variables con tipos(string, int...) en la vista con model.
> @Model con la M mayuscula sirve para acceder al valor del modelo.
> En el controlador pasamos por parametro el dato que queremos pasar al index. View("Index","el dato")

> # Recibiendo dos datos del controlador(clases)
> - Creamos la clase pesona en models.
> - Instanciamos el objeto persona en el controlador y lo pasamos por parametro al index.
> - Obtenemos el objeto persona en el index con @Model
>

> # Explorando Razor
> - En el archivo cshtml se combian codigo de html con codigo de c#.
> - El @ es sintaxis de Razor. Que se utiliza para trabajar con c# en cshtml.
> - ViewData es para enviar información del cshtml al layout.
> - Con blazor se pueden utilizar condicionantes if, bucles foreach... lo cual permite realizar una vista dinámica.


> # Vistas parciales
> Con las vistas parciales podemos tener vistas dentro de vistas.
> Podemos reutilizar contenido de interfaz de usuario en varias vistas.
> 