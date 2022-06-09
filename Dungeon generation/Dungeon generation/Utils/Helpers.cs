using System;
using Dungeon_generation.Models;

namespace Dungeon_generation.Utils {
  public class Helpers {
    public static bool roomsOverlap(Room a, Room b) {
      if (a.TopLeft.X > b.BottomRight.X || b.TopLeft.X > a.BottomRight.X) {
        return false;
      }

      if (a.BottomRight.Y > b.TopLeft.Y || b.BottomRight.Y > a.TopLeft.Y) {
        return false;
      }

      return true;
    }

    public static int randInt(int min, int max) {
      Random rand = new Random();
      return rand.Next(min, max);
    }
  }
}
