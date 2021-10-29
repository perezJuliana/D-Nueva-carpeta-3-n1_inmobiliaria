using n1_inmobiliaria.source.mundo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1_inmobiliaria.sourse.mundo
{
    public class Inmobiliaria
    {
        //Atributos de relacion

        private Mansion mansion1;
        private Mansion mansion2;
        private Mansion mansion3;

        //metodo inicializador o constructor
        public void inicializar()
        {
            mansion1 = new Mansion();
            mansion1.inicializar();
            mansion2 = new Mansion();
            mansion2.inicializar();
            mansion3 = new Mansion();
            mansion3.inicializar();

        }

        //Metodo para dar la informacion de la mansion 1
        public Mansion darMancion1()
        {
            return mansion1;
        }
        //Metodo para dar la informacion de la mansion 2
        public Mansion darMancion2()
        {
            return mansion2;
        }
        //Metodo para dar la informacion de la mansion 3
        public Mansion darMancion3()
        {
            return mansion3;
        }
        //Metodo para actualizar la imformacion de la mansion 1
        public void actualizarDatosMancion1(int habitantes, int numParequeadero, int numEmpleados, int precio, int tamanio)
        {
            mansion1.modificarHabitantes(habitantes);
            mansion1.modificarNumeroParqueaderos(numParequeadero);
            mansion1.modificarNumeroEmpleados(numEmpleados);
            mansion1.modificarPrecio(precio);
            mansion1.modificarTamanio(tamanio);

        }
        //Metodo para actualizar la imformacion de la mansion 2
        public void actualizarDatosMancion2(int habitantes, int numParequeadero, int numEmpleados, int precio, int tamanio)
        {
            mansion2.modificarHabitantes(habitantes);
            mansion2.modificarNumeroParqueaderos(numParequeadero);
            mansion2.modificarNumeroEmpleados(numEmpleados);
            mansion2.modificarPrecio(precio);
            mansion2.modificarTamanio(tamanio);

        }
        //Metodo para actualizar la imformacion de la mansion 3 de la app
        public void actualizarDatosMancion3(int habitantes, int numParequeadero, int numEmpleados, int precio, int tamanio)
        {
            mansion3.modificarHabitantes(habitantes);
            mansion3.modificarNumeroParqueaderos(numParequeadero);
            mansion3.modificarNumeroEmpleados(numEmpleados);
            mansion3.modificarPrecio(precio);
            mansion3.modificarTamanio(tamanio);

        }
        public double calcularCostoAdministrativo()
        {
            double sumaLimpieza = mansion1.calcularCostoLimpieza() + mansion2.calcularCostoLimpieza() + mansion3.calcularCostoLimpieza();
            double porcentajeLimpieza = (sumaLimpieza * 25) / 100;
            double totalSumaSeguridad = mansion1.calcularCostoSeguridad() + mansion2.calcularCostoSeguridad() + mansion3.calcularCostoSeguridad();
            double porcentajeSeguridad = (totalSumaSeguridad * 10) / 100;
            double costoAdministrativoTotal = porcentajeLimpieza + porcentajeSeguridad;
            return costoAdministrativoTotal;
        }
        public double calcularCostoPromedioServicios()
        {
            double totalCostoPromedio = (mansion1.calcularCostoServicios() + mansion2.calcularCostoServicios() + mansion3.calcularCostoServicios()) / 3;
            return totalCostoPromedio;
        }

    }
}
