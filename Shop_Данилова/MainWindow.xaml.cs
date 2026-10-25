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

namespace Shop_Данилова
{
    public partial class MainWindow : Window
    {
        List<object> AllItems = Classes.RepoItems.AllItems();

        public MainWindow()
        {
            InitializeComponent();
            // Вызываем метод создания
            CreateUI();
        }

        /// <summary> Метод создания объектов </summary>
        public void CreateUI()
        {
            // Перебираем объекты
            foreach (object Item in AllItems)
            {
                // Добавляем в UI
                parent.Children.Add(new Elements.Item(Item));
            }
        }
    }
}
