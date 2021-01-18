using PersonalData.Gui.Wpf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData.Gui.Wpf.ViewModel {
    public class DepartmentListViewModel {

        public ObservableCollection<DepartmentViewModel> Departments { get; set; }

        public DepartmentListViewModel(Organization organization) {
            Departments = new ObservableCollection<DepartmentViewModel>(organization.Departments.Select(e => new DepartmentViewModel(e)));
        }
    }
}
