using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP02___Alberto
{
    [Serializable]
    public class Voos
    {
        public Voos() { }
        public Voos(string cdvoo, string origem, string destino, DateTime horario, string compania, bool operando)
        {
            Cdvoo = cdvoo;
            Origem = origem;
            Destino = destino;
            Horario = horario;
            Compania = compania;
            Operando = operando;
        }
        public string Cdvoo { get; set; }
        public string Origem { get; set; }

        public string Destino { get; set; }

        public DateTime Horario { get; set; }
        public string Compania { get; set; }

        public bool Operando { get; set; }
    }
}
