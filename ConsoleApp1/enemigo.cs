using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaVideoJuego
{
    class CaracteristicasDelEnemigo
    {
        //Propiedades * caracteristicas enemigo
        public string PosicionEnYDelEnemigo { get; set; }
        public string PosicionEnXDelEnemigo { get; set; }
        public string Explotar { get; set; }
        public string Moverse { get; set; }
        public string Disparar { get; set; }


        private string _puntos;
        public string Puntos
        {
            get
            {
                return _puntos;
            }
            set
            {
                if (value.Length < 100)
                {
                    _puntos = "El enemigo deberia dar mas de 100 puntos";
                }
                else
                {
                    _puntos = "El enemigo te dio mas de 100 puntos";
                }
            }
        }

    }
}
