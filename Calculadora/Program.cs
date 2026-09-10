Console.WriteLine("Bienvenido a mi calculadora");
Console.WriteLine("Calculadora desarrollada en C#");



int continuar = 1;
while (continuar == 1) {
    Console.Write("Digite un número: ");
    double numero1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Usted ingreso: " + numero1);

    Console.Write("Digite otro número: ");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Selecciona una operacion");
    Console.WriteLine("1. suma");
    Console.WriteLine("2. resta");
    Console.WriteLine("3. division");
    Console.WriteLine("4. multiplicacion");

    Console.Write("Digite una opcion: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("La suma es: " + (numero1 + numero2));
            break;

        case 2:
            Console.WriteLine(" La resta es: " + (numero1 - numero2));
            break;

        case 3:
            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                Console.WriteLine("La division es: " + (numero1 / numero2));
            }
            break;

        case 4:
            Console.WriteLine("La multiplicasion es: " + (numero1 * numero2));
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}





