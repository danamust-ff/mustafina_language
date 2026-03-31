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

namespace mustafina_language
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            var currentClient = Mustafina_LanguageEntities.GetContext().Client.ToList();
            ClientList.ItemsSource= currentClient;

        }


        int CountRecords; //кол-во записей 
        int CountPage; //общее кол-во стр
        int CurrentPage = 0; //текущ стр (0)
        int RecordsPage = 20; //кол-во записей на 1 стр
        List<Client> CurrentPageList = new List<Client>();
        List<Client> TableList;

        /*
        private void ChangePage(int direction, int? selectedPage)
        {
            CurrentPageList.Clear(); //список тек стр
                CountRecords = TableList.Count; //подсчет кол-ва записей 
            CountPage = (CountRecords + RecordsPage - 1) / RecordsPage;

            if (selectedPage.HasValue && selectedPage >= 0 && selectedPage < CountPage) //стр 1 2 3 4
            {
                CurrentPage = (int)selectedPage; //переходим на выбранную стр
            }
            else //стрелки
            {
                if (direction == 1 && CurrentPage > 0) //предыдущая стр 
                {
                    CurrentPage--;
                }
                else if (direction == 2 && CurrentPage < CountPage - 1) //след стр
                {
                    CurrentPage++;
                }
                else return; //если изменений не было то выход                                                    
            }

            int startIn = CurrentPage * RecordsPage;
            int endIn = Math.Min(startIn + RecordsPage, CountRecords);
            for (int i = startIn; i < endIn; i++)
            {
                CurrentPageList.Add(TableList[i]);
            }
            //обновление 
            PageListBox.Items.Clear();
            for (int i = 1; i <= CountPage; i++)
            {
                PageListBox.Items.Add(i);
            }
            PageListBox.SelectedIndex = CurrentPage;
            ClientList.ItemsSource = CurrentPageList;
            ClientList.Items.Refresh();

        }

        */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            //ChangePage(1, null);
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
           // ChangePage(2, null);
        }

        private void PageListBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //ChangePage(0, Convert.ToInt32(PageListBox.SelectedItem.ToString()) - 1);
        }
    }
}
