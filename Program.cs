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
bool ExistLlave = false;
bool ExistMsjClaro = false;

//Mas variables
string MsjLlave, MsjClaro; //Variables para recibir lo que se ingrese
bool salir = false;

void MostrarMenu()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("1.- Configuracion de Idioma\n");
        Console.WriteLine("2.- Ingresar llave");
        Console.WriteLine("3.- Mostrar llave\n");
        Console.WriteLine("4.- Ingresar Mensaje en claro");
        Console.WriteLine("5.- Mostrar Mensaje en claro\n");
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
                Console.WriteLine("Ingresar Llave");
                Opcion2();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Mostrar Llave");
                Opcion3();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Ingresar Mensaje claro");
                Opcion4();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Mostrar Mensaje claro");
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
                Opcion8();
                break;
            case 9:
                Console.Clear();
                Console.WriteLine("Iniciar version detallada");
                Opcion9();
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
                BorrarDatos(); //borra los datos al cambiar de idioma
                //MostrarMenu();
                break;

            case 2:
                Console.Clear();
                EsEnEspañol = false;
                Console.WriteLine("Idioma Ingles");
                BorrarDatos(); //borra los datos al cambiar de idioma
                //MostrarMenu();
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
            Console.Clear();
            MostrarMenu();
        }
    }
}

void Opcion2()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("Ingresar Llave: ");
        MsjLlave = Console.ReadLine();
        if (MsjLlave == null || MsjLlave == "")
        {
            throw new Exception("Ingrese un mensaje valido");
        }
        else if (MsjLlave.Length != 9)
        {
            throw new Exception("Ingrese un mensaje con extension valida");
        }
        Console.WriteLine("La llave es la siguiente:\n");

        DevolverArregloEquivalenciaLlave(MsjLlave); //guarda y convierte el arreglo
        ImprimirArreglo3x3Char(GlobalData.arrayLlaveOrig);

        Console.WriteLine("La llave convertida es la siguiente:\n");
        ImprimirArreglo3x3Int(GlobalData.arrayLlaveConvert);

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
        if (ExistLlave)
        {
            MostrarIdioma();
            Console.WriteLine("La llave es la siguiente:\n");
            ImprimirArreglo3x3Char(GlobalData.arrayLlaveOrig);

            Console.WriteLine("La llave convertida es la siguiente:\n");
            ImprimirArreglo3x3Int(GlobalData.arrayLlaveConvert);

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

void Opcion4()
{
    try
    {
        MostrarIdioma();
        Console.WriteLine("Ingresar Mensaje en Claro: ");
        MsjClaro = Console.ReadLine();
        if (MsjClaro == null || MsjClaro == "")
        {
            throw new Exception("Ingrese un Mensaje en Claro valido");
        }
        else if (MsjClaro.Length < 3)
        {
            throw new Exception("Ingrese un Mensaje en Claro con extension valida");
        }
        Console.WriteLine("El Mensaje en Claro es el siguiente:\n");

        DevolverArraysEquivMsjClaro(MsjClaro); //guarda y convierte el arreglo
        ImprimirArreglo3x1Char(GlobalData.arrayMsjClaroOrig1);
        ImprimirArreglo3x1Char(GlobalData.arrayMsjClaroOrig2);

        Console.WriteLine("El Mensaje en Claro convertido es el siguiente:\n");
        ImprimirArreglo3x1Int(GlobalData.arrayMsjClaroConvert1);
        Console.WriteLine();
        ImprimirArreglo3x1Int(GlobalData.arrayMsjClaroConvert2);

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
        if (ExistMsjClaro)
        {
            MostrarIdioma();
            Console.WriteLine("El Mensaje en Claro es el siguiente:\n");

            //DevolverArreglosEquivalenciaLlave(Llave); //guarda y convierte el arreglo
            ImprimirArreglo3x1Char(GlobalData.arrayMsjClaroOrig1);
            ImprimirArreglo3x1Char(GlobalData.arrayMsjClaroOrig2);

            Console.WriteLine("El Mensaje en Claro convertido es el siguiente:\n");
            ImprimirArreglo3x1Int(GlobalData.arrayMsjClaroConvert1);
            Console.WriteLine();
            ImprimirArreglo3x1Int(GlobalData.arrayMsjClaroConvert2);

            Console.Write("Presiona <Enter> para regresar al menú... ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                MostrarMenu();
            }
        }
        else
        {
            throw new Exception("No existe un Mensaje en Claro previo");
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
        if (ExistMsjClaro && ExistLlave)
        {
            MostrarIdioma();
            Paso4();
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
        if (ExistMsjClaro && ExistLlave)
        {
            MostrarIdioma();
            Paso4();
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

void Opcion8()
{
    try
    {
        if (ExistMsjClaro && ExistLlave)
        {
            MostrarIdioma();
            Paso4();
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
            MostrarIdioma();

            Console.WriteLine("Ingresar Llave: \n");
            MsjLlave = Console.ReadLine();
            if (MsjLlave == null || MsjLlave == "")
            {
                throw new Exception("Ingrese una llave valida\n");
            }
            else if (MsjLlave.Length != 9)
            {
                throw new Exception("Ingrese una Llave con extension valida\n");
            }

            DevolverArregloEquivalenciaLlave(MsjLlave); //guarda y convierte el arreglo

            Console.Write("Ingrese los siguientes datos:\n");
            Console.WriteLine("Ingresar la llave: \n");
            MsjClaro = Console.ReadLine();
            if (MsjClaro == null || MsjClaro == "")
            {
                throw new Exception("Ingrese una llave valida\n");
            }
            else if (MsjClaro.Length < 3)
            {
                throw new Exception("Ingrese una llave con extension valida\n");
            }

            DevolverArraysEquivMsjClaro(MsjClaro); //guarda y convierte el arreglo

            Paso4();
            ImprimirCifrado();

            Console.Write("Presiona <Enter> para regresar al menú... ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Opcion8();
            }
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

void Opcion9()
{
    try
    {
        if (ExistMsjClaro && ExistLlave)
        {
            MostrarIdioma();
            Paso4();
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
            MostrarIdioma();

            Console.WriteLine("Ingresar Llave: \n");
            MsjLlave = Console.ReadLine();
            if (MsjLlave == null || MsjLlave == "")
            {
                throw new Exception("Ingrese una Llave valida\n");
            }
            else if (MsjLlave.Length != 9)
            {
                throw new Exception("Ingrese una Llave con extension valida\n");
            }
            Console.WriteLine("La Llave es la siguiente:\n");

            DevolverArregloEquivalenciaLlave(MsjLlave); //guarda y convierte el arreglo
            ImprimirArreglo3x3Char(GlobalData.arrayLlaveOrig);

            Console.WriteLine("La llave convertida es la siguiente:\n");
            ImprimirArreglo3x3Int(GlobalData.arrayLlaveConvert);

            Console.Write("Ingrese los siguientes datos:\n");
            Console.WriteLine("Ingresar Mensaje en claro: \n");
            MsjClaro = Console.ReadLine();
            if (MsjClaro == null || MsjClaro == "")
            {
                throw new Exception("Ingrese un Mensaje en claro valido");
            }
            else if (MsjClaro.Length < 3)
            {
                throw new Exception("Ingrese un mensaje en claro con extension valida");
            }
            Console.WriteLine("el mensaje en claro es el siguiente:\n");

            DevolverArraysEquivMsjClaro(MsjClaro); //guarda y convierte el arreglo
            ImprimirArreglo3x1Char(GlobalData.arrayMsjClaroOrig1);
            ImprimirArreglo3x1Char(GlobalData.arrayMsjClaroOrig2);

            Console.WriteLine("El Mensaje en claro es el siguiente:\n");
            ImprimirArreglo3x1Int(GlobalData.arrayMsjClaroConvert1);
            Console.WriteLine();
            ImprimirArreglo3x1Int(GlobalData.arrayMsjClaroConvert2);

            Paso4();
            imprimirPaso4();
            ImprimirCifrado();

            Console.Write("Presiona <Enter> para regresar al menú... ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Opcion8();
            }
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
        DevolverArregloEquivalenciaLlave("guadalupe"); //guarda y convierte el arreglo
        DevolverArraysEquivMsjClaro("laredo"); //guarda y convierte el arreglo

        Console.Write("Precargando ejemplo: \nMensaje: laredo \nLlave: guadalupe\n");
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
        DevolverArregloEquivalenciaLlave("guadalupe"); //guarda y convierte el arreglo
        DevolverArraysEquivMsjClaro("centro"); //guarda y convierte el arreglo

        Console.Write("Precargando ejemplo: \nMensaje: centro \nLlave: guadalupe\n");

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
        BorrarDatos();

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
//Nota: Funciona solo para Llave 
void DevolverArregloEquivalenciaLlave(string Cadena)
{
    char[] ch_Cadena = Cadena.ToCharArray();
    int largoCadena = ch_Cadena.Length;
    int[] arrayEquivalente = new int[largoCadena];
    GlobalData.arrayLlaveOrig = ch_Cadena; //guarda la llave original en una variable global
    ExistLlave = true;

    for (int i = 0; i < arrayEquivalente.Length; i++)
    {
        arrayEquivalente[i] = DevolverIndiceAlfabeto(ch_Cadena[i]);
    }
;
    GlobalData.arrayLlaveConvert = arrayEquivalente; //guarda el mensaje claro convertido en una variable global
}

//Recibe una cadena, la convierte en una o varias matrices en su equivalencia
//Nota: Funciona solo para mensaje claro 
void DevolverArraysEquivMsjClaro(string Cadena)
{
    char[] ch_Cadena = Cadena.ToCharArray();
    int largoCadena = ch_Cadena.Length;

    if (largoCadena != 6)
    {
        throw new Exception("Largo del msj claro no soportado\n");
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
            arrayOriginal2[i] = ch_Cadena[i + 3];
        }
        GlobalData.arrayMsjClaroOrig1 = arrayOriginal1;
        GlobalData.arrayMsjClaroOrig2 = arrayOriginal2;
        ExistMsjClaro = true; //bandera para poder saber si existe un msjClaro

        for (int i = 0; i < 3; i++)
        {
            arrayEquivalente1[i] = DevolverIndiceAlfabeto(ch_Cadena[i]);
        }

        for (int i = 0; i < 3; i++)
        {
            arrayEquivalente2[i] = DevolverIndiceAlfabeto(ch_Cadena[i + 3]);
        }

        GlobalData.arrayMsjClaroConvert1 = arrayEquivalente1; //guarda la llave pt1 convertido en una variable global
        GlobalData.arrayMsjClaroConvert2 = arrayEquivalente2; //guarda la llave pt1 convertido en una variable global
    }
}

//recibe un caracter, lo busca en el alfabeto y devuelve su posicion (equivalencia)
// Nota: Funciona tanto para mensaje claro como para la llave
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

//Imprime el arreglo que le mandemos (3x3 de int)
void ImprimirArreglo3x3Int(int[] Arreglo)
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

//Imprime el arreglo que le mandemos (3x1 de int)
void ImprimirArreglo3x1Int(int[] Arreglo)
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

//Imprime el arreglo que le mandemos (3x1 de caracteres)
void ImprimirArreglo3x1Char(char[] Arreglo)
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

//Imprime el arreglo que le mandemos (3x3 de caracteres)
void ImprimirArreglo3x3Char(char[] Arreglo)
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

void Paso4()
{
    //multiplico la matriz 3x3 por m1
    int a1 = 0, a2 = 0, a3 = 0;

    for (int i = 0; i < GlobalData.arrayMsjClaroConvert1.Length; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < 3; j++)
            {
                a1 = a1 + (GlobalData.arrayLlaveConvert[j] * GlobalData.arrayMsjClaroConvert1[j]);
            }
        }

        if (i == 1)
        {
            for (int j = 0; j < 3; j++)
            {
                a2 = a2 + (GlobalData.arrayLlaveConvert[j + 3] * GlobalData.arrayMsjClaroConvert1[j]);
            }
        }

        if (i == 2)
        {
            for (int j = 0; j < 3; j++)
            {
                a3 = a3 + (GlobalData.arrayLlaveConvert[j + 6] * GlobalData.arrayMsjClaroConvert1[j]);
            }
        }
    }

    int[] arrayMultideM11 = new[] { a1, a2, a3 };
    GlobalData.arrayMultideM1 = arrayMultideM11;

    //multiplico la matriz 3x3 por m2
    int b1 = 0, b2 = 0, b3 = 0;

    for (int i = 0; i < GlobalData.arrayMsjClaroConvert2.Length; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < 3; j++)
            {
                b1 = b1 + (GlobalData.arrayLlaveConvert[j] * GlobalData.arrayMsjClaroConvert2[j]);
            }
        }

        if (i == 1)
        {
            for (int j = 0; j < 3; j++)
            {
                b2 = b2 + (GlobalData.arrayLlaveConvert[j + 3] * GlobalData.arrayMsjClaroConvert2[j]);
            }
        }

        if (i == 2)
        {
            for (int j = 0; j < 3; j++)
            {
                b3 = b3 + (GlobalData.arrayLlaveConvert[j + 6] * GlobalData.arrayMsjClaroConvert2[j]);
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

    GlobalData.arrayResultadoFinal1 = GlobalData.arrayMsjClaroOrig1;    //inicializo los array aqui
    GlobalData.arrayResultadoFinal2 = GlobalData.arrayMsjClaroOrig2;   //inicializo los array aqui

    for (int i = 0; i < GlobalData.arrayEquivalenciaFinal1.Length; i++)
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
    ImprimirArreglo3x1Int(GlobalData.arrayMultideM1);
    Console.WriteLine("La siguiente matriz representa las sumatorias de la multiplicacion por M2:\n");
    ImprimirArreglo3x1Int(GlobalData.arrayMultideM2);

    Console.WriteLine("Se le aplica el mod correspondiente a las matrices:\n");
    ImprimirArreglo3x1Int(GlobalData.arrayEquivalenciaFinal1);
    ImprimirArreglo3x1Int(GlobalData.arrayEquivalenciaFinal2);

    Console.WriteLine("La siguiente matriz representa el resultado final:\n");
    ImprimirArreglo3x1Char(GlobalData.arrayResultadoFinal1);
    ImprimirArreglo3x1Char(GlobalData.arrayResultadoFinal2);
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
    Console.WriteLine("El criptograma es el siguiente:\n");
    Console.WriteLine(strCodigo);
}

//Encabezado que se muestra a lo largo del programa para dar informacion del idioma actual
void MostrarIdioma()
{
    if (EsEnEspañol)
    {
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

void BorrarDatos()
{
    ExistLlave = false;
    ExistMsjClaro = false;

    int[] arrayVacioInt = new int[3];
    int[] arrayVacioInt9 = new int[9];
    char[] arrayVacioChar = new char[3];
    char[] arrayVacioChar9 = new char[9];
    GlobalData.arrayResultadoFinal1 = arrayVacioChar;
    GlobalData.arrayResultadoFinal2 = arrayVacioChar;
    GlobalData.arrayMsjClaroOrig1 = arrayVacioChar;
    GlobalData.arrayMsjClaroOrig2 = arrayVacioChar;
    GlobalData.arrayLlaveOrig = arrayVacioChar9;

    GlobalData.arrayMultideM2 = arrayVacioInt;
    GlobalData.arrayMultideM1 = arrayVacioInt;
    GlobalData.arrayMsjClaroConvert2 = arrayVacioInt;
    GlobalData.arrayMsjClaroConvert1 = arrayVacioInt;
    GlobalData.arrayEquivalenciaFinal1 = arrayVacioInt;
    GlobalData.arrayEquivalenciaFinal2 = arrayVacioInt;
    GlobalData.arrayLlaveConvert = arrayVacioInt9;

    Console.Write("Datos borrados satisfactoriamente \n");
}

//Datos globales en los arreglos
public static class GlobalData
{
    public static char[] arrayLlaveOrig;    //arreglo de chars de la llave (9 caracteres)
    public static int[] arrayLlaveConvert;    //arreglo convertido a numeros la llave (9 caracteres)  
    public static char[] arrayMsjClaroOrig1;            //pt1 del arreglo de chars del msjClaro (3 char)
    public static char[] arrayMsjClaroOrig2;           //pt2 del arreglo de chars del msjClaro (3 char)
    public static int[] arrayMsjClaroConvert1;          //pt1 del arreglo de enteros del msjClaro (3 int)
    public static int[] arrayMsjClaroConvert2;          //pt2 del arreglo de enteros del msjClaro (3 int)
    public static int[] arrayMultideM1;                //sumatoria de la multiplicacion de M1 * K
    public static int[] arrayMultideM2;                //sumatoria de la multiplicacion de M2 * K
    public static int[] arrayEquivalenciaFinal1, arrayEquivalenciaFinal2;
    public static char[] arrayResultadoFinal1, arrayResultadoFinal2;
};