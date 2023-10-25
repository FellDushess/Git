1 -
var(valor1, valor2, valor3) = (true, true, false);
Console.WriteLine(valor1 && valor2 && valor3);
Console.WriteLine(valor1 || valor2 || valor3);
bool resultOr = valor1 || valor2;
Console.WriteLine(resultOr);
bool resultAnd = valor1 && valor2;
Console.WriteLine(resultAnd);
bool resultNot = !valor1;
Console.WriteLine(resultNot);
bool resultXor = valor1 ^ valor2;
Console.WriteLine(resultXor);

2 -
var(valor1, valor2, valor3) = (true, true, false);
bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultNot = !valor1;
Console.WriteLine(resultNot);

3 -
bool valor1 = true;
bool valor2 = false;
bool valor3 = false;

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

4 -
bool valor1 = true;
bool valor2 = false;
bool valor3 = false;

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

5 -
bool valor1 = true;
bool valor2 = false;
bool valor3 = true;

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

bool resultNand = !(valor1 && valor2) && valor3;
Console.WriteLine(resultNand);

6 -
bool valor1 = true;
bool valor2 = true;
bool valor3 = true;

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

7 -
bool valor1 = true;
bool valor2 = true;
bool valor3 = true;

bool result = valor1 && valor2;
Console.WriteLine(result);
