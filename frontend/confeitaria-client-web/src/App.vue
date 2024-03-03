<script setup lang="ts">
import { RouterView } from "vue-router"
import Cabecalho from "./components/Cabecalho.vue"
import Menu from "./components/Menu.vue"
import { ref } from "vue"

let aberto = ref<boolean>(false)

const toggleMenu = () => {
  aberto.value = !aberto.value
}
</script>

<template>
  <v-app theme="dark">
    <Menu :aberto="aberto" @abrir-menu="toggleMenu"></Menu>
    <Cabecalho @abrir-menu="toggleMenu"></Cabecalho>
    <v-main>
      <v-container>
        <RouterView />
      </v-container>
    </v-main>
  </v-app>
</template>
