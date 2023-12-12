using System;

class lesson5{


static void Main(){
    Console.Clear();
    Console.WriteLine("Введите позицию элемента i в двумерном массиве:");
    string lineI = Console.ReadLine();
    int numberI = 0;
    if(checkNumber(lineI))
        int.TryParse(lineI, out numberI);

    Console.WriteLine("Введите позицию элемента j в двумерном массиве:");
    string lineJ = Console.ReadLine();
    int numberJ = 0;
    if(checkNumber(lineJ))
        int.TryParse(lineJ, out numberJ);

    firstTask(numberI, numberJ);
    //secondTask();
}


//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
    static void firstTask(int posI, int posJ){

        Random rnd =  new Random();

        int endI = rnd.Next(1, 100);
        int endJ = rnd.Next(1, 100);
        int[ , ] array = new int [endI,endJ];

        Console.WriteLine($"Двумерный массив содержит {endI} строк и {endJ} столбцов ");

        for(int i=0; i<endI; i++) 
            for(int j=0; j<endJ; j++) 
                array[i,j] = rnd.Next(1, 9999);

        

        if((posI<=endI) && (posJ<=endJ)) {
            int el = array[posI,posJ];
            Console.WriteLine($"Элемент массива: {el} ");
        }
        else 
            Console.WriteLine($"Элемент с координатами ({posI}, {posJ}) в массиве нет");
        
    }

    static bool checkNumber(string line){

    int number;
    if(int.TryParse(line, out number))
        return true;
     else 
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");    

    return false;
    }




}