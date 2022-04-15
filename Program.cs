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

//Mas variables
string MsjClaro, Llave;
int largoMsjClaro, LargoLlave;
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
        Console.WriteLine("10.- Salir");
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
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Mostrar Llave");
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Mostrar Resultado");
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
        ImprimirArregloChar(GlobalData.arrayMensajeClaroOriginal);

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
            ImprimirArregloChar(GlobalData.arrayMensajeClaroOriginal);

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
/*
Console.WriteLine("Ingrese el mensaje claro:");
Console.Write("\n");
MsjClaro = Console.ReadLine();
if (MsjClaro == null || MsjClaro == "" ) {
    return;
}
Console.Write("\n");

DevolverArregloEquivalencia(MsjClaro);


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
//Nota: deberia funcionar tanto para mensaje claro como para la llave
void DevolverArregloEquivalencia(string Cadena)
{
    char[] ch_Cadena = Cadena.ToCharArray();
    int largoCadena = ch_Cadena.Length;
    int[] arrayEquivalente = new int[largoCadena];
    GlobalData.arrayMensajeClaroOriginal = ch_Cadena; //guarda el mensaje claro original en una variable global
    ExisteMsjClaro = true;

    for (int i = 0; i < arrayEquivalente.Length; i++)
    {
        arrayEquivalente[i] = DevolverIndiceAlfabeto(ch_Cadena[i]);
    }

    //return arrayEquivalente;
    GlobalData.arrayMensajeClaroConvertido = arrayEquivalente; //guarda el mensaje claro convertido en una variable global
    //ImprimirArreglo(arrayEquivalente);
}

//Imprime el mensaje calro
//Nota: solo para msj claro
void DevolverArregloMensajeClaro()
{
    ImprimirArregloChar(GlobalData.arrayMensajeClaroOriginal);
}

//recibe un caracter, lo busca en el alfabeto y devuelve su posicion (equivalencia)
// Nota: deberia funcionar tanto para mensaje claro como para la llave
int DevolverIndiceAlfabeto(char charLetra)
{
    int intValor = 0;

    for (int i = 0; i < AlfabetoEsp.Length; i++)
    {
        if (charLetra == AlfabetoEsp[i])
        {
            intValor = i;
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
    public static char[] arrayMensajeClaroOriginal;
    public static int[] arrayMensajeClaroConvertido;
};