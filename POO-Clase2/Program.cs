﻿using POO_Clase2.Ejercicio_1;
using POO_Clase2.Ejercicio_2;
using POO_Clase2.Ejercicio_3;

namespace POO_Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Configurar el metodo Emitir sonido para que cada tipo de animal haga un sonido diferente
            // el metodo emitir sonido no devuelve nada (void), imprimir en consola el "sonido"


            Perro perro = new Perro() { Edad = 2, Nombre = "Buddy"};

            Gato gato = new Gato() { Edad = 5, Nombre = "Michi" };

            perro.EmitirSonido();

            gato.EmitirSonido();
            #endregion

            #region Ejercicio 2 
            // Agregar la propiedad "Peso" unicamente para las notebooks 
            // Agregar la propiedad "Refactorizada" que debe ser un booleano unicamente para las PcEscritorio
            // Instanciar una notebook y una pcEscritorio
            // Imprimir por pantalla las propiedades de cada uno

            Notebook notebook = new Notebook()
            {
                Marca = "Lenovo",
                Peso = "2kg"

            };

            PcEscritorio pcEscritorio = new PcEscritorio()
            {
                Marca = "Asus",
                Refactorizada = false
            };

            Console.WriteLine("La notebook de marca: " + notebook.Marca + " tiene un peso de " + notebook.Peso);
            Console.WriteLine("La pc de marca: " + pcEscritorio.Marca + " ¿fue refactorizada? " + pcEscritorio.Refactorizada);

            #endregion


            #region Ejercicio 3

            // Crear la clase "FiguraGeometrica" la cual debe ser abstracta y tener 2 metodos, uno para calcular el area y el otro el perimetro
            // Crear dos clases "Circulo" y "Rectangulo" que deben heredar de "FiguraGeometrica"
            // Implementar los metodos para que cada figura calcule el area y el perimetro como corresponda
            // Instanciar las clases e imprimir los valores del area y el perimetro para cada figura
            // Mostrar los resultados por consola

            Circulo circulo = new Circulo()
            {
                Radio = 1
            };

            Console.WriteLine("El area del circulo es: " + circulo.calcularArea());
            Console.WriteLine("El perimetro del circulo es: " + circulo.calcularPerimetro());

            Rectangulo rectangulo = new Rectangulo()
            {
                Lado1 = 2,
                Lado2 = 3,
            };

            Console.WriteLine("El area del rectangulo es: " + rectangulo.calcularArea());
            Console.WriteLine("El perimetro del rectangulo es: " + rectangulo.calcularPerimetro());
            #endregion
        }
    }
}