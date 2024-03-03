<script setup lang="ts">
import { computed, onMounted, ref } from "vue"
import type { DetalhesOptions } from "@/types/Options/DetalhesOptions"
import type { IngredienteType } from "@/types/IngredienteType"
import {
  UnidadeMedidaEnum,
  obterTextoUnidadeMedida,
} from "@/types/UnidadeMedidaEnum"

const modalAberto = ref<boolean>(false)
const habilitarEdicao = ref<boolean>(false)

const idIngrediente = ref<number>()
const nomeIngrediente = ref<string>()
const unidadeMedidaIngrediente = ref<string>()

const abrirModal = computed(() => modalAberto.value)

const props = defineProps<{
  detalhesOptions: DetalhesOptions
}>()

const ingredienteMock: IngredienteType = {
  id: 1,
  nome: "Farinha de Trigo",
  unidadeMedida: UnidadeMedidaEnum.Grama,
}

onMounted(() => {
  modalAberto.value = props.detalhesOptions.abrirModal

  obterDetalhesIngrediente()
})

const obterDetalhesIngrediente = () => {
  idIngrediente.value = ingredienteMock.id
  nomeIngrediente.value = ingredienteMock.nome
  unidadeMedidaIngrediente.value = obterTextoUnidadeMedida(
    ingredienteMock.unidadeMedida
  )
}
</script>

<template>
  <v-dialog v-model="abrirModal" max-width="500px">
    <v-card title="Detalhes do Ingrediente">
      <v-card-text>
        <v-row dense>
          <v-col cols="12" md="4" sm="6">
            <v-text-field
              center-affix
              :disabled="!habilitarEdicao"
              label="Nome"
              v-model="nomeIngrediente"
            ></v-text-field>
          </v-col>

          <v-col cols="12" md="4" sm="6">
            <v-text-field
              :disabled="!habilitarEdicao"
              label="Unidade de Medida"
              v-model="unidadeMedidaIngrediente"
            ></v-text-field>
          </v-col>
        </v-row>

        <!-- <small class="text-caption text-medium-emphasis"
          >*indicates required field</small
        > -->
      </v-card-text>

      <v-divider></v-divider>

      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn
          text="Editar"
          variant="plain"
          @click="habilitarEdicao = !habilitarEdicao"
        ></v-btn>
        <v-btn
          text="Fechar"
          variant="plain"
          @click="$emit('fecharDetalhes')"
        ></v-btn>
        <!-- <v-btn
          color="primary"
          text="Save"
          variant="tonal"
          @click="console.log('SALVAR')"
        ></v-btn> -->
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>
