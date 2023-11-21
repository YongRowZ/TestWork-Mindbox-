# TestWork-Mindbox-
# .NET 6.0
Figures -> Родительский класс содержащий:
1. Area (Свойство, определяющее площадь фигуры)
2. MatchArea() рассчет площади по входящимм данным:
   - MatchArea(double radius) -> Рассчет плошади круга по формуле S = π × r2
   - MatchArea(double a, double b, double c) -> Расчет площади треугольника по формуле Герона

Имеет дочерние классы:
1. Circle(double radius) -> Круг:
   - при иницилицации данного класса, сразу же рассчитываеться плошадь по формуле  S = π × r2
   - Circle circle = new Circle(radius)
   - circle.Area - плошадь круга (double)
3. Triangle(double a, double b, double c) -> Треугольник:
   - при иницилицации данного класса, сразу же рассчитываеться плошадь по формуле Герона,
     и проверяется является ли треугольник прямоугольным
   - Triangle triangle = new Triangle(a,b,c)
   - triangle.Area - плошадь треугольника (double)
   - triangle.Rectangular -  прямоугольный ли треуголиньк(bool): true  -> ДА, false  -> НЕТ
