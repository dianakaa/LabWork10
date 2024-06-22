using System.Xml.Linq;

namespace LabWork9
{
    internal class Book : IComparable, IComparable<Book>, IEquatable<Book>, ICloneable
    {
        public string _name { get; set; }
        public string _author { get; set; }
        public int _price { get; set; }

        #region Конструктор
        public Book(string name, string author, int price)
        {
            _name = name;
            _author = author;
            _price = price;
        }
        #endregion

        #region Методы
        public void Print()
        {
            Console.WriteLine($"Название: {_name}, Автор: {_author}, Цена: {_price}");
        }
        #endregion

        #region Свойства
        public string GetTitle
        {
            get { return _name; }
            set
            {
                if (_name.Length < 0)
                {
                    throw new ArgumentException("Название не может быть пустым");
                }
            }
        }

        public string GetAuthor
        {
            get { return _author; }
            set
            {
                if (_author.Length < 0)
                {
                    throw new ArgumentException("Автор не может быть пустым.");
                }
            }
        }

        public int GetPrice
        {
            get { return _price; }
            set
            {
                if (_price < 0)
                {
                    throw new ArgumentException("Цена не может быть меньше 0.");
                }
            }
        }
        #endregion

        #region Task1
        public int CompareTo(object obj)
        {
            Book book = obj as Book;
            return GetPrice.CompareTo(book.GetPrice);
        }
        #endregion

        #region Task2
        public int CompareTo(Book book1)
        {
            Book book = book1 as Book;
            return GetPrice.CompareTo(book.GetPrice);
        }
        #endregion

        #region Task3
        public bool Equals(Book book)
        {
            if (GetTitle == book.GetTitle && GetAuthor == book.GetAuthor && GetPrice == book.GetPrice)
                return true;
            return false;
        }
        #endregion

        #region Task4
        public object Clone() => new Book(GetTitle, GetAuthor, GetPrice);
        #endregion
    }
}