
var numero1 = 5;
var numero2 = 7;
Console.WriteLine("Por favor, ingresa la suma de " + numero1 + " y " + numero2 + ": ");
var respuesta = Console.ReadLine();
var resultado = Convert.ToInt32(respuesta);
var esCorrecto = resultado == (numero1 + numero2);
Console.WriteLine("Tu respuesta es " + esCorrecto);

///////////////////////////////////////////////////////////////////////////////////////////////

var numero = 7;
Console.WriteLine("Por favor, ingresa el doble de " + numero + ": ");
var respuesta1 = Console.ReadLine();
var resultado1 = Convert.ToInt32(respuesta1);
var esCorrecto1 = resultado == (numero * 2);
Console.WriteLine("Tu respuesta es " + esCorrecto1);

///////////////////////////////////////////////////////////////////////////////////////////////

var numeroE = 42;
Console.WriteLine("Por favor, ingresa el número " + numeroE + ": ");
var respuestaE = Console.ReadLine();
var numeroIngresadoE = Convert.ToInt32(respuestaE);
var esCorrectoE = numeroIngresadoE == numeroE;
Console.WriteLine("Tu respuesta es " + esCorrectoE);

///////////////////////////////////////////////////////////////////////////////////////////////

var numeroA = 10;

Console.WriteLine("El valor inicial es " + numeroA);

numeroA++;

Console.WriteLine("Después de incrementar, el valor es " + numeroA);

numeroA--;

Console.WriteLine("Después de decrementar, el valor es " + numeroA);

///////////////////////////////////////////////////////////////////////////////////////////////

const double PI = 3.14159265359;

double radio = 5.0;
double area = PI * radio * radio;

Console.WriteLine("El valor de PI es constante: " + PI);

Console.WriteLine("Dado un radio de " + radio + " unidades,");

Console.WriteLine("El área de un círculo es: " + area + " unidades cuadradas.");
