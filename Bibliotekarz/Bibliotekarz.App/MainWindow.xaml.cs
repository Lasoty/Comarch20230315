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
            BookList = new ObservableCollection<Book>();

            BookList.Add(new Book() 
            {
                Id = 1,
                Author = "Leszek Lewandowski",
                Title = "Programowanie w C#",
                PageCount = 456,
                IsBorrowed = false,
            });

            BookList.Add(new Book()
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

            allBooks = new List<Book>(BookList);
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
                //var filtedItems = allBooks.
            }
        }
    }
}
