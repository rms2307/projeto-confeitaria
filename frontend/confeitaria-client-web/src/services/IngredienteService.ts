import type { IIngredienteType } from "@/types/IngredienteType"
import { UnidadeMedidaEnum } from "@/types/UnidadeMedidaEnum"

export async function obterIngredientes(): Promise<IIngredienteType[]> {
  // TODO: Implementar chamada para a API
  const ingredientes: IIngredienteType[] = [
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
  ]
  return ingredientes
}
