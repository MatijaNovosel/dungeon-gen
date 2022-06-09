import constants from "../utils/constants";
import { Client } from "./../api/client";

class Generator {
  async generateRooms(
    attempts: number,
    containerWidth: number,
    containerHeight: number,
    minRoomWidth: number,
    maxRoomWidth: number,
    minRoomHeight: number,
    maxRoomHeight: number
  ) {
    const client = new Client(constants.API_URL);
    const data = await client.generateRooms(
      attempts,
      containerWidth,
      containerHeight,
      minRoomWidth,
      maxRoomWidth,
      minRoomHeight,
      maxRoomHeight
    );
    return data;
  }
}

export default Generator;
