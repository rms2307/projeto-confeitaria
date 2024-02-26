<script setup lang="ts">
defineEmits(["abrirMenu"])

const props = defineProps<{
  aberto: boolean
}>()
</script>

<template>
  <v-navigation-drawer temporary v-model="props.aberto">
    <v-list>
      <v-list-item
        @click="$emit('abrirMenu', false)"
        link
        to="/"
        prepend-icon="mdi-folder"
        >Confeitaria App</v-list-item
      >
    </v-list>
    <v-divider></v-divider>
    <v-list>
      <v-list-item
        @click="$emit('abrirMenu', false)"
        link
        to="/ingredientes"
        prepend-icon="mdi-account"
        >Ingredientes</v-list-item
      >
    </v-list>
  </v-navigation-drawer>
</template>
