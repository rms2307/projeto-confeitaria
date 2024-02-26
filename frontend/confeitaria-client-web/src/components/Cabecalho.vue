<script setup lang="ts">
defineEmits(["abrirMenu"])
</script>

<template>
  <v-app-bar flat class="border-b">
    <v-app-bar-nav-icon
      @click="$emit('abrirMenu', false)"
    ></v-app-bar-nav-icon>
    <v-app-bar-title>Confeitaria APP</v-app-bar-title>
  </v-app-bar>
</template>
