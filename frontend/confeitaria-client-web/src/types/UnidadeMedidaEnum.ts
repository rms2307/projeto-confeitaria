export enum UnidadeMedidaEnum {
  Grama,
  Unidade,
  Litro,
}

export function obterTextoUnidadeMedida(valor: UnidadeMedidaEnum): string {
  switch (valor) {
    case UnidadeMedidaEnum.Grama:
      return "Grama"
    case UnidadeMedidaEnum.Unidade:
      return "Unidade"
    case UnidadeMedidaEnum.Litro:
      return "Litro"
    default:
      return "Desconhecida"
  }
}
