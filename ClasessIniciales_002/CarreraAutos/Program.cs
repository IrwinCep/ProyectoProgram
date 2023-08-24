﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class AutoCarreras
    {
        public string modelo;
        public float peso;
        public int velocidad;
        static void Main(string[] args)
        {
            AutoCarreras ferrari = new AutoCarreras();
            ferrari.modelo = "Ferrari F150";
            ferrari.peso = 1.3f;
            ferrari.velocidad = 230;

            AutoCarreras mcLaren = new AutoCarreras();
            mcLaren.modelo = "McLaren A45S";
            mcLaren.peso = 0.98f;
            mcLaren.velocidad = 280;

            AutoCarreras Tsuru = new AutoCarreras();
            Tsuru.modelo = "Tsuru Tuneado";
            Tsuru.peso = 1.5f;
            Tsuru.velocidad = 290;

            PistaCarreras hmnosRodriguez = new PistaCarreras();
            hmnosRodriguez.nombre = "Autódromo Hermanos Rodríguez";
            hmnosRodriguez.longitud = 5.6f;//son km

            //mando a competir a los coches
            hmnosRodriguez.Competir(ferrari, mcLaren);
        }
    }
}
