<script setup lang="ts">
import { onMounted, ref } from "vue"
import { type IngredienteType } from "@/types/IngredienteType"
import { obterIngredientes } from "@/services/IngredienteService"

let ingredientes = ref<IngredienteType[] | void>([])
let carregando = ref<boolean>(false)

const obterListaIngredientes = async () => {
  carregando.value = true
  ingredientes.value = await obterIngredientes()
    .then((data) => data)
    .catch((erro) => console.log(erro))
    .finally(() => (carregando.value = false))
}

onMounted(async () => {
  await obterListaIngredientes()
})
</script>

<template>
  <v-list>
    <v-list-item
      v-for="ingrediente in ingredientes"
      :title="ingrediente.nome"
      class="border-b"
      link
      @click="console.log(ingrediente.id)"
    >
    </v-list-item>
  </v-list>
</template>

<style scoped></style>
@/types/IngredienteType
