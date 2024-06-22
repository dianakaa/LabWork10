using LabWork9;

//Task1
Book[] books =
    {
    new Book("Мастер и Маргарита", "М.А.Булгаков", 483),
    new Book("Собачье сердце","М.А.Булгаков", 865),
    new Book("Евгений Онегин", "А.С.Пушкин", 635)
    };

Console.WriteLine("Исходный массив:\n");

foreach (Book book in books)
{
    book.Print();
}

//Task1
Console.WriteLine("\nОтсортированный массив №1:\n");

Array.Sort(books);

foreach (Book book in books)
{
    book.Print();
}

//Task2
Console.WriteLine("\nОтсортированный массив №2:\n");
foreach (Book pet in books)
{
    pet.Print();
}

//Task3
Console.WriteLine("\nЗадание №3\n");

Book book1 = new("Мастер и Маргарита", "М.А.Булгаков", 483);
Book book2 = new("Собачье сердце", "М.А.Булгаков", 865);
Book book3 = new("Евгений Онегин", "А.С.Пушкин", 635);

if (book1.Equals(book2))
    Console.WriteLine("Равны");
else Console.WriteLine("Не равны");

if (book1.Equals(book2))
    Console.WriteLine("Равны");
else Console.WriteLine("Не равны");

//Task4
Console.WriteLine("\nЗадание №4\n");

Book book4 = new("Горе от ума", "А.С.Грибоедов", 205);
Book book5 = (Book)book4.Clone();

book4.Print();
book5.Print();