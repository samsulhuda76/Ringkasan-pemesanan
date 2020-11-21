using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ResponsiPemrog2731
{
    /// <summary>
    /// Interaction logic for Penawaran.xaml
    /// </summary>
    public partial class Penawaran : Window
    {



        public Penawaran()
        {
            InitializeComponent();


            List<Item> item = new List<Item>();
            item.Add(new Item() { nama = "Jeruk", harga = 5000 });
            item.Add(new Item() { nama = "Ice Tea", harga = 3000 });
            item.Add(new Item() { nama = "Ice Lemon", harga = 5000 });
            item.Add(new Item() { nama = "Bakso", harga = 10000 });
            item.Add(new Item() { nama = "Gado - Gado", harga = 12000 });
            item.Add(new Item() { nama = "Sate", harga = 15000 });

            ListItem.ItemsSource = item;

            ListItem.Items.Refresh();


        }



        private void OnMouseDoubleClicked(object sender, MouseButtonEventArgs e)
        {

            ListItem_Copy.Items.Add(ListItem.SelectedItem);

        }
        private void OnButtonAddItemClicked(object sender, RoutedEventArgs e)
        {




        }
        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListItem.Items.Refresh();
        }


    }
}