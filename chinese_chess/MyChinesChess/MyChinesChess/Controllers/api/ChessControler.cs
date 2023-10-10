using Azure.Core.Serialization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyChinesChess.Models;
using System.Text.Json;

namespace MyChinesChess.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChessControler : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ChessControler(IWebHostEnvironment webHostEnvironment) {

           _webHostEnvironment = webHostEnvironment;



        }
        [HttpGet]
        [Route("loadChessBroad")]
        public IActionResult getChessBroad()
        {
            string contentRootPath = _webHostEnvironment.ContentRootPath;


            string chessJson = System.IO.File.ReadAllText(Path.Combine(contentRootPath + "\\Data\\ChessJson.txt"));

            List<ChessNode> chessNode = JsonSerializer.Deserialize<List<ChessNode>>(chessJson);
            List<List<PointerModel>> maxtrix = new List<List<PointerModel>>();

            for (int i = 0; i < 10; i++)
            {
                int top = 43 + i * 86;
                List<PointerModel> pointers = new List<PointerModel>();
                for (int j = 0; i < 9; j++)
                {
                    int left = 118 + j * 86;

                    PointerModel pointer = new PointerModel();

                    pointer.top = top;
                    pointer.left = left;
                    pointer.id = "";

                    ChessNode chess = chessNode.Where(s => s.top == top && s.left == left).FirstOrDefault();
                    if (chess != null)
                    {
                        pointer.id = chess.id;
                    }

                    pointers.Add(pointer);
                }
                maxtrix.Add(pointers);
            }
            return Ok(new { status = true, message = "", maxtrix = maxtrix, chessNode = chessNode});
        }

    }
}
