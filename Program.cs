// Variables globales
char[] AlfabetoEsp = new[]
        { 'a', 'b', 'c', 'd', 'e',
          'f', 'g', 'h', 'i', 'j',
          'k', 'l', 'm', 'n', 'ñ',
          'o', 'p', 'q', 'r', 's',
          't', 'u', 'v', 'w' , 'x', 'y', 'z'
        };

char[] AlfabetoIngles = new[]
        { 'a', 'b', 'c', 'd', 'e',
          'f', 'g', 'h', 'i', 'j',
          'k', 'l', 'm', 'n', 'o',
          'p', 'q', 'r', 's', 't',
          'u', 'v', 'w' , 'x', 'y', 'z'
        };
bool EsEnEspañol = true;
bool ExisteMsjClaro = false;
bool ExisteLlave = false;

//Mas variables
string MsjClaro, Llave;
//int largoMsjClaro, LargoLlave;
bool salir = false;

//char[] arrayMensajeClaroOriginal;
//int[] arrayMensajeClaroConvertido;


void MostrarMenu()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("1.- Configuracion de Idioma");
        Console.WriteLine("2.- Ingresar Mensaje claro");
        Console.WriteLine("3.- Mostrar Mensaje claro");
        Console.WriteLine("4.- Ingresar Llave");
        Console.WriteLine("5.- Mostrar Llave");
        Console.WriteLine("6.- Mostrar Resultado");
        Console.WriteLine("7.- Mostrar Procedimiento completo");
        Console.WriteLine("8.- Iniciar version sencilla");
        Console.WriteLine("9.- Iniciar version detallada");
        Console.WriteLine("9.- Borrar datos almacenados");
        Console.WriteLine("10.- Precargar ejemplo");
        Console.WriteLine("11.- Salir");
        Console.WriteLine("Elige una de las opciones");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Configuracion de Idioma");
                Opcion1();
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Ingresar Mensaje claro");
                Opcion2();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Mostrar Mensaje claro");
                Opcion3();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Ingresar Llave");
                Opcion4();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Mostrar Llave");
                Opcion5();
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Mostrar Resultado");
                Opcion6();
                break;
            case 7:
                Console.Clear();
                Console.WriteLine("Mostrar Procedimiento completo");
                break;
            case 8:
                Console.Clear();
                Console.WriteLine("Iniciar version sencilla");
                break;
            case 9:
                Console.Clear();
                Console.WriteLine("Iniciar version detallada");
                break;
            case 10:
                Console.Clear();
                Console.WriteLine("Precargando ejemplo: \nMensaje:guadalupe \nLlave: laredo");
                Opcion10();
                break;
            case 11:
                Console.Clear();
                Console.WriteLine("Has elegido salir de la aplicación");
                salir = true;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Elige una opcion entre 1 y 10");
                MostrarMenu();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}


MostrarMenu();

void Opcion1()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("1.- Idioma Español");
        Console.WriteLine("2.- Idioma Ingles");
        Console.WriteLine("3.- Salir");
        Console.WriteLine("Elige una de las opciones");
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.Clear();
                EsEnEspañol = true;
                Console.WriteLine("Idioma Español");
                MostrarMenu();
                break;

            case 2:
                Console.Clear();
                EsEnEspañol = false;
                Console.WriteLine("Idioma Ingles");
                MostrarMenu();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Has elegido salir de la aplicación");
                salir = true;
                break;
            default:
                Console.Clear();
                Console.WriteLine("Elige una opcion entre 1 y 3");
                break;
        }
    }catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}

void Opcion2()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("Ingresar Mensaje claro: ");
        MsjClaro = Console.ReadLine();
        if (MsjClaro == null || MsjClaro == "")
        {
            throw new Exception("Ingrese un mensaje valido");
        }else if (MsjClaro.Length != 9)
        {
            throw new Exception("Ingrese un mensaje con extension valida");
        }
        Console.WriteLine("El mensaje claro es el siguiente:\n");

        DevolverArregloEquivalencia(MsjClaro); //guarda y convierte el arreglo
        ImprimirArregloChar(GlobalData.arrayMensajeClaroOriginal2);

        Console.WriteLine("El mensaje claro convertido es el siguiente:\n");
        ImprimirArreglo(GlobalData.arrayMensajeClaroConvertido);

        Console.Write("Presiona <Enter> para regresar al menú... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.Clear();
            MostrarMenu();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.Write("Presiona <Enter> para intentar nuevamente... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Opcion2();
        }
    }
}

