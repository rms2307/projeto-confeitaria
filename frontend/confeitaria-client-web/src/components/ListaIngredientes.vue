<script setup lang="ts">
import type { IngredienteType } from '@/types/IngredienteType';

defineEmits(["abrirDetalhes"])

defineProps<{ 
	carregando: boolean;
	ingredientes: IngredienteType[] | void;
}>()
</script>

<template>
	<v-list v-if="!carregando">
	    <v-list-item
	      v-for="ingrediente in ingredientes"
	      :title="ingrediente.nome"
	      class="border-b"
	      link
	      @click="$emit('abrirDetalhes', ingrediente.id)"
	    >
	    </v-list-item>
	  </v-list>
</template>
