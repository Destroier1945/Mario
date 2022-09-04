// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Its me Mario!!");
Console.WriteLine("Chose height a columm: ");

int c = 0;
int j;
 c = int.Parse(Console.ReadLine());


for( int i = 1; i <= c; i++){
    
    for (j = c - i; j>= 1; j-- )
    Console.Write(" ");
    for(j = 1; j <= i; j++){
        Console.Write("#");
    }        
    Console.Write(" ");
    for(j = 1; j <= i; j++){
        Console.Write("#");
    }        
     Console.WriteLine(" ");
}