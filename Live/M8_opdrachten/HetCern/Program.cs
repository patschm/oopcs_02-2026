using HetCern;

var willem = new WillemKlein();
var simon = new SimonVDMeer();

willem.RekenUit(simon.Add, 4, 5);
willem.RekenUit(simon.Subtract, 4, 5);

// Type varnaam = initialisatie
MathDel del = simon.Add;
del += simon.Add;
del += simon.Subtract;
del += simon.Add;
del += simon.Subtract;

foreach (var item in del.GetInvocationList())
{
    Console.WriteLine(item.Method.Name);
}


int result = del.Invoke(1, 2);
Console.WriteLine(result);
