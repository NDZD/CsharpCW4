// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int TableOfSquares(int N){
    int multi = 1;
    for (int i = 1; i <= N; i++){
        multi = multi*i;
        
    }  
      return multi;
}

System.Console.WriteLine(TableOfSquares(4)); 