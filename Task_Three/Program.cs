// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите количество цифр");
int countElements = Convert.ToInt32(Console.ReadLine());

int [] elems = GetArray(countElements);


int [] GetArray(int countElements){

    int [] elems = new int[countElements];
    int i = 0;
    
    while(i < countElements){
        Console.WriteLine($"Введите {i + 1}-ую цифру");
        int number = Convert.ToInt32(Console.ReadLine());
        elems[i] = number;
        i++;
    }
    return elems;
}


foreach(int elem in elems){
    Console.WriteLine(elem);
}