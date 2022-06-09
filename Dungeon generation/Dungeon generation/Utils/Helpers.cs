using System;
using Dungeon_generation.Models;

namespace Dungeon_generation.Utils {
  public class Helpers {
    bool roomsOverlap(Room a, Room b) {
      if (a.TopLeft.X > b.BottomRight.X || b.TopLeft.X > a.BottomRight.X) {
        return false;
      }

      if (a.BottomRight.Y > b.TopLeft.Y || b.BottomRight.Y > a.TopLeft.Y) {
        return false;
      }

      return true;
    }
  }
}
