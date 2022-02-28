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

    }
    public struct Store
    {
        
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
        
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
