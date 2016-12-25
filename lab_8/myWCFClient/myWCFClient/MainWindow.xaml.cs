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

namespace myWCFClient
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var SAuthor = new Service1Author();
            dataGrid1.ItemsSource = new ObservableCollection<Object>(SAuthor.ShowAuthors().Select(x => new { x.ID_Author, x.Surname, x.Name, x.SecondName }).OrderBy(p => p.Name)); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var SAuthor = new Service1Author();            
            SAuthor.InsertAuthor(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGrid1.ItemsSource = new ObservableCollection<Object>(SAuthor.ShowAuthors().Select(x => new { x.ID_Author, x.Surname, x.Name, x.SecondName }).OrderBy(p => p.Name)); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var SAuthor = new Service1Author();
            SAuthor.UpdateAuthor(Convert.ToInt32(textBox0.Text), textBox1.Text, textBox2.Text, textBox3.Text);
            dataGrid1.ItemsSource = new ObservableCollection<Object>(SAuthor.ShowAuthors().Select(x => new { x.ID_Author, x.Surname, x.Name, x.SecondName }).OrderBy(p => p.Name)); 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var SAuthor = new Service1Author();
            SAuthor.DeleteAuthor(Convert.ToInt32(textBox0.Text));
            dataGrid1.ItemsSource = new ObservableCollection<Object>(SAuthor.ShowAuthors().Select(x => new { x.ID_Author, x.Surname, x.Name, x.SecondName }).OrderBy(p => p.Name)); 
        }
    }
}
