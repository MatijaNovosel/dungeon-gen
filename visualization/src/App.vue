<template>
  <img alt="Vue logo" src="./assets/logo.png" />
</template>

<script>
import axios from "axios";

export default {
  name: "App",
  setup() {
    const url = "http://localhost:6000";

    const res = axios.get(url, {
      params: {}
    });
  }
};
</script>
