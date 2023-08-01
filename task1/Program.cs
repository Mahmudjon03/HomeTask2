using AppPoint;
using ALine;
var begin = new Point(12,3);
var end = new Point(23,11);
var line = new Line(begin,end);

System.Console.WriteLine("begin line");
System.Console.WriteLine(begin.GetXY()[0]);
System.Console.WriteLine(begin.GetXY()[1]);
System.Console.WriteLine("end line");

line.SetBeginX(10);
line.SetBeginY(18);
System.Console.WriteLine("begin line");
System.Console.WriteLine(begin.GetX());
System.Console.WriteLine(begin.GetY());
line.SetEndX(8);
line.SetEndY(9);
System.Console.WriteLine("end line");
System.Console.WriteLine(end.GetX());
System.Console.WriteLine(end.GetY());










