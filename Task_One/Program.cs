// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int  EnterDate(string mesange){
    Console.WriteLine(mesange);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int A = EnterDate("Введите число A");
int B = EnterDate("Введите число B");


int getDegreeNumber(int numberA, int numberB){
    int degreeNumber = 1;

    for(int i = 1; i <= numberB; i++){
       degreeNumber *= numberA;
    }
    return degreeNumber;
}
System.Console.WriteLine(getDegreeNumber(A,B));

