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
string MsjClaro, Llave; //Variables para recibir lo que se ingrese
bool salir = false;

void MostrarMenu()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("1.- Configuracion de Idioma\n");
        //Console.WriteLine("////////////////////////////////////////////////////////////\n")
        Console.WriteLine("2.- Ingresar Mensaje claro");
        Console.WriteLine("3.- Mostrar Mensaje claro\n");
        Console.WriteLine("4.- Ingresar Llave");
        Console.WriteLine("5.- Mostrar Llave\n");
        Console.WriteLine("6.- Mostrar Resultado");
        Console.WriteLine("7.- Mostrar Procedimiento completo\n");
        Console.WriteLine("8.- Iniciar version sencilla");
        Console.WriteLine("9.- Iniciar version detallada\n");
        Console.WriteLine("10.- Precargar ejemplo: \tMensaje:laredo \tLlave: guadalupe");
        Console.WriteLine("11.- Precargar ejemplo: \tMensaje:centro \tLlave: guadalupe\n");
        Console.WriteLine("12.- Borrar datos almacenados\n");
        Console.WriteLine("13.- Salir\n");
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
                Opcion7();
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
                Console.WriteLine("Precargando ejemplo: \nMensaje:laredo \nLlave: guadalupe");
                Opcion10();
                break;
            case 11:
                Console.Clear();
                Console.WriteLine("Precargando ejemplo: \nMensaje: centro \nLlave: guadalupe");
                Opcion11();
                break;
            case 12:
                Console.Clear();
                Console.WriteLine("Borrar datos almacenados");
                Opcion12();
                break;
            case 13:
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
        MostrarMenu();
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
        if(ExisteLlave && ExisteMsjClaro)
        {
            MostrarIdioma();
            Paso4pt();
            //imprimirPaso4();
            ImprimirCifrado();

            Console.Write("Presiona <Enter> para regresar al menú... ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                MostrarMenu();
            }
        }
        else
        {
            throw new Exception("Falta ingresar datos..");
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

void Opcion7()
{
    try
    {
        if (ExisteLlave && ExisteMsjClaro)
        {
            MostrarIdioma();
            Paso4pt();
            imprimirPaso4();
            ImprimirCifrado();

            Console.Write("Presiona <Enter> para regresar al menú... ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                MostrarMenu();
            }
        }
        else
        {
            throw new Exception("Falta ingresar datos..");
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
        MostrarIdioma();
        //bool ExisteMsjClaro = true;
        //bool ExisteLlave = true;
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

void Opcion11()
{
    try
    {
        MostrarIdioma();
        //bool ExisteMsjClaro = true;
        //bool ExisteLlave = true;
        DevolverArregloEquivalencia("guadalupe"); //guarda y convierte el arreglo
        DevolverArreglosEquivalenciaLlave("centro"); //guarda y convierte el arreglo

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

void Opcion12()
{
    try
    {
        MostrarIdioma();
        ExisteMsjClaro = false;
        ExisteLlave = false;

        int[] arrayVacioInt = new int[3];
        int[] arrayVacioInt9 = new int[9];
        char[] arrayVacioChar = new char[3];
        char[] arrayVacioChar9 = new char[9];
        GlobalData.arrayResultadoFinal1 = arrayVacioChar;
        GlobalData.arrayResultadoFinal2 = arrayVacioChar;
        GlobalData.arrayLlaveOriginal = arrayVacioChar;
        GlobalData.arrayLlaveOriginal2 = arrayVacioChar;
        GlobalData.arrayMensajeClaroOriginal2 = arrayVacioChar9;

        GlobalData.arrayMultideM2 = arrayVacioInt;
        GlobalData.arrayMultideM1 = arrayVacioInt;
        GlobalData.arrayLlaveConvertida2 = arrayVacioInt;
        GlobalData.arrayLlaveConvertida1 = arrayVacioInt;
        GlobalData.arrayEquivalenciaFinal1 = arrayVacioInt;
        GlobalData.arrayEquivalenciaFinal2 = arrayVacioInt;
        GlobalData.arrayMensajeClaroConvertido = arrayVacioInt9;

        /*
        public static char[] arrayMensajeClaroOriginal2;    //arreglo de chars del mensaje claro
        public static int[] arrayMensajeClaroConvertido;    //arreglo convertido a numeros del mensaje claro   
        public static char[] arrayLlaveOriginal;            //pt1 del arreglo de chars de la llave
        public static char[] arrayLlaveOriginal2;           //pt2 del arreglo de chars de la llave
        public static int[] arrayLlaveConvertida1;          //pt1 del arreglo de enteros de la llave
        public static int[] arrayLlaveConvertida2;          //pt2 del arreglo de enteros de la llave
        public static int[] arrayMultideM1;                //sumatoria de la multiplicacion de M1 * K
        public static int[] arrayMultideM2;                //sumatoria de la multiplicacion de M2 * K
        public static int[] arrayEquivalenciaFinal1, arrayEquivalenciaFinal2;
        public static char[] arrayResultadoFinal1, arrayResultadoFinal2;
         */
        Console.Write("Datos borrados satisfactoriamente ");

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
;
    GlobalData.arrayMensajeClaroConvertido = arrayEquivalente; //guarda el mensaje claro convertido en una variable global
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
         
        //guarda el mensaje claro original en una variable global
        for (int i = 0; i < 3; i++)
        {
            arrayOriginal1[i] = ch_Cadena[i];
        }
        for (int i = 0; i < 3; i++)
        {
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

        GlobalData.arrayLlaveConvertida1 = arrayEquivalente1; //guarda la llave pt1 convertido en una variable global
        GlobalData.arrayLlaveConvertida2 = arrayEquivalente2; //guarda la llave pt1 convertido en una variable global
    }
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

//recibe un numero, lo busca en el alfabeto y devuelve su letra en la posicion (equivalencia)
// Nota: deberia funcionar tanto para mensaje claro como para la llave
string DevolverLetra(int intIndice)
{
    string charLetra = "";

    if (EsEnEspañol)
    {
        for (int i = 0; i < AlfabetoEsp.Length; i++)
        {
            if (intIndice == i)
            {
                charLetra = AlfabetoEsp[i].ToString();
                break;
            }
        }
    }
    else
    {
        for (int i = 0; i < AlfabetoIngles.Length; i++)
        {
            if (intIndice == i)
            {
                charLetra = AlfabetoIngles[i].ToString();
                break;
            }
        }
    }
    return (charLetra);
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

void Paso4pt()
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

    int[] arrayMultideM11 = new [] { a1, a2, a3 };
    GlobalData.arrayMultideM1 = arrayMultideM11;

    //multiplico la matriz 3x3 por m2
    int b1 = 0, b2 = 0, b3 = 0;

    for (int i = 0; i < GlobalData.arrayLlaveConvertida2.Length; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < 3; j++)
            {
                b1 = b1 + (GlobalData.arrayMensajeClaroConvertido[j] * GlobalData.arrayLlaveConvertida2[j]);
            }
        }

        if (i == 1)
        {
            for (int j = 0; j < 3; j++)
            {
                b2 = b2 + (GlobalData.arrayMensajeClaroConvertido[j + 3] * GlobalData.arrayLlaveConvertida2[j]);
            }
        }

        if (i == 2)
        {
            for (int j = 0; j < 3; j++)
            {
                b3 = b3 + (GlobalData.arrayMensajeClaroConvertido[j + 6] * GlobalData.arrayLlaveConvertida2[j]);
            }
        }
    }
    int[] arrayMultideM22 = new[] { b1, b2, b3 };
    GlobalData.arrayMultideM2 = arrayMultideM22;

    int cantaidadDeLetras;
    if (EsEnEspañol)
    {
        cantaidadDeLetras = 27;
    }
    else
    {
        cantaidadDeLetras = 26;
    }

    //Realizando el mod
    int[] arrayFinal1 = new int[3];
    int[] arrayFinal2 = new int[3];
    for (int i = 0; i < 3; i++)
    {
        arrayFinal1[i] = GlobalData.arrayMultideM1[i] % cantaidadDeLetras;
    }
    for (int i = 0; i < 3; i++)
    {
        arrayFinal2[i] = GlobalData.arrayMultideM2[i] % cantaidadDeLetras;
    }

    GlobalData.arrayEquivalenciaFinal1 = arrayFinal1; //guardo en variables globales
    GlobalData.arrayEquivalenciaFinal2 = arrayFinal2; //guardo en variables globales

    GlobalData.arrayResultadoFinal1 = GlobalData.arrayLlaveOriginal;    //inicializo los array aqui
    GlobalData.arrayResultadoFinal2 = GlobalData.arrayLlaveOriginal2;   //inicializo los array aqui

    for (int i = 0;i < GlobalData.arrayEquivalenciaFinal1.Length; i++)
    {
        string varlor_i = DevolverLetra(GlobalData.arrayEquivalenciaFinal1[i]);
        GlobalData.arrayResultadoFinal1[i] = char.Parse(varlor_i);
    }
    for (int i = 0; i < GlobalData.arrayEquivalenciaFinal2.Length; i++)
    {
        string varlor_i = DevolverLetra(GlobalData.arrayEquivalenciaFinal2[i]);
        GlobalData.arrayResultadoFinal2[i] = char.Parse(varlor_i);
    }
}

void imprimirPaso4()
{
    Console.WriteLine("La siguiente matriz representa las sumatorias de la multiplicacion por M1:\n");
    ImprimirArreglo3x1(GlobalData.arrayMultideM1);
    Console.WriteLine("La siguiente matriz representa las sumatorias de la multiplicacion por M2:\n");
    ImprimirArreglo3x1(GlobalData.arrayMultideM2);

    Console.WriteLine("Se le aplica el mod correspondiente a las matrices:\n");
    ImprimirArreglo3x1(GlobalData.arrayEquivalenciaFinal1);
    ImprimirArreglo3x1(GlobalData.arrayEquivalenciaFinal2);

    Console.WriteLine("La siguiente matriz representa el resultado final:\n");
    ImprimirArreglo3x1A(GlobalData.arrayResultadoFinal1);
    ImprimirArreglo3x1A(GlobalData.arrayResultadoFinal2);
}

void ImprimirCifrado()
{
    string strCodigo = "";
    
    foreach (int i in GlobalData.arrayEquivalenciaFinal1)
    {
        string varlor_i = DevolverLetra(i);
        strCodigo = strCodigo + varlor_i;
    }
    foreach (int i in GlobalData.arrayEquivalenciaFinal2)
    {
        string varlor_i = DevolverLetra(i);
        strCodigo = strCodigo + varlor_i;
    }
    Console.WriteLine("El codigo es el siguiente:\n");
    Console.WriteLine(strCodigo);
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
    public static char[] arrayMensajeClaroOriginal2;    //arreglo de chars del mensaje claro
    public static int[] arrayMensajeClaroConvertido;    //arreglo convertido a numeros del mensaje claro   
    public static char[] arrayLlaveOriginal;            //pt1 del arreglo de chars de la llave
    public static char[] arrayLlaveOriginal2;           //pt2 del arreglo de chars de la llave
    public static int[] arrayLlaveConvertida1;          //pt1 del arreglo de enteros de la llave
    public static int[] arrayLlaveConvertida2;          //pt2 del arreglo de enteros de la llave
    public static int[] arrayMultideM1;                //sumatoria de la multiplicacion de M1 * K
    public static int[] arrayMultideM2;                //sumatoria de la multiplicacion de M2 * K
    public static int[] arrayEquivalenciaFinal1, arrayEquivalenciaFinal2;
    public static char[] arrayResultadoFinal1, arrayResultadoFinal2;
};