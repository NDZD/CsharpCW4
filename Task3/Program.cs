// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] GetRandomArray(){
    int [] arr = new int [8];
           
    for (int i = 0; i < 8; i++){
        arr[i] = new Random().Next(0, 2);
        
    }
    return arr;
}


System.Console.WriteLine($"[{string.Join(", ", GetRandomArray())}]");








// int[] array = GetRandomArray();
// System.Console.Write("[");
// foreach (var item in array)
// {
//     System.Console.Write($"{item}" + " " );
// }
// System.Console.Write("]");
// System.Console.Write("[1, ");
// System.Console.Write("2");
// System.Console.Write(", 3");