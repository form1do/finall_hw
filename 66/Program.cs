// // Найти сумму всех натуральных элементов от m до n
// // Через цикл
// int Promt( string msg){
//     System.Console.WriteLine($"{msg}");
//    int number = Convert.ToInt32(Console.ReadLine());
//    return number;
// }
// void PrintInt ( int numbersForPrint){
//     System.Console.WriteLine($"{numbersForPrint} ");
// }
// int FindSum (int m, int n){
//     int sum = 0;
//     for (int i=m-1; i<n; i++){
//     sum = sum + m;
//     m++;
//     }
//     return sum;
// }
// int startUserNumbewr=Promt("Введите первое число");
// int finaltUserNumbewr=Promt("Введите второе число");
// int userSum = FindSum(startUserNumbewr, finaltUserNumbewr);
// PrintInt(userSum);
// Через рекурсию
int Promt( string msg){
    System.Console.WriteLine($"{msg}");
   int number = Convert.ToInt32(Console.ReadLine());
   return number;
}
void PrintInt ( int numbersForPrint){
    System.Console.WriteLine($"{numbersForPrint} ");
}
int FindSum (int m, int n){
   if (m<n || m>n) {
   return (m+FindSum(m+1, n));
   }
   if (m == n) return m;
    return m;
   }
   


int startUserNumbewr=Promt("Введите первое число");
int finaltUserNumbewr=Promt("Введите второе число");
int userSum = FindSum(startUserNumbewr, finaltUserNumbewr);
PrintInt(userSum);