void Opcion3()
{
    try
    {
        if (ExisteMsjClaro)
        {
            MostrarIdioma();
            Console.WriteLine("El mensaje claro es el siguiente:\n");

            //DevolverArregloEquivalencia(MsjClaro); //guarda y convierte el arreglo
            ImprimirArregloChar(GlobalData.arrayMensajeClaroOriginal2);

            Console.WriteLine("El mensaje claro convertido es el siguiente:\n");
            ImprimirArreglo(GlobalData.arrayMensajeClaroConvertido);

            Console.Write("Presiona <Enter> para regresar al menú... ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                MostrarMenu();
            }
        }
        else
        {
            throw new Exception("No existe un mensaje claro previo");
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.Write("Presiona <Enter> para regresar al menú... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            MostrarMenu();
        }
    }
}

void Opcion4()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("Ingresar la llave: ");
        Llave = Console.ReadLine();
        if (Llave == null || Llave == "")
        {
            throw new Exception("Ingrese una llave valida");
        }
        else if (Llave.Length < 3)
        {
            throw new Exception("Ingrese una llave con extension valida");
        }
        Console.WriteLine("La llave es la siguiente:\n");

        DevolverArreglosEquivalenciaLlave(Llave); //guarda y convierte el arreglo
        ImprimirArreglo3x1A(GlobalData.arrayLlaveOriginal);
        ImprimirArreglo3x1A(GlobalData.arrayLlaveOriginal2);

        Console.WriteLine("La llave convertida es la siguiente:\n");
        ImprimirArreglo3x1(GlobalData.arrayLlaveConvertida1);
        Console.WriteLine();
        ImprimirArreglo3x1(GlobalData.arrayLlaveConvertida2);

        Console.Write("Presiona <Enter> para regresar al menú... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.Clear();
            MostrarMenu();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.Write("Presiona <Enter> para intentar nuevamente... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Opcion4();
        }
    }
}

