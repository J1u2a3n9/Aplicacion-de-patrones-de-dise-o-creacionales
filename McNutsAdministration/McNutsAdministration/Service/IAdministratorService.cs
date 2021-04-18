using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    public interface IAdministratorService
    {
        public bool CreateAdministrator(AdministratorModel newAdministrator);
        public bool DeleteAdministrator(long ci);
        public AdministratorModel GetAdministrator(long ci);
        public IEnumerable<AdministratorModel> GetAdministrators();
        public AdministratorModel UpdateAdministrator(long ci, AdministratorModel updateAdministrator);

    }
}
