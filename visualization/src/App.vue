<template>
  <div id="center">
    <canvas :width="canvasWidth" :height="canvasHeight" ref="canvas" />
    <button id="generate-room-btn" @click="drawRooms">Generate rooms</button>
  </div>
</template>

<script lang="ts">
import { defineComponent, onMounted, ref } from "vue";
import { Room } from "./api/client";
import Generator from "./services/generator";

export default defineComponent({
  name: "App",
  setup() {
    const generator = new Generator();
    const canvas = ref<HTMLCanvasElement | null>(null);
    const canvasWidth = 800;
    const canvasHeight = 600;

    const getCanvasContext = () => {
      const canvasVal = canvas.value;
      if (canvasVal) {
        const ctx = canvasVal.getContext("2d");
        if (ctx) {
          return ctx;
        }
      }
      return null;
    };

    const generateRooms = async (): Promise<Room[]> => {
      const rooms = await generator.generateRooms(
        50,
        canvasWidth,
        canvasHeight,
        28,
        42,
        36,
        42
      );
      return rooms;
    };

    const drawRooms = async () => {
      const ctx = getCanvasContext();
      if (ctx) {
        ctx.fillStyle = "black";
        ctx.fillRect(0, 0, canvasWidth, canvasHeight);
        const rooms = await generateRooms();
        rooms.forEach((room) => {
          ctx.fillStyle = "white";
          ctx.fillRect(
            room.topLeft?.x as number,
            room.topLeft?.y as number,
            room.width as number,
            room.height as number
          );
        });
      }
    };

    onMounted(() => {
      const ctx = getCanvasContext();
      if (ctx) {
        ctx.fillRect(0, 0, canvasWidth, canvasHeight);
      }
    });

    return {
      generateRooms,
      drawRooms,
      canvasWidth,
      canvasHeight,
      canvas
    };
  }
});
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-top: 60px;
}

#center {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  text-align: center;
  justify-content: center;
  display: flex;
  flex-direction: column;
}

#generate-room-btn {
  margin-top: 10px;
}

canvas {
  border-radius: 8px;
}
</style>
