/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да */
			

bool isPalindrom(int n) {
    int reversed = 0, remainder = 0, original = n;
    
    while (n != 0) {
      remainder = n % 10;
      reversed = reversed * 10 + remainder;
      n /= 10;
    }
    
    if (original == reversed)
      return true;
    else
      return false;
  }
  