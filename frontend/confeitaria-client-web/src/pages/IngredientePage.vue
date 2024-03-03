<script setup lang="ts">
import { onMounted, ref } from "vue"
import { type IngredienteType } from "@/types/IngredienteType"
import { obterIngredientes } from "@/services/IngredienteService"
import Carregando from "../components/Carregando.vue"
import DetalhesIngrediente from "@/components/DetalhesIngrediente.vue"
import ListaIngredientes from "../components/ListaIngredientes.vue"
import type { DetalhesOptions } from "@/types/Options/DetalhesOptions"

let detalhesOptions = ref<DetalhesOptions>({
  abrirModal: false,
  ingredienteId: 0,
})
let ingredientes = ref<IngredienteType[] | void>([])
let carregando = ref<boolean>(false)

const obterListaIngredientes = async () => {
  carregando.value = true
  ingredientes.value = await obterIngredientes()
    .then((data) => data)
    .catch((erro) => {
      carregando.value = false
      console.log(erro)
    })
    .finally(() => (carregando.value = false))
}

const abrirModalDetalhes = (ingredienteId: number) => {
  detalhesOptions.value.abrirModal = true
  detalhesOptions.value.ingredienteId = ingredienteId
}

const fecharModalDetalhes = () => {
  detalhesOptions.value.abrirModal = false
}

onMounted(async () => {
  await obterListaIngredientes()
})
</script>

<template>
  <Carregando v-if="carregando" texto="Carregando ingredientes..." />

  <ListaIngredientes
    @abrir-detalhes="abrirModalDetalhes"
    :carregando="carregando"
    :ingredientes="ingredientes"
  />

  <DetalhesIngrediente
    v-if="detalhesOptions.abrirModal"
    @fechar-detalhes="fecharModalDetalhes"
    :detalhesOptions="detalhesOptions"
  ></DetalhesIngrediente>
</template>
