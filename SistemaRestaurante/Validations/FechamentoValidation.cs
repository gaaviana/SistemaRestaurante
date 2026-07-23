using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.Utils;
using System.Collections.Generic;

namespace SistemaRestaurante.Validations
{
    public class FechamentoValidation
    {
        public static bool Validar(FechamentoCaixa fechamento)
        {
            bool fechamentoExistente = BancoFake.fechamentos.Any(f => f.Data.Date == fechamento.Data.Date);

            if (fechamentoExistente)
            {
                Mensagens.Erro("Já existe um fechamento para essa Data.");
                return false;
            }

            if(fechamento.QuantidadeVendas <= 0)
            {
                Mensagens.Erro("Não existe registros nessa data");
                return false;
            }

            Mensagens.Sucesso("Fechamento gerado com sucesso!");
            return true;
        }

    }
}