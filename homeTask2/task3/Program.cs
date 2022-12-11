Console.Write("Введите цифру, соответствующую дню недели:");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay<6 && numDay > 0){
    Console.WriteLine("Это рабочий день");
} else if (numDay == 6 || numDay == 7){
    Console.WriteLine("Это выходной день");
} else {
    Console.WriteLine("Такого дня недели не существует(к сожалению :( )");
}