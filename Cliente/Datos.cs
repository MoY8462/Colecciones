using System;

namespace Cliente
{
    public class Datos
    {
        private string nombre;
        private byte edad;
        private bool moroso;

        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        public bool Moroso { get => moroso; set => moroso = value; }
    }
}
