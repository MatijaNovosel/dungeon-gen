<template>
  <div id="center">
    <button @click="generateRooms">Generate rooms</button>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import Generator from "./services/generator";

export default defineComponent({
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
});
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

#center {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
}
</style>
