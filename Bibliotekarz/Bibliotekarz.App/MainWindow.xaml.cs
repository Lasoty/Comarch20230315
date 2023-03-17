using Bibliotekarz.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bibliotekarz.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Book> allBooks;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            GenerateFakeBooks();
        }

        public ObservableCollection<Book> BookList { get; set; }

        public string FilterText { get; set; }

        private void MenuZamknij_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void GenerateFakeBooks()
        {
            allBooks = new List<Book>();

            allBooks.Add(new Book() 
            {
                Id = 1,
                Author = "Leszek Lewandowski",
                Title = "Programowanie w C#",
                PageCount = 456,
                IsBorrowed = false,
            });

            allBooks.Add(new Book()
            {
                Id = 2,
                Author = "John Sharp",
                Title = "Zaawansowany ASP.NET",
                PageCount = 500,
                IsBorrowed = true,
                Borrower = new Customer() 
                {
                    Id = 1,
                    FirstName ="Jan",
                    LastName = "Nowak"
                }
            });

            allBooks.Add(new Book()
            {
                Id = 3,
                Author = "John Sharp",
                Title = "Podstawy ASP.NET",
                PageCount = 500,
                IsBorrowed = true,
                Borrower = new Customer()
                {
                    Id = 1,
                    FirstName = "Jan",
                    LastName = "Nowak"
                }
            });

            BookList = new ObservableCollection<Book>(
                allBooks.OrderBy(book => book.Author).ThenBy(book => book.Title)
                );
        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {
            BookList.Clear();

            if (string.IsNullOrWhiteSpace(FilterText))
            {
                foreach (var item in allBooks)
                {
                    BookList.Add(item);
                }
            }
            else
            {
                var filtedItems = allBooks.Where(book => 
                                            book.Title.Contains(FilterText, StringComparison.InvariantCultureIgnoreCase)
                                        || book.Author.Contains(FilterText, StringComparison.InvariantCultureIgnoreCase)
                                        || (book.Borrower?.FirstName.Contains(FilterText, StringComparison.InvariantCultureIgnoreCase) ?? false)
                                        || (book.Borrower?.LastName.Contains(FilterText, StringComparison.InvariantCultureIgnoreCase) ?? false)
                                                );

                filtedItems = filtedItems.OrderBy(book => book.Author);

                foreach (var item in filtedItems)
                {
                    BookList.Add(item);
                }
            }
        }
    }
}
