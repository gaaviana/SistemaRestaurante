using SistemaRestaurante.Models;
using SistemaRestaurante.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Validations
{
    public class ComandaValidation
    {
        public static bool Validar(Comanda comanda)
        {
            if(comanda.Tipo == null)
            {
                Mensagens.Erro("É necessario escolher um tipo");
                return false;
            }

            if(comanda.Numero == null)
            {
                Mensagens.Erro("É necessario escolher um numero para a comanda");
                return false;
            }

            if(comanda.Itens.Count <= 0)
            {
                Mensagens.Erro("é necessarioa adicionar pelo menos um item");
                return false;
            }

            return true;
        }
    }
}
