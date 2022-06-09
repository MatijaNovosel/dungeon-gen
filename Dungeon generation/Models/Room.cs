using System;

namespace Dungeon_generation.Models {
  public class Room {
    public Coordinate TopLeft { get; set; }

    public Coordinate TopRight {
      get {
        return new Coordinate(TopLeft.X + Width, TopLeft.Y);
      }
    }

    public Coordinate BottomLeft {
      get {
        return new Coordinate(TopLeft.X, TopLeft.Y - Height);
      }
    }

    public Coordinate BottomRight {
      get {
        return new Coordinate(TopLeft.X + Width, TopLeft.Y - Height);
      }
    }

    public int Height { get; set; }
    public int Width { get; set; }

    public Room(int width, int height, Coordinate topLeft) {
      Width = width;
      Height = height;
      TopLeft = topLeft;
    }
  }
}