void Opcion5()
{
    try
    {
        if (ExisteLlave)
        {
            MostrarIdioma();
            Console.WriteLine("La llave es la siguiente:\n");

            //DevolverArreglosEquivalenciaLlave(Llave); //guarda y convierte el arreglo
            ImprimirArreglo3x1A(GlobalData.arrayLlaveOriginal);
            ImprimirArreglo3x1A(GlobalData.arrayLlaveOriginal2);

            Console.WriteLine("La llave convertida es la siguiente:\n");
            ImprimirArreglo3x1(GlobalData.arrayLlaveConvertida1);
            Console.WriteLine();
            ImprimirArreglo3x1(GlobalData.arrayLlaveConvertida2);

            Console.Write("Presiona <Enter> para regresar al menú... ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                MostrarMenu();
            }
        }
        else
        {
            throw new Exception("No existe una llave previa");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.Write("Presiona <Enter> para regresar al menú... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            MostrarMenu();
        }
    }
}

void Opcion6()
{
    try
    {
        Paso4pt1();

        Console.Write("Presiona <Enter> para regresar al menú... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.Clear();
            MostrarMenu();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.Write("Presiona <Enter> para regresar al menú... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            MostrarMenu();
        }
    }
}

void Opcion10()
{
    try
    {
        bool ExisteMsjClaro = true;
        bool ExisteLlave = true;
        DevolverArregloEquivalencia("guadalupe"); //guarda y convierte el arreglo
        DevolverArreglosEquivalenciaLlave("laredo"); //guarda y convierte el arreglo

        Console.Write("Presiona <Enter> para regresar al menú... ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.Clear();
            MostrarMenu();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}
/*

Console.WriteLine("Ingrese la llave:");
Console.Write("\n");
Llave = Console.ReadLine();
Console.Write("\n");
char[] ch_Llave = Llave.ToCharArray();
LargoLlave = ch_Llave.Length;

Console.WriteLine("La llave es: " + Llave + "\nTiene una longitud de: " + LargoLlave.ToString());
*/

// Metodos auxiliares

//Recibe una cadena, la convierte en una matriz en su equivalencia
//Nota: Funciona solo para mensaje claro 
void DevolverArregloEquivalencia(string Cadena)
{
    char[] ch_Cadena = Cadena.ToCharArray();
    int largoCadena = ch_Cadena.Length;
    int[] arrayEquivalente = new int[largoCadena];
    GlobalData.arrayMensajeClaroOriginal2 = ch_Cadena; //guarda el mensaje claro original en una variable global
    ExisteMsjClaro = true;

    for (int i = 0; i < arrayEquivalente.Length; i++)
    {
        arrayEquivalente[i] = DevolverIndiceAlfabeto(ch_Cadena[i]);
    }

    //return arrayEquivalente;
    GlobalData.arrayMensajeClaroConvertido = arrayEquivalente; //guarda el mensaje claro convertido en una variable global
    //ImprimirArreglo(arrayEquivalente);
}

//Recibe una cadena, la convierte en una o varias matrices en su equivalencia
//Nota: Funciona solo para mensaje claro 
void DevolverArreglosEquivalenciaLlave(string Cadena)
{
    char[] ch_Cadena = Cadena.ToCharArray();
    int largoCadena = ch_Cadena.Length;

    if (largoCadena != 6)
    {
        throw new Exception("Largo de la llave no soportada");
    }
    else
    {
        char[] arrayOriginal1 = new char[3];
        char[] arrayOriginal2 = new char[3];
        int[] arrayEquivalente1 = new int[3];
        int[] arrayEquivalente2 = new int[3];
        //GlobalData.arrayMensajeClaroOriginal = ch_Cadena; 
        //guarda el mensaje claro original en una variable global
        for (int i = 0; i < 3; i++)
        {
            //GlobalData.arrayLlaveOriginal[i] = ch_Cadena[i];
            arrayOriginal1[i] = ch_Cadena[i];
        }
        for (int i = 0; i < 3; i++)
        {
            //GlobalData.arrayLlaveOriginal2[i] = ch_Cadena[i+3];
            arrayOriginal2[i] = ch_Cadena[i+3];
        }
        GlobalData.arrayLlaveOriginal = arrayOriginal1;
        GlobalData.arrayLlaveOriginal2 = arrayOriginal2;
        ExisteLlave = true; //bandera para poder saber si existe una llave

        for (int i = 0; i < 3; i++)
        {
            arrayEquivalente1[i] = DevolverIndiceAlfabeto(ch_Cadena[i]);
        }

        for (int i = 0; i < 3; i++)
        {
            arrayEquivalente2[i] = DevolverIndiceAlfabeto(ch_Cadena[i+3]);
        }

        //return arrayEquivalente;
        GlobalData.arrayLlaveConvertida1 = arrayEquivalente1; //guarda la llave pt1 convertido en una variable global
        GlobalData.arrayLlaveConvertida2 = arrayEquivalente2; //guarda la llave pt1 convertido en una variable global
    }
}

//Imprime el mensaje claro
//Nota: Funciona solo para mensaje claro 
void DevolverArregloMensajeClaro()
{
    ImprimirArregloChar(GlobalData.arrayMensajeClaroOriginal2);
}

//recibe un caracter, lo busca en el alfabeto y devuelve su posicion (equivalencia)
// Nota: deberia funcionar tanto para mensaje claro como para la llave
int DevolverIndiceAlfabeto(char charLetra)
{
    int intValor = 0;

    if (EsEnEspañol)
    {
        for (int i = 0; i < AlfabetoEsp.Length; i++)
        {
            if (charLetra == AlfabetoEsp[i])
            {
                intValor = i;
            }
        }
    }
    else
    {
        for (int i = 0; i < AlfabetoIngles.Length; i++)
        {
            if (charLetra == AlfabetoIngles[i])
            {
                intValor = i;
            }
        }
    }
        
    return (intValor);
}

//Imprime el arreglo que le mandemos (Funciona de momento solo para mensaje claro)
void ImprimirArreglo(int[] Arreglo)
{
    string l1 = "[", l2 = "[", l3 = "[";
    for (int i = 0; i < Arreglo.Length; i++)
    {
        if (i < 3)
        {
            l1 = l1 + "\t" + Arreglo[i].ToString();
        }else if (i < 6)
        {
            l2 = l2 + "\t" + Arreglo[i].ToString();
        }else if(i < 9)
        {
            l3 = l3 + "\t" + Arreglo[i].ToString();
        }
    }
    Console.WriteLine(l1 + "\t]\n" + l2 + "\t]\n" + l3 + "\t]\n");
}

//Imprime el arreglo que le mandemos (Funciona solo para llave)
void ImprimirArreglo3x1(int[] Arreglo)
{
    string l1 = "", l2 = "[", l3 = "[";
    for (int i = 0; i < Arreglo.Length; i++)
    {
        if (i == 0)
        {
            l1 = "[" + Arreglo[i].ToString() + "]\n";
        }
        else if (i == 1)
        {
            l2 = "[" + Arreglo[i].ToString() + "]\n";
        }
        else if (i == 2)
        {
            l3 = "[" + Arreglo[i].ToString() + "]\n";
        }
    }
    Console.WriteLine(l1 + l2 + l3 + "\n");
}

//Imprime el arreglo que le mandemos (Funciona solo para llave)
void ImprimirArreglo3x1A(char[] Arreglo)
{
    string l1 = "", l2 = "[", l3 = "[";
    for (int i = 0; i < Arreglo.Length; i++)
    {
        if (i == 0)
        {
            l1 = "[" + Arreglo[i].ToString() + "]\n";
        }
        else if (i == 1)
        {
            l2 = "[" + Arreglo[i].ToString() + "]\n";
        }
        else if (i == 2)
        {
            l3 = "[" + Arreglo[i].ToString() + "]\n";
        }
    }
    Console.WriteLine(l1 + l2 + l3 + "\n");
}

//Imprime el arreglo que le mandemos (Funciona de momento solo para mensaje claro)
void ImprimirArregloChar(char[] Arreglo)
{
    string l1 = "[", l2 = "[", l3 = "[";
    for (int i = 0; i < Arreglo.Length; i++)
    {
        if (i < 3)
        {
            l1 = l1 + "\t" + Arreglo[i].ToString();
        }
        else if (i < 6)
        {
            l2 = l2 + "\t" + Arreglo[i].ToString();
        }
        else if (i < 9)
        {
            l3 = l3 + "\t" + Arreglo[i].ToString();
        }
    }
    Console.WriteLine(l1 + "\t]\n" + l2 + "\t]\n" + l3 + "\t]\n");
}

void Paso4pt1()
{
    //multiplico la matriz 3x3 por m1
    int a1 = 0, a2= 0, a3 = 0;
    
    for (int i = 0; i < GlobalData.arrayLlaveConvertida1.Length; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < 3; j++)
            {
                a1 = a1 + (GlobalData.arrayMensajeClaroConvertido[j] * GlobalData.arrayLlaveConvertida1[j]);
            }
        }

        if (i == 1)
        {
            for (int j = 0; j < 3; j++)
            {
                a2 = a2 + (GlobalData.arrayMensajeClaroConvertido[j+3] * GlobalData.arrayLlaveConvertida1[j]);
            }
        }

        if (i == 2)
        {
            for (int j = 0; j < 3; j++)
            {
                a3 = a3 + (GlobalData.arrayMensajeClaroConvertido[j+6] * GlobalData.arrayLlaveConvertida1[j]);
            }
        }
    }

    Console.WriteLine(a1.ToString());
    Console.WriteLine(a2.ToString());
    Console.WriteLine(a3.ToString());
}

//Encabezado que se muestra a lo largo del programa para dar informacion del idioma actual
void MostrarIdioma()
{
   if (EsEnEspañol) {
        Console.Clear();
        Console.WriteLine("////////////////////////////////////////////////////////////");
        Console.WriteLine("Idioma Actual: Español");
        Console.WriteLine("////////////////////////////////////////////////////////////\n");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("////////////////////////////////////////////////////////////");
        Console.WriteLine("Idioma Actual: Ingles");
        Console.WriteLine("////////////////////////////////////////////////////////////\n");
    }
}

//Datos globales en los arreglos
public static class GlobalData
{
    public static char[] arrayMensajeClaroOriginal2;
    public static int[] arrayMensajeClaroConvertido;
    public static char[] arrayLlaveOriginal;
    public static char[] arrayLlaveOriginal2;
    public static int[] arrayLlaveConvertida1;
    public static int[] arrayLlaveConvertida2;
    public static int[,] matrizcifrado;
};