// программу, которая выведет все натуральные числа в промежутке от N до 1
int Promt( string msg){
    System.Console.WriteLine($"{msg}");
   int number = Convert.ToInt32(Console.ReadLine());
   return number;
}
void PrintString ( string numbersForPrint){
    System.Console.WriteLine($"{numbersForPrint} ");
}

string FindNumber (int startNumber, int finalNumber){
    if (startNumber<finalNumber){
        return $"{startNumber}" + FindNumber(startNumber+1, finalNumber);
}
else return String.Empty;
}

int userNumber = Promt ("введите число");
string row = FindNumber( 1, userNumber);
PrintString(row);
