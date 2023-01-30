using DNV.Service.Procedures.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DNV.UI.Controllers
{
    public class FigureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public string GetFigure(FigureCubeDTO fdto)
        {
            return "Ok";
        }

        public string CollidFigure(FigureCubeDTO fdto1, FigureCubeDTO fdto2)
        {
            //TODO 
            return new DNV.Service.Procedures.FigureCube.FigureCube().CollidTwoCubes(fdto1, fdto2).ToString();            
        }

    }
}
