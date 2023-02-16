Console.WriteLine("Введите номер дня недели :");
int number = int.Parse(Console.ReadLine());
if(number<=5)
{ 
    Console.WriteLine ("Это не выходной день");
}
else {
    Console.WriteLine("Это выходной день");
}