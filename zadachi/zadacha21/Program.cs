/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки A");
List<int> A = new List<int>();
List<int> B = new List<int>();
for (int i = 0; i<3;i++)
{
    A.Add(Convert.ToInt32(Console.ReadLine()));
}
for (int i = 0; i < 3; i++)
{
    B.Add(Convert.ToInt32(Console.ReadLine()));
}
double X = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]) + (A[2] - B[2]) * (A[2] - B[2]));
Console.WriteLine(X);