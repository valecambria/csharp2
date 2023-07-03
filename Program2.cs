namespace Ejercicios
{
    class Program2 
    {
        public static void Main()
        {
/*             Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            string apellido =  Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sabe programar? Si / No");
            string programa =  Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + " " + apellido + " tenes " + edad + " años y " + programa + " sabes programar"); */

        //* Anotando las caracteristicas principales de 2 objetos utilizando los tipos de datos 
        // *Coche
/*         const char puertas = 5;
        const char ruedas = 4;
        const string marca = "Peugeot";
        string ITVvigente = "Si"; */

        //* Mesa
/*         float peso = 12.50; //*Kilogramos
        float largo = 1.8; //*Metros
        string material = "Madera";
        string color = "Marron"; */

        //* EJERCICIO 3
/*         Console.WriteLine("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese un valor de 1 caracter");
        char val = Convert.ToChar(Console.ReadLine());

        if(num >= 18 && val == 'a'){
            Console.WriteLine("Ambas son verdaderas");
        } else if (num >= 18 || val == 'a'){
            Console.WriteLine("Una de las dos es verdadera");
        } else {
            Console.WriteLine("No se cumple ninguna de las 2");
        } */

    //*TABLA MULTIPLICAR
/*         Console.WriteLine("Ingrese el numero que quiera multiplicar");
        int i = 1;
        int num = Convert.ToInt32(Console.ReadLine());
        int result;
        while(i < 11){
            result = num * i;
            Console.WriteLine(num + " x " + i + " = " + result);
            i++;
        } */

        //*DO WHILE
/*         Console.WriteLine("Ingrese un numero");
        int contPositivo = 0;
        int contNegativo = 0;
        float num;
        do{
        num = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Ingrese 0 si desea terminar");
            if(num < 0){
                contNegativo++;
            }
            if(num > 0){
                contPositivo++;
            }
        } while(num != 0);
            Console.WriteLine("Cantidad de numeros negativos ingresados: " + contNegativo);
            Console.WriteLine("Cantidad de numeros positivos ingresados: " + contPositivo); */
    Console.Write("Ingresa el ancho: ");
        int ancho = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el alto: ");
        int alto = int.Parse(Console.ReadLine());

        Console.Write("Ingresa la cantidad de cuadrados o rectángulos a dibujar: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("¿Deseas que los rectángulos estén rellenos? (S/N): ");
        bool relleno = Console.ReadLine().ToUpper() == "S";

        for (int k = 0; k < cantidad; k++)
        {
            if (ancho == alto)
            {
                // Dibujar cuadrado
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                // Dibujar rectángulo
                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        if (relleno)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if (i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
  }
}
