using System;
using System.Data;
using Dungeon_generation.Models;
using Dungeon_generation.Utils;

namespace Dungeon_generation.Generator {
  /// <summary>
  /// A class responsible for each step of the dungeon generation.
  /// </summary>
  public class Generator : IGenerator {
    /// <summary>
    /// Initial step: Generate rooms of variable width and height inside a boundary.
    /// </summary>
    public List<Room> generateRooms(
      int attempts,
      int containerWidth,
      int containerHeight,
      int minRoomWidth,
      int maxRoomWidth,
      int minRoomHeight,
      int maxRoomHeight
    ) {
      List<Room> rooms = new List<Room>();
      for (int i = 0; i < attempts; i++) {
        Room room = new Room(
          Helpers.randInt(minRoomWidth, maxRoomWidth),
          Helpers.randInt(minRoomHeight, maxRoomHeight),
          new Coordinate(
            Helpers.randInt(0, containerWidth),
            Helpers.randInt(0, containerHeight)
          )
        );
        /*
        
          To prevent infinite loops overlapping rooms are thrown away.
          In addition to those which are not within the boundaries of the container.

        */
        var isInsideBoundaries = Helpers.isInsideBoundaries(
          containerWidth,
          containerHeight,
          room
        );

        var anyOverlap = rooms.Any(r => Helpers.roomsOverlap(room, r));

        if (
          isInsideBoundaries &&
          !anyOverlap
        ) {
          rooms.Add(room);
        }
      }
      return rooms;
    }
  }
}
