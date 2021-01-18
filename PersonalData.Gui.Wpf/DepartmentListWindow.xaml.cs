using PersonalData.Gui.Wpf.Model;
using PersonalData.Gui.Wpf.ViewModel;
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

namespace PersonalData.Gui.Wpf {
    /// <summary>
    /// Interaction logic for DepartmentListWindow.xaml
    /// </summary>
    public partial class DepartmentListWindow : Window {

        public DepartmentListViewModel ViewModel { get; set; }
        public Organization Organization { get; set; }

        public DepartmentListWindow() {
            InitializeComponent();
            this.Organization = new Organization();
            this.ViewModel = new DepartmentListViewModel(this.Organization);
            this.DataContext = this.ViewModel;
        }
    }
}
