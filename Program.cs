//объекты
Book book1 = new Book ("Преступление и наказание", "Ф.М. Достаевский", 2020);
book1.Print(); //использование метода
Book book2 = new Book("Капитанская дочка", "А.С. Пушкин", 2013);
book2.Print();
Book book3 = new Book("Вий", "Н.В. Гоголь", 2026);
book3.Print();
Book book4 = new Book("Мцыри", "М.Ю. Лермонтов", 2020);
book4.Print();
Book book5 = new Book("Дубровский", "А.С. Пушкин", 2020);
book5.Print();
Book book6 = new Book("Мертвые души", "Н.В. Гоголь", 2020);
book6.Print();
Book book7 = new Book("Обломов", "И.А. Гончаров", 2020);
book7.Print();
Book book8 = new Book("Отцы и дети", "И.С. Тургенев", 2020);
book8.Print();
Book book9 = new Book("Война и мир", "Л.Н. Толстой", 2020);
book9.Print();
Book book10 = new Book("Гранатовый браслет", "А.И. Куприн", 2020);
book10.Print();

//класс
class Book
{
    public string BookName;
    public string Author;
    public int YearOfPublication;
    //конструктор
    public Book (string BookName, string Author, int YearOfPublication)
    {
        this.BookName = BookName;
        this.Author = Author;
        this.YearOfPublication = YearOfPublication;
    }
    //метод
    public void Print()
    {
        Console.WriteLine($"Книга: {Author} - {BookName}. Издана в {Convert.ToString(YearOfPublication)} году");
    }
}