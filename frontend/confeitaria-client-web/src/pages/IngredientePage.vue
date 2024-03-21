<script setup lang="ts">
import { onMounted, ref } from "vue"
import { type IngredienteType } from "@/types/IngredienteType"
import { obterIngredientes } from "@/services/IngredienteService"
import Carregando from "../components/Carregando.vue"
import DetalhesIngrediente from "@/components/DetalhesIngrediente.vue"
import ListaIngredientes from "../components/ListaIngredientes.vue"
import type { DetalhesOptions } from "@/types/Options/DetalhesOptions"

const detalhesOptions = ref<DetalhesOptions>({
  abrirModal: false,
  ingredienteId: 0,
})
const ingredientes = ref<IngredienteType[] | void>([])
const carregando = ref<boolean>(false)

const obterListaIngredientes = async () => {
  carregando.value = true

  ingredientes.value = await obterIngredientes()
    .then((data) => data)
    .catch((erro) => {
      carregando.value = false
      console.error(erro)
    })

  carregando.value = false
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
<span>Adicionar novo ingrediente</span>
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
