using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1_inmobiliaria.source.mundo
{
    public class Mansion
    {
        //Atributos de la clase 
        private int habitantes;
        private int numParqueaderos;
        private int numEmpleados;
        private int precio;
        private int tamanio;

        //Metodo para inicializar los atributos,
        public void inicializar()
        {
            habitantes = 0;
            numParqueaderos = 0;
            numEmpleados = 0;
            precio = 0;
            tamanio = 0;
        }

        //Metodo para dar el numero de habitantes por mansion
        public int darHabitantes()
        {
            return habitantes;
        }
        //Metodo para dar el numero de empleados por mansion
        public int darEmpleados()
        {
            return numEmpleados;
        }

        //Metodo para dar el numero de parqueaderos por mancion
        public int darParqueadero()
        {
            return numParqueaderos;
        }

        //Metodo para dar el precio que tiene cada mansion
        public int darPrecio()
        {
            return precio;
        }

        //Metodo para dar el tamaño que tiene cada mansion 
        public int darTamanio()
        {
            return tamanio;
        }

        //Metodo para modificar el numero de los habitantes de las mansiones
        public void modificarHabitantes(int pHabitantes)
        {
            habitantes = pHabitantes;
        }

        //Metodo para modificar el numero de empleados de las mansiones
        public void modificarNumeroEmpleados(int pNumEmpleados)
        {
            numEmpleados = pNumEmpleados;
        }

        //Metodo para modificar el numero de parqueaderos de las manciones
        public void modificarNumeroParqueaderos(int pNumParqueaderos)
        {
            numEmpleados = pNumParqueaderos;
        }

        //Metodo para modificar el precio de las mansiones 
        public void modificarPrecio(int pPrecio)
        {
            precio = pPrecio;
        }

        //Metodo para modificar el tamaño de las manciones 
        public void modificarTamanio(int pTamanio)
        {
            tamanio = pTamanio;
        }

        //Metodo para calcular el costo de la limpieza de cada manciones
        public int calcularCostoLimpieza()
        {
            int costoLimpieza = (habitantes * 250) + (numEmpleados * 3000) + (tamanio * 500);
            return costoLimpieza;
        }

        //Metodo para calcular el costo de los servicios de cada mancion
        public double calcularCostoServicios()
        {
            int costoServicios = (habitantes * 5000) + (precio * 2 / 100);
            return costoServicios;
        }

        //Metodo para calcular el costo de la seguridad de las mansiones 
        public int calcularCostoSeguridad()
        {
            int costoSeguridad = (numParqueaderos * 450) + (tamanio * 500);
            return costoSeguridad;
        }
    }
}
