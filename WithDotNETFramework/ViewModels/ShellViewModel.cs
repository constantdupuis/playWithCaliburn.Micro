using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDotNETFramework.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Constant";

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string _lastName = "Dupuis";

        public string LastName
        {
            get { return _lastName; }
            set {
                _lastName = value;
                NotifyOfPropertyChange(() =>LastName);
                NotifyOfPropertyChange(() =>FullName);
            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

    }
}
