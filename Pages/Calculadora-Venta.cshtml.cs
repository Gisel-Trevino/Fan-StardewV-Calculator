using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace SVprueba.Pages;

public class CalculadoraVentaModel : PageModel
{
    private readonly IWebHostEnvironment _environment;

    public string Mensaje { get; set; } = string.Empty;

    public bool Mostrar {get; set; } = false;

    public void OnGet()
    {
        ViewData["Title"] = "Stardew Valley Calculator";
        Mensaje = "Stardew Valley\nCalculator";

        Mostrar= false;
        Cargar();
    }

    public void OnPost()
    {
        ViewData["Title"] = "Stardew Valley Calculator";
        Mensaje = "Stardew Valley\nCalculator";

        Mostrar= true;
        Cargar();
    }

    private void Cargar()
    {
        string rutaArchivo = Path.Combine(_environment.WebRootPath, "data", "props.json");

        if (System.IO.File.Exists(rutaArchivo))
        {
            string jsonTexto = System.IO.File.ReadAllText(rutaArchivo);
            
            var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            ListaCultivos = JsonSerializer.Deserialize<List<Cultivo>>(jsonTexto, opciones) ?? new List<Cultivo>();
        }
    }

    [BindProperty]
    public string CultivoSeleccionado { get; set; } = string.Empty;
    
    public Cultivo? ObjCultivoSel {get; set;} = null;

    public List<Cultivo> ListaCultivos { get; set; } = new();

    public CalculadoraVentaModel(IWebHostEnvironment environment)
    {
        _environment = environment;
    }
}