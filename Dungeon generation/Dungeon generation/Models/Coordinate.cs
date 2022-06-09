using System;

namespace Dungeon_generation.Models {
  public class Coordinate {
    public int X { get; }
    public int Y { get; }

    public Coordinate(int x, int y) {
      X = x;
      Y = y;
    }
  }
}
