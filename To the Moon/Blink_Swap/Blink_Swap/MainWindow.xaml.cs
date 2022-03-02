using System;
using System.Collections.Generic;
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

namespace Blink_Swap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public struct Customer
    {
        public string address;
        public string name;
        public string email;
        public string user;
        public string password;
        public double amount;
        public Coin coin;
        public string key;

    }
    public struct Store
    {
        public string address;
        public string user;
        public string email;
        public double balance;
        public string key;

    }
    public struct Coin
    {
        public double BTC;
        public double ETH;
        public double SOL;
    }
    public struct Date
    {
        public int day;
        public int month;
        public int year;
        public Time time;
    }
    public struct Time
    {
        public int hour;
        public int minute;
        public int second;
    }
    public struct Swap
    {
        public Date date;
        public Customer customer;
        public Store store;
        
 
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
