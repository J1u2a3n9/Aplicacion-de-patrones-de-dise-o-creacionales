using System;
using System.Collections.Generic;
using System.Text;

namespace McNutsAdministration
{
    class PrincipalMainNotifier
    {
        private AdministratorModel _administratorModel;
        public PrincipalMainNotifier()
        {
            _administratorModel = new AdministratorModel();

        }
        public void LaunchPrincipalMenu()
        {
            int opc;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("         BIENVENIDO AL SISTEMA DE ADMINISTRACION MCNUTS        ");
                Console.WriteLine("1) Crear Administrador");
                Console.WriteLine("2) Actualizar Administrador");
                Console.WriteLine("3) Visualizar Administrador");
                Console.WriteLine("4) Visualizar Administradores");
                Console.WriteLine("5) Eliminar Administrador");
                Console.WriteLine("6) Crear un sabor de Mani especifico");

                Console.Write("Que opcion desea ? :");
                opc = Convert.ToInt32(Console.ReadLine());
                SelectOption(opc);
            } while (opc < 7);

        }

        private void SelectOption(int opc)
        {
            switch(opc)
            {
                case 1:
                    LaunchCreateAdministrator();
                    break;
                case 2:
                    LaunchUpdateAdministrator();
                    break;
                case 3:
                    LauchVisualizeAdministrator();
                    break;
                case 4:
                    LaunchVisualizeAdministrators();
                    break;
                case 5:
                    LaunchDeleteAdministrator();
                    break;
                case 6:
                    LauchCreatePeanutFlavor();
                    break;
            }
        }

        private void LauchCreatePeanutFlavor()
        {
            string flavor = LaunchPeanutSelection();
            AdministrationAccess.Access.CreateFlavor(flavor);
        }

        private string LaunchPeanutSelection()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("         ESTOS SON NUESTROS SABORES DISPONIBLES EN MCNUTS        ");
            Console.WriteLine(" Miel y Mostaza");
            Console.WriteLine(" Leche condesada y coco");
            Console.WriteLine(" Oreo");
            Console.WriteLine(" Picante");
            Console.Write("Que opcion desea ? :");
            return Convert.ToString(Console.ReadLine());
        }

        private void LaunchDeleteAdministrator()
        {
            long ci = LaunchRequestCi();
            AdministrationAccess.Access.DeleteAdministrator(ci);
        }

        private void LaunchVisualizeAdministrators()
        {
            AdministrationAccess.Access.ShowAdministrators();
        }

        private void LauchVisualizeAdministrator()
        {
            long ci = LaunchRequestCi();
            AdministrationAccess.Access.ShowAdministrator(ci);
        }

        private long LaunchRequestCi()
        {
            long ci;
            Console.Write("Ingrese su Ci: ");
            ci = Convert.ToInt64(Console.ReadLine());
            return ci;
        }

        private void LaunchUpdateAdministrator()
        {
            var updateAdministrator = LaunchRequestData(" POR FAVOR INGRESE LOS DATOS NUEVOS DEL YA EXISTENTE ADMINISTRADOR");
            AdministrationAccess.Access.UpdateAdministrator(updateAdministrator.Ci,updateAdministrator);
        }

        private void LaunchCreateAdministrator()
        {
            var newAdministrator = LaunchRequestData("POR FAVOR INGRESE LOS DATOS DEL NUEVO ADMINISTRADOR");
            AdministrationAccess.Access.CreateAdministrator(newAdministrator);
        }

        private AdministratorModel LaunchRequestData(string category)
        {
            long ci, phone;
            string name, surName, address;
            DateTime dateOfBirth;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"         {category}         ");
            Console.Write("Nombre: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Apellido: ");
            surName = Convert.ToString(Console.ReadLine());
            Console.Write("Direccion: ");
            address = Convert.ToString(Console.ReadLine());
            Console.Write("Ci: ");
            ci = Convert.ToInt64(Console.ReadLine());
            Console.Write("Numero: ");
            phone = Convert.ToInt64(Console.ReadLine());
            Console.Write("Fecha de nacimiento: ");
            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            _administratorModel.Ci = ci;
            _administratorModel.Name = name;
            _administratorModel.SurName = surName;
            _administratorModel.Address = address;
            _administratorModel.DateOfBirth = dateOfBirth;
            _administratorModel.Phone = phone;
            return _administratorModel;

        }

    }
}
