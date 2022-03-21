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
using System.Windows.Shapes;

namespace EnglishSchooll
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class SoonRecordWindow : Window
    {
        public SoonRecordWindow()
        {
            InitializeComponent();
            DgClient.ItemsSource = Const.BD.Client.ToList();
            DgServ.ItemsSource = Const.BD.Service.ToList();
            DgDate.ItemsSource = Const.BD.ClientService.ToList();
        }
    }
}
