// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число:  ");
int number = Convert.ToInt32(Console.ReadLine()!);
string number1 = Convert.ToString(number); 
if(number1.Length == 5)
{
  if(number1[0] == number1[4]|| number1[1] == number1[3])
  {
    Console.WriteLine($"Число"  + number + "является палиндромом");
  }
 else{Console.WriteLine($"Число"  + number + "НЕ является палиндромом");}
}
else
{
  Console.WriteLine($"Число не корректно!");
}


