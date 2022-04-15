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

//Mas variables
string MsjClaro, Llave;
int largoMsjClaro, LargoLlave;

void MostrarMenu()
{
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
}

Console.WriteLine("Ingrese el mensaje claro:");
Console.Write("\n");
MsjClaro = Console.ReadLine();
if (MsjClaro == null || MsjClaro == "" ) {
    return;
}
Console.Write("\n");
/*char[] ch_MsjClaro = MsjClaro.ToCharArray();
largoMsjClaro = ch_MsjClaro.Length;
Console.WriteLine("El mensaje claro es: " + MsjClaro + "\nTiene una longitud de: "+ largoMsjClaro.ToString());*/
DevolverArregloEquivalencia(MsjClaro);
//ImprimirArreglo(DevolverArregloEquivalencia(MsjClaro));

Console.WriteLine("Ingrese la llave:");
Console.Write("\n");
Llave = Console.ReadLine();
Console.Write("\n");
char[] ch_Llave = Llave.ToCharArray();
LargoLlave = ch_Llave.Length;

Console.WriteLine("La llave es: " + Llave + "\nTiene una longitud de: " + LargoLlave.ToString());


// Metodos auxiliares

//Recibe una cadena, la convierte en una matriz en su equivalencia
//Nota: deberia funcionar tanto para mensaje claro como para la llave
void DevolverArregloEquivalencia(string Cadena)
{
    char[] ch_Cadena = Cadena.ToCharArray();
    int largoCadena = ch_Cadena.Length;
    int[] arrayEquivalente = new int[largoCadena];

    for (int i = 0; i < arrayEquivalente.Length; i++)
    {
        arrayEquivalente[i] = DevolverIndiceAlfabeto(ch_Cadena[i]);
    }

    //return arrayEquivalente;
    ImprimirArreglo(arrayEquivalente);
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