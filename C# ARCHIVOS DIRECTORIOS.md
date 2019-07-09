#DIRECTORIOS
###########

using System.IO

if (Directory.Exists(@"c:/tests/"))   --->   ATENCIÓN A LA @! ésta anula la capacidad de "escape de caracteres" '\', que es como se referencia en windows.
{
	Console.WriteLine("El directorio existe")
}
else
{
	Console.WriteLine("El directorio no existe")
}

Directory.CreateDirectory() ---> CREA UN DIRECTORIOS
Directoy.GetFiles()   ---> OBTIENE EN UN ARRAY LOS NOMBRES DE ARCHIVO

#ARCHIVOS
#########

([UBICACIÓN EN DISCO DURO], [TEXTO A INTRODUCIR]) ---> ESCRIBE / SOBREESCRIBE EL ARCHIVO
File.AppendAllText() ---> IGUAL QUE EL ANTERIOR, PERO EN LUGAR DE SOBREESCRIBIR, LO AGREGA AL FINAL DEL ARCHIVO

StreamWriter file = new StreamWriter (@"c:\tests\hello.txt", true) ---> el segundo parámetro true hace alusión a si el archivo se sobreescribirá o no.
file.WriteLine("hello");
file.Close();   ---> SE HA DE SER CONSCIENTES DE CUANDO DEBEMOS CERRAR EL ARCHIVO. UN ARCHIVO

file.ReadAllText() file.ReadAllLines() --->

#STREAMREADERS
##############

StreamReader sr = new StreamReader(@"RUTA_DE_ARCHIVO")
while (sr.Peek())
{
	Console.Write((char)sr.Read());
}
sr.Close();

#SERIALIZACIÓN
###############

Los datos de serialización se guardan en binario. Aparte de contener los datos de propiedades para las variables, contiene
metainformación, se aplica a las clases de esta forma:

public static void Sav (Palabra p)
{
	IFormatter format = new BinaryFormatter();
	Stream stream = new FileStream("c:/..", FileMode.Create, FileAccess.Write);
	format.Serialize(stream, palabra);
}



