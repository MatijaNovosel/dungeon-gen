using System;
using Dungeon_generation.Models;

namespace Dungeon_generation.Generator {
  public interface IGenerator {
    List<Room> generateRooms(
     int attempts,
     int containerWidth,
     int containerHeight,
     int minRoomWidth,
     int maxRoomWidth,
     int minRoomHeight,
     int maxRoomHeight
   );
  }
}
