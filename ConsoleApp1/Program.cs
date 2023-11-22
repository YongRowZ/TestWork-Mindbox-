// See https://aka.ms/new-console-template for more information
using TestLIB_Mindbox_;

Figure fig1 = new Figure();
//Figure fig2 = new Figure();

fig1.Area = 10;
Figure fig2 = fig1;

fig2.Area = 20;

Console.WriteLine(fig1.Area);
Console.WriteLine("__________");
Console.WriteLine(fig2.Area + "_____"  + fig1.Area);
