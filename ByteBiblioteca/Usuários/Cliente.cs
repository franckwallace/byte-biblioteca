using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBiblioteca.Usuários
{
    internal class Cliente : Usuario
    {
        public string LivrosEmprestados {  get; set; }
    }
}
