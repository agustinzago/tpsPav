﻿namespace TPS_PAV.Entities
{
    public class Categoria
    {
        public int IdCategoria { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}