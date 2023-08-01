using SystemPoint;
using Acircle;


var n=new Point(10,12);
System.Console.WriteLine(n.GetX());
System.Console.WriteLine(n.GetY());
n.SetX(11);
n.SetY(13);
System.Console.WriteLine(n.GetX());
System.Console.WriteLine(n.GetY());
n.SetXY(12,14);
foreach (var item in n.GetXY())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine(n.Distance(34,76));
foreach (var item in n.GetXY())
{
    System.Console.WriteLine(item);
}
var v=new Point(34,35);
System.Console.WriteLine(n.Distancee(v));
System.Console.WriteLine(n.ToString());
System.Console.WriteLine("?/-----------------------------------------------------------------------------------//");
var d=new Circle(8,9,4.3);
System.Console.WriteLine(d.GetRadius());
d.SetRadius(5.6);
System.Console.WriteLine(d.GetRadius());
System.Console.WriteLine(d.GetSenterX());
d.SetSenterX(77);
System.Console.WriteLine(d.GetSenterX());
System.Console.WriteLine("_________---");
foreach (var item in d.GetXY())

{
    System.Console.WriteLine(item);
}
d.SeetXY(4,5);
foreach (var item in d.GetXY())

{
    System.Console.WriteLine(item);
}
System.Console.WriteLine(d.ToString());

System.Console.WriteLine($"Area Circle-> {d.GetArea()}");
System.Console.WriteLine($"Circumference-> {d.GEtCircumferens()}");
var b=new Point(45,65);
System.Console.WriteLine($"Distance({d.Distansc(b)})");











   