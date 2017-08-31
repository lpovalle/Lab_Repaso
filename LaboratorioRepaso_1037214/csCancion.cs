using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioRepaso_1037214
{
    public enum cOrdenar {NOMBRE,TIEMPO}
    public enum cOrdenarD {ASC, DESC}

     public class csCancion : IComparable<csCancion>
    {
        public string Nombre = "";
        public string Artista = "";
        public double Tiempo = 0;
        public cOrdenar criterio;
        public cOrdenarD criterioD;

        public csCancion(string nombre,  string artista, double tiempo)
        {
            Nombre = nombre;
            Tiempo = tiempo;
            Artista = artista;
        }

        public int CompareTo(csCancion other)
        {
            if (this.criterioD == cOrdenarD.ASC)
            {
                if(this.criterio == cOrdenar.NOMBRE)
                {
                    return this.Nombre.CompareTo(other.Nombre);
                }
                else
                {
                    return this.Tiempo.CompareTo(other.Tiempo);
                }
            }
            else
            {
                if(this.criterio == cOrdenar.NOMBRE)
                {
                    return other.Nombre.CompareTo(this.Nombre);
                }
                else
                {
                    return other.Tiempo.CompareTo(this.Tiempo);
                }
            }

        }
    }
}
