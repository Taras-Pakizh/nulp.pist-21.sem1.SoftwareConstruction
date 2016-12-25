using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.SqlClient;
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

namespace DataAccess
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string type = "ADO.Net";
        private string table = "client";

        public ObservableCollection<object> _collection = new ObservableCollection<object>();
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = _collection;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            type = (comboBox.SelectedItem as ListBoxItem).Content.ToString();
            table = (listBox.SelectedItem as ListBoxItem).Content.ToString();
            switch (type)
            {
                case "ADO.Net":
                    using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=db_labs;Integrated Security=true"))
                    {
                        SqlCommand command = null;
                        switch (table)
                        {
                            case "client":
                                command = new SqlCommand("SELECT * from labs.client", connection);
                                break;
                            case "device":
                                command = new SqlCommand("SELECT * from labs.device", connection);
                                break;
                            case "order":
                                command = new SqlCommand("SELECT * from labs.ordr", connection);
                                break;
                        }
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            _collection.Clear();
                            while (reader.Read())
                            {
                                switch (table)
                                {
                                    case "client":
                                        _collection.Add(new { first_name = reader[1], last_name = reader[2], registration_date = reader[3], phone = reader[4] });
                                        break;
                                    case "device":
                                        _collection.Add(new { name = reader[1], description = reader[2], category = reader[3], location = reader[4] });
                                        break;
                                    case "order":
                                        _collection.Add(new { client = reader[1], price = reader[2], employee = reader[3], delivery = reader[4] });
                                        break;
                                }
                            }
                            reader.Close();
                            dataGrid.ItemsSource = null;
                            dataGrid.ItemsSource = _collection;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    break;
                case "LINQ to SQL":
                    DataContext context = new System.Data.Linq.DataContext("Data Source=(local);Initial Catalog=db_labs;Integrated Security=true");
                    _collection.Clear();
                    switch (table)
                    {
                        case "client":
                            var clients = from c in context.GetTable<client>() select c;
                            foreach (client c in clients)
                                _collection.Add(new { first_name = c.first_name, last_name = c.last_name, registration_date = c.registration_date, phone = c.phone });
                            break;
                        case "device":
                            var devices = from c in context.GetTable<device>() select c;
                            foreach (var d in devices)
                                _collection.Add(new { name = d.name, description = d.description, category = d.category, location = d.location});
                            break;
                        case "order":
                            var orders = from c in context.GetTable<ordr>() select c;
                            foreach (var o in orders)
                                _collection.Add(new { client = o.client, price = o.price, employee = o.employee, delivery = o.delivery });
                            break;
                    }
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = _collection;
                    break;
                case "ADO.Net EntityFramework":
                    using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=db_labs;Integrated Security=true"))
                    {
                        SqlCommand command = null;
                        switch (table)
                        {
                            case "client":
                                command = new SqlCommand("SELECT * from labs.client", connection);
                                break;
                            case "device":
                                command = new SqlCommand("SELECT * from labs.device", connection);
                                break;
                            case "order":
                                command = new SqlCommand("SELECT * from labs.ordr", connection);
                                break;
                        }
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            _collection.Clear();
                            while (reader.Read())
                            {
                                switch (table)
                                {
                                    case "client":
                                        _collection.Add(new { first_name = reader[1], last_name = reader[2], registration_date = reader[3], phone = reader[4] });
                                        break;
                                    case "device":
                                        _collection.Add(new { name = reader[1], description = reader[2], category = reader[3], location = reader[4] });
                                        break;
                                    case "order":
                                        _collection.Add(new { client = reader[1], price = reader[2], employee = reader[3], delivery = reader[4] });
                                        break;
                                }
                            }
                            reader.Close();
                            dataGrid.ItemsSource = null;
                            dataGrid.ItemsSource = _collection;
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    break;
            }
        }
    }
}
