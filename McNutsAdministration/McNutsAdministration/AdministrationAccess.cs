using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    public class AdministrationAccess
    {
        private static AdministrationAccess _access = null;
        private static object _syncLock = new object();
        private IAdministratorService _administratorService;
        private AdministratorNotifier _administratorNotifier;
        private PeanutModelAndService _peanut;
        private PeanutNotifier _peanutNotifier;

        private AdministrationAccess()
        {
            _administratorService = new AdministratorService();
            _administratorNotifier = new AdministratorNotifier(_administratorService);
        }

        public static AdministrationAccess Access
        {
            get
            {
                lock(_syncLock)
                {
                    if (_access == null)
                        _access = new AdministrationAccess();
                    return _access;
                }
            }
        }

        public void ShowAdministrators()
        {
            _administratorNotifier.ShowAdministrators();
        }

        public void ShowAdministrator(long ci)
        {
            _administratorNotifier.ShowAdministrator(ci);
        }

        public bool CreateAdministrator(AdministratorModel newAdministrator)
        {
            _administratorService.CreateAdministrator(newAdministrator);
            return true;
        }
        public bool DeleteAdministrator(long ci)
        {
            _administratorService.DeleteAdministrator(ci);
            return true;
        }
        public AdministratorModel UpdateAdministrator(long ci, AdministratorModel updateAdministrator)
        {
            var administratorUpdate=_administratorService.UpdateAdministrator(ci, updateAdministrator);
            return administratorUpdate;
        }

        public void CreateFlavor(string flavor)
        {
            PeanutsFactory factory = new ConcretePeanutFactory();
            _peanut = factory.GetPeanut(flavor);
            _peanutNotifier = new PeanutNotifier(_peanut);
            _peanutNotifier.ShowPeanut();
        }


    }
}
