using Microsoft.AspNetCore.Mvc;

namespace Dungeon_generation.Controllers {
  [ApiController]
  [Route("[controller]")]
  public class DungeonGeneratorController : ControllerBase {
    public DungeonGeneratorController() {
      //
    }

    [HttpGet("generate-rooms")]
    public IEnumerable<int> Get() {
      return new List<int>();
    }
  }
}