using DNV.Model.FigureCube;
using DNV.Service.Procedures.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DNV.API.Controllers
{
    public class FigureController : Controller
    {
        public IActionResult Index()
        {
            return View();        
        }


        [HttpPost]
        [Route ("GetFigure")]
        public string GetFigure(FigureCube fdto) 
        {
            return "Ok";
        }


        [HttpGet]
        [Route("CollidFigure")]
        public string CollidFigure(FigureCubeDTO fdto1, FigureCubeDTO fdto2)
        {   
            
            return new DNV.Service.Procedures.FigureCube.FigureCube().CollidTwoCubes(fdto1, fdto2).ToString ();
        }

    }
}
