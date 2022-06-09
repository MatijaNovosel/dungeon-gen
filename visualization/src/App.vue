<template>
  <div id="center">
    <button @click="generateRooms">Generate rooms</button>
  </div>
</template>

<script>
import Generator from "./services/generator";

export default {
  name: "App",
  setup() {
    const generator = new Generator();

    const generateRooms = async () => {
      const rooms = await generator.generateRooms(200, 800, 600, 8, 12, 8, 12);
      console.log(rooms);
    };

    return {
      generateRooms
    };
  }
};
</script>

<style>
#center {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}
</style>
