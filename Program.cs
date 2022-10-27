// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("enter m: "); 
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("enter n: "); 
int n = int.Parse(Console.ReadLine());   
double[,] GetArray(Int32 m, Int32 n, Int32 min, Int32 max)  
{     
double[,] array = new double [m, n];     
for (int i = 0; i < array.GetLength(0); i++)     
{
    for (int j = 0; j < array.GetLength(1); j++)         
    { array[i, j] = Convert.ToDouble(new Random().Next(min, max))/100;         
    }     
}     
return array; 
} 
string ArrayToString(double[,] array) 
{ 	string result = string.Empty;  	
for (int i = 0; i < array.GetLength(0); i++) 	
{ 		
    for (int j = 0; j < array.GetLength(1); j++) 		
        { 			
                result += $"{array[i, j]} "; 		
        }  		
        result += Environment.NewLine; 	
    }  	return result; 
}
GetArray(m,n, Int32.MinValue, Int32.MaxValue);
System.Console.WriteLine(ArrayToString(GetArray(m, n, Int32.MinValue, Int32.MaxValue)));