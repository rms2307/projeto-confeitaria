<script setup lang="ts">
import { computed, onMounted, ref } from "vue"
import type { DetalhesOptions } from "@/types/Options/DetalhesOptions"
import type { IngredienteType } from "@/types/IngredienteType"
import { obterIngrediente } from "@/services/IngredienteService"
import { UnidadeMedidaEnum } from "@/types/UnidadeMedidaEnum"

const props = defineProps<{
  detalhesOptions: DetalhesOptions
}>()

const emit = defineEmits(["fecharDetalhes"])

const modalAberto = ref<boolean>(false)
const habilitarEdicao = ref<boolean>(false)
const carregando = ref<boolean>(false)

const nomeIngrediente = ref<string>()
const unidadeMedidaIngrediente = ref<UnidadeMedidaEnum>()

const abrirModal = computed(() => modalAberto.value)

onMounted(() => {
  modalAberto.value = props.detalhesOptions.abrirModal

  obterDetalhesIngrediente()
})

const obterDetalhesIngrediente = async () => {
  carregando.value = true

  const ingrediente: IngredienteType | undefined | void =
    await obterIngrediente(props.detalhesOptions.ingredienteId)
      .then((data) => data)
      .catch((erro) => {
        carregando.value = false
        console.error(erro)
      })

  nomeIngrediente.value = ingrediente?.nome
  unidadeMedidaIngrediente.value = ingrediente?.unidadeMedida

  carregando.value = false
}

const salvarIngrediente = async (
  nome: string | undefined,
  unidadeMedida: string | undefined
) => {
  carregando.value = true

  console.log("Salvar", nome)
  console.log("Salvar", unidadeMedida)
  emit("fecharDetalhes")
  carregando.value = false
}

const removerIngrediente = async () => {
  carregando.value = true

  console.log("Remover", props.detalhesOptions.ingredienteId)
  
  emit("fecharDetalhes")
  carregando.value = false
}
</script>

<template>
  <v-dialog v-model="abrirModal" max-width="500px">
    <v-card title="Detalhes do Ingrediente">
      <v-card-text>
        <v-row dense>
          <v-col cols="12" md="6" sm="6">
            <v-text-field
              center-affix
              :disabled="!habilitarEdicao"
              label="Nome"
              v-model="nomeIngrediente"
            ></v-text-field>
          </v-col>

          <v-col cols="12" md="6" sm="6">
            <v-select
              :disabled="!habilitarEdicao"
              v-model="unidadeMedidaIngrediente"
              type="enum"
              label="Unidade de Medida"
              :items="[
                UnidadeMedidaEnum.Grama,
                UnidadeMedidaEnum.Litro,
                UnidadeMedidaEnum.Unidade,
              ]"
            ></v-select>
          </v-col>
        </v-row>

        <!-- <small class="text-caption text-medium-emphasis"
          >*indicates required field</small
        > -->
      </v-card-text>

      <v-divider></v-divider>

      <v-card-actions>
        <v-spacer></v-spacer>
        <div v-if="!habilitarEdicao">
          <v-btn
            text="Fechar"
            variant="plain"
            @click="$emit('fecharDetalhes')"
          ></v-btn>

          <v-btn
            color="primary"
            text="Editar"
            variant="tonal"
            @click="habilitarEdicao = !habilitarEdicao"
          ></v-btn>
        </div>
        <div v-else>
          <v-btn
            text="Cancelar"
            variant="plain"
            @click="habilitarEdicao = !habilitarEdicao"
          ></v-btn>

          <v-btn
            color="#F44336"
            text="Remover"
            variant="tonal"
            @click="removerIngrediente"
          ></v-btn>

          <v-btn
            text="Salvar"
            color="primary"
            variant="tonal"
            :loading="carregando"
            @click="
              salvarIngrediente(nomeIngrediente, unidadeMedidaIngrediente)
            "
          ></v-btn>
        </div>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>
