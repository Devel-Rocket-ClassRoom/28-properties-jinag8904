using System;

Console.WriteLine("=== 사각형 1 ===");

Rectangle rec1 = new Rectangle
{
    Width = 10,
    Height = 5
};

Console.WriteLine($"가로: {rec1.Width}\n세로: {rec1.Height}");
Console.WriteLine($"넓이: {rec1.Area}\n둘레: {rec1.Perimeter}\n정사각형: {rec1.IsSqaure}\n");

Console.WriteLine("=== 사각형 2 ===");

Rectangle rec2 = new Rectangle
{
    Width = 7,
    Height = 7
};

Console.WriteLine($"가로: {rec2.Width}\n세로: {rec2.Height}");
Console.WriteLine($"넓이: {rec2.Area}\n둘레: {rec2.Perimeter}\n정사각형: {rec2.IsSqaure}\n");

Console.WriteLine("=== 기본 사각형 ===");

Rectangle rec3 = new Rectangle
{
    Width = 1,
    Height = 1
};

Console.WriteLine($"가로: {rec3.Width}\n세로: {rec3.Height}");
Console.WriteLine($"넓이: {rec3.Area}\n둘레: {rec3.Perimeter}\n정사각형: {rec3.IsSqaure}\n");