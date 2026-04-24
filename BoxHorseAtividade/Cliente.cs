using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxHorseAtividade
{
    internal class Cliente
    {
        public string NomeCliente { get; set; }
        public string TelCliente { get; set; }
        public string NomePetCliente { get; set; }

        public Cliente( string nomeCliente,  string telCliente, string nomePetCliente)
        {
            NomeCliente = nomeCliente;
            TelCliente = telCliente;
            NomePetCliente = nomePetCliente;

        }
    }
}
