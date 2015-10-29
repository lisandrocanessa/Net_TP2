using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        UsuarioLogic UsuarioNegocio;
        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }
        public void Menu()
        {
            String op="0";
            do
            {
                Console.WriteLine("MENU \n1.Listado General \n2.Consulta \n3.Agregar \n4.Modificar \n5.Eliminar \n6.Salir \nIngrese Opción");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1": { ListadoGeneral(); break; }
                    case "2": { Consulta(); break; }
                    case "3": { Agregar(); break; }
                    case "4": { Modificar(); break; }
                    case "5": { Eliminar(); break; }
                    default: { op = "6"; break; }
                }
            } while (op !="6");
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese ID de usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La ID ingresada debe ser un numero entero!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar ");
                Console.ReadKey();
            }
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a modificar: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario usr = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese nombre: ");
                usr.Persona.Nombre = Console.ReadLine();
                Console.Write("Ingrese apellido: ");
                usr.Persona.Apellido = Console.ReadLine();
                Console.Write("Ingrese nombre de usuario: ");
                usr.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese clave: ");
                usr.Clave = Console.ReadLine();
                Console.Write("Ingrese email: ");
                usr.Email = Console.ReadLine();
                Console.Write("Ingrese habilitación del usuario (1-SI / otro-NO): ");
                usr.Habilitado = (Console.ReadLine() == "1");
                usr.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usr);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La ID ingresada debe ser un numero entero!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar ");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Usuario usr = new Usuario();

            Console.Clear();
            Console.Write("Ingrese nombre: ");
            usr.Persona.Nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            usr.Persona.Apellido = Console.ReadLine();
            Console.Write("Ingrese nombre de usuario: ");
            usr.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese clave: ");
            usr.Clave = Console.ReadLine();
            Console.Write("Ingrese email: ");
            usr.Email = Console.ReadLine();
            Console.Write("Ingrese habilitación del usuario (1-SI / otro-NO): ");
            usr.Habilitado = (Console.ReadLine() == "1");
            usr.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usr);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", usr.ID);
        }

        public void Consulta()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La ID ingresada debe ser un numero entero!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("Presione una tecla para continuar ");
                Console.ReadKey();
            }
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Persona.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Persona.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            //\t dentro de un string representa un TAB
            Console.WriteLine();

        }
    }
}
