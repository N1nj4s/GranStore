using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Categoria> categorias = [
            new() {Id = 1, Nome = "Playstation2"},
            new() {Id = 2, Nome = "Playstation3"},
            new() {Id = 3, Nome = "Playstation4"},
            new() {Id = 4, Nome = "Playstation5"},
            new() {Id = 5, Nome = "Xbox 360"},
            new() {Id = 6, Nome = "Xbox One"},
            new() {Id = 7, Nome = "Xbox Series S"},
            new() {Id = 8, Nome = "Xbox Series X"},

        ];

        List<Produto> produtos = new List<Produto>
        {
            new Produto {  Id = 1, Categoria = categorias[1], Nome = "gta san andreas ps2", Descricao = "Grand Theft Auto: San Andreas (GTA: San Andreas) é um jogo de ação e aventura desenvolvido pela Rockstar North e publicado pela Rockstar Games. Foi lançado originalmente em 2004 para PlayStation 2", ValorCusto = 199,ValorVenda = 188, QtdeEstoque = 20, Foto = "/img/GTASA.png"},
            new Produto {  Id = 2, Categoria = categorias[1], Nome = "Resident Evil 4 ps2", Descricao = "Resident Evil 4 é um jogo de ação e terror de sobrevivência desenvolvido e publicado pela Capcom. Lançado originalmente em 2005 para PlayStation 2, ele revolucionou a franquia Resident Evil ao introduzir uma jogabilidade mais voltada para a ação, mantendo ainda o clima sombrio e tenso característico da série.", ValorCusto = 249,ValorVenda = 229, QtdeEstoque = 10, Foto = "/img/RE4.png"},
            new Produto {  Id = 3, Categoria = categorias[1], Nome = "Scooby Doo! First Frights ps2", Descricao = "Scooby-Doo! First Frights é um jogo de ação e aventura baseado na famosa franquia Scooby-Doo, desenvolvido pela Torus Games e publicado pela Warner Bros. Interactive Entertainment. Foi lançado em 2009 para PlayStation 2", ValorCusto = 150,ValorVenda = 80, QtdeEstoque = 10, Foto = "/img/SCFF.png"},
        };

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
