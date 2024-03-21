import type { IngredienteType } from "@/types/IngredienteType"
import { UnidadeMedidaEnum } from "@/types/UnidadeMedidaEnum"
import axios, { type AxiosResponse } from "axios"

const BASE_URL = "https://localhost:7157"

export async function obterIngredientes(): Promise<IngredienteType[]> {
  try {
    const response: AxiosResponse<IngredienteType[]> = await axios.get<
      IngredienteType[]
    >(`${BASE_URL}/ingredientes`)

    return response.data
  } catch (error) {
    console.error("Erro ao listar ingredientes: ", error)
    throw error
  }
}

export async function obterIngrediente(
  ingredienteId: number
): Promise<IngredienteType | undefined> {
  // TODO: Implementar chamada para a API
  const ingredientesMock: IngredienteType[] = [
    { id: 1, nome: "Farinha de Trigo", unidadeMedida: UnidadeMedidaEnum.Grama },
    { id: 2, nome: "Ovo", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 3, nome: "Leite", unidadeMedida: UnidadeMedidaEnum.Litro },
    { id: 4, nome: "Açúcar", unidadeMedida: UnidadeMedidaEnum.Grama },
    { id: 5, nome: "Sal", unidadeMedida: UnidadeMedidaEnum.Grama },
    { id: 6, nome: "Óleo", unidadeMedida: UnidadeMedidaEnum.Litro },
    { id: 7, nome: "Cebola", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 8, nome: "Alho", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 9, nome: "Tomate", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 10, nome: "Pimentão", unidadeMedida: UnidadeMedidaEnum.Unidade },
    {
      id: 11,
      nome: "Farinha de Trigo",
      unidadeMedida: UnidadeMedidaEnum.Grama,
    },
    { id: 12, nome: "Ovo", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 13, nome: "Leite", unidadeMedida: UnidadeMedidaEnum.Litro },
    { id: 14, nome: "Açúcar", unidadeMedida: UnidadeMedidaEnum.Grama },
    { id: 15, nome: "Sal", unidadeMedida: UnidadeMedidaEnum.Grama },
    { id: 16, nome: "Óleo", unidadeMedida: UnidadeMedidaEnum.Litro },
    { id: 17, nome: "Cebola", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 18, nome: "Alho", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 19, nome: "Tomate", unidadeMedida: UnidadeMedidaEnum.Unidade },
    { id: 20, nome: "Pimentão", unidadeMedida: UnidadeMedidaEnum.Unidade },
  ]
  return ingredientesMock.find((i) => i.id === ingredienteId)
}
