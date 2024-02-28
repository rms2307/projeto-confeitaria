<script setup lang="ts">
defineProps<{
  texto: string
}>()
</script>

<template>
  <v-progress-linear indeterminate></v-progress-linear>
  <v-layout class="align-center justify-center">
    <span class="text-center text-h6">{{ texto }}</span>
  </v-layout>
</template>
