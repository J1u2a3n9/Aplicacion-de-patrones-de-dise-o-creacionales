using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    class PeanutNotifier
    {
        private PeanutModelAndService _peanutModelAndService;
        public PeanutNotifier(PeanutModelAndService peanutModelAndService)
        {
            _peanutModelAndService = peanutModelAndService;
        }

        public void ShowPeanut()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Nombre: {_peanutModelAndService.Name}");
            Console.WriteLine($"Fecha de elaboracion: {_peanutModelAndService.ElaborationDate.ToString()}");
            Console.WriteLine($"Fecha de expiracion: {_peanutModelAndService.ExpirationDate.ToString()}");
            Console.WriteLine($"Precio Unitario: {_peanutModelAndService.UnitCost}");
            Console.WriteLine($"Precio Por mayor: {_peanutModelAndService.WholesalePrice}");
            Console.WriteLine($"Cantidad en stock: {_peanutModelAndService.Amount}");
            Console.WriteLine($"La produccion de este sabor es {(_peanutModelAndService.ProductionStatus.ToString())}");
        }
    }
}
