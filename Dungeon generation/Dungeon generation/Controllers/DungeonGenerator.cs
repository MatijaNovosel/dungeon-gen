using Microsoft.AspNetCore.Mvc;
using Dungeon_generation.Models;
using Dungeon_generation.Generator;

namespace Dungeon_generation.Controllers {
  [ApiController]
  [Route("[controller]")]
  public class DungeonGeneratorController : ControllerBase {
    private readonly IGenerator _generator;

    public DungeonGeneratorController(IGenerator generator) {
      _generator = generator;
    }

    [HttpGet("generate-rooms")]
    public List<Room> Get(
      int attempts,
      int containerWidth,
      int containerHeight,
      int minRoomWidth,
      int maxRoomWidth,
      int minRoomHeight,
      int maxRoomHeight
    ) {
      return _generator.generateRooms(
        attempts,
        containerWidth,
        containerHeight,
        minRoomWidth,
        maxRoomWidth,
        minRoomHeight,
        maxRoomHeight
      );
    }
  }
}