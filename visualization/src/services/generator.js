import axios from "axios";
import constants from "../utils/constants";

class Generator {
  async generateRooms(
    attempts,
    containerWidth,
    containerHeight,
    minRoomWidth,
    maxRoomWidth,
    minRoomHeight,
    maxRoomHeight
  ) {
    const { data } = await axios.get(`${constants.API_URL}/generate-rooms`, {
      params: {
        attempts,
        containerWidth,
        containerHeight,
        minRoomWidth,
        maxRoomWidth,
        minRoomHeight,
        maxRoomHeight
      }
    });
    return data;
  }
}

export default Generator;
