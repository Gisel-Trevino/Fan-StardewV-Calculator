using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace SVprueba.Pages;

//props se refiere a crops, fue un error de dedo pero sigue refiriendose a crops
/*public class Cultivo{
    public int id { get; set; } = 0;
    public string name { get; set; } = string.Empty;
    public int cost { get; set; } = 0;
    public int sell { get; set; } = 0;
    public int sellSS { get; set; } = 0;
    public int sellGS { get; set; } = 0;
    public int sellIS { get; set; } = 0;
    public int time { get; set; } = 0;
    public string image { get; set; } = string.Empty;
}*/

public class IndexModel : PageModel
{
    public string Mensaje { get; set; } = string.Empty;
    public string FechaServidor { get; set; } = string.Empty;

    //public bool Mostrar {get; set; } = false;

    public void OnGet()
    {
        Mensaje = "Stardew Valley\nCalculator";
        FechaServidor = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        //Cargar();
        //Mostrar = false;
    }

    public void OnPost()
    {
        Mensaje = "Stardew Valley\nCalculator";

        //Cargar();
        /*ObjCultivoSel = ListaCultivos.FirstOrDefault(cultivo => cultivo.name == CultivoSeleccionado);
        if (ObjCultivoSel != null && ObjCultivoSel.cost > 0){
            var calculadora = new Calculadora();

            TotalCosto = calculadora.CostoTotal(ObjCultivoSel, CantidadSemillas);
        }*/
        //Mostrar = true;
    }

    /*private void Cargar()
    {
        string rutaArchivo = Path.Combine(_environment.WebRootPath, "data", "props.json");
        if (System.IO.File.Exists(rutaArchivo))
        {
            string jsonTexto = System.IO.File.ReadAllText(rutaArchivo);
            var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            ListaCultivos = JsonSerializer.Deserialize<List<Cultivo>>(jsonTexto, opciones) ?? new List<Cultivo>();
        }
    }*/

    private readonly IWebHostEnvironment _environment;

    /*[BindProperty]
    public int CantidadSemillas { get; set; } = 0;
    [BindProperty]
    public string CultivoSeleccionado { get; set; } = string.Empty;  
    public Cultivo? ObjCultivoSel {get; set;} = null;
    public int TotalCosto { get; set; } = 0;
    public List<Cultivo> ListaCultivos { get; set; } = new();
    public IndexModel(IWebHostEnvironment environment)
    {
        _environment = environment;
    }*/
}