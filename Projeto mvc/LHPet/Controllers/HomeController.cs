using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        // instancia do tipo cliente 
        Cliente cliente1 = new Cliente(01, "arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "madruga");
        Cliente cliente2 = new Cliente(02, "Willian Henry Gates III", "039.618.250-09", "bill@microsoft.com", "bug");
        Cliente cliente3 = new Cliente(03, "Ada lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "linus Torvalds", "933.622.400-03", "tovalds@osdl.org", "Pinguin");
        Cliente cliente5 = new Cliente(05, "Grace hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");
        
        // lista de clientes e atribuir os clientes 
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        
        ViewBag.listaClientes = listaClientes;

        // intancia do tipo fornecedor 
        Fornecedor fornecdor1 = new Fornecedor(01, "C# Pet S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecdor2 = new Fornecedor(02, "crtl alt Dog", "15.836.698/00011-57", "crtl@alt.dog.br");
        Fornecedor fornecdor3 = new Fornecedor(03, "Bootspet inc", "40.810.224/0001-83", "boot.pet@gatomania.us");
        Fornecedor fornecdor4 = new Fornecedor(04, "tik tok dog", "87.945.350/0001-09", "noismaniadia@tiktokdog.com");
        Fornecedor fornecdor5 = new Fornecedor(05, "Bifinho forever", "18.760.614/0001-37", "contato@ff.com");

        // lista de fornecedore e atribuir os fornecedores 
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecdor1);
        listaFornecedores.Add(fornecdor2);
        listaFornecedores.Add(fornecdor3);
        listaFornecedores.Add(fornecdor4);
        listaFornecedores.Add(fornecdor5);

        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
