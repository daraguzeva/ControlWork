Console.Write("Введите текст через запятую: "); 
string arr = Console.ReadLine()!; 
string[] num = arr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); 
int size = 3;  
for (int i = 0; i < num.Length; i++) 
{ 
    if (num[i].Length <= size) 
    { 
        Console.WriteLine(num[i]);  
    } 
}