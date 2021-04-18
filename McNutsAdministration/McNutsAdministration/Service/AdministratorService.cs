using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace McNutsAdministration
{
    class AdministratorService : IAdministratorService
    {
        private List<AdministratorModel> _administrator;
        public AdministratorService()
        {
            _administrator = new List<AdministratorModel>();
            _administrator.Add(new AdministratorModel()
            {
                Ci = 14419455,
                Name = "Juan Luis",
                SurName = "Canedo Villarroel",
                Phone = 78348873,
                DateOfBirth = new DateTime(1999,11,06),
                Address = "Av Blanco Galindo"
            });
            _administrator.Add(new AdministratorModel()
            {
                Ci = 3003688,
                Name = "Camila",
                SurName = "Rojas Canedo",
                Phone = 71745068,
                DateOfBirth = new DateTime(1999, 09, 06),
                Address = "Av Juan Pablo"
            });
            _administrator.Add(new AdministratorModel()
            {
                Ci = 15519488,
                Name = "Daniela",
                SurName = "Nogales",
                Phone = 77417504,
                DateOfBirth = new DateTime(2000, 04, 06),
                Address = "Av America"
            });
        }
        public bool CreateAdministrator(AdministratorModel newAdministrator)
        {
            ExistingAdministrator(newAdministrator.Ci);
            _administrator.Add(newAdministrator);
            return true;
        }

        public bool DeleteAdministrator(long ci)
        {
            var administratorToDelete = _administrator.FirstOrDefault(a => a.Ci ==ci);
            _administrator.Remove(administratorToDelete);
            return true;
        }

        public AdministratorModel GetAdministrator(long ci)
        {
            return _administrator.FirstOrDefault(a => a.Ci == ci);
        }

        public IEnumerable<AdministratorModel> GetAdministrators()
        {
            return _administrator.OrderBy(a => a.Name);
        }

        public AdministratorModel UpdateAdministrator(long ci,AdministratorModel updateAdministrator)
        {
            var administratorToUpdate = GetAdministrator(ci);
            administratorToUpdate.Name = updateAdministrator.Name ?? administratorToUpdate.Name;
            administratorToUpdate.SurName = updateAdministrator.SurName ?? administratorToUpdate.SurName;
            administratorToUpdate.Phone = updateAdministrator.Phone ?? administratorToUpdate.Phone;
            administratorToUpdate.DateOfBirth = updateAdministrator.DateOfBirth ?? administratorToUpdate.DateOfBirth;
            administratorToUpdate.Address = updateAdministrator.Address ?? administratorToUpdate.Address;
            return administratorToUpdate;
        }

        private bool ExistingAdministrator(long ci)
        {
            bool answer = false;
            var client = _administrator.FirstOrDefault(a => a.Ci == ci);
            if(client!=null)
            {
                throw new Exception($"El administrador con id {ci} ya existe");
            }
            return answer;
        }
    }
}
