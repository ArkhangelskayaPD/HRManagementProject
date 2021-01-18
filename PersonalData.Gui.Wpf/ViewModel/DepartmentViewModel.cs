using PersonalData.Gui.Wpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData.Gui.Wpf.ViewModel {

    public class DepartmentViewModel : BaseViewModel<Department> {

        public DepartmentViewModel(Department depatrment) : base(depatrment) {
            this.mDepName = this.Model.Name;
        }

        private string mDepName;
        public string DepName {
            get {
                return mDepName;
            }
            set {
                if (this.mDepName == value) {
                    return;
                }
                this.mDepName = value;
                OnPropertyChanged(nameof(DepName));
            }
        }
    }
}
