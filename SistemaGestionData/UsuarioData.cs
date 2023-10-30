using SistemaGestionEntities;
using SistemaGestionBussiness;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData

{
    public class UsuarioData
    {
       
        public static Usuario ObtenerUsuario(int id)


        {
            try
            {
                using (var context = new SistemaGestionContext())
            {
                return context.Usuarios.FirstOrDefault(us => us.Id == id);
            }
            }
            catch (Exception ex)
            {
            
            Console.WriteLine("Error al obtener el producto: "+ ex.Message);

                return null; 
            
            }
        }


        public static List<Usuario> ListarUsuario()
        {
            try
            { 
            using (var context = new SistemaGestionContext())
            {
                return context.Usuarios.ToList();
            }
        }
            catch (Exception ex) 
            {
            
            Console.WriteLine("Error al obtener el producto: "+ ex.Message);

                return null;
            
            }
            }

        public static void CrearUsuario(Usuario usuario)
        { 
            try
            { 
            using (var context = new SistemaGestionContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }
        }

        public static void EliminarUsuario(int Id)
        {
            using (var context = new SistemaGestionContext())

            {
                try
                { 
                var usuarioexistente = context.Usuarios.FirstOrDefault(us => us.Id == Id);
                if (usuarioexistente != null)
                {

                    context.Usuarios.Remove(usuarioexistente);
                    context.SaveChanges();

                }
                }
                catch (Exception ex)
            {

                    Console.WriteLine("Error al obtener el producto: " + ex.Message);

                    return;
                }
            }

        }

        public static bool Validarloguin(UsuarioLogin usuarioLogin)
        {

            try
            {
                using (var context = new SistemaGestionContext())
                {
                    var usuario = context.Usuarios.Where(x => x.NombreUsuario == usuarioLogin.NombreUsuario && x.Contraseña == usuarioLogin.Contraseña);
                    if (usuario.Any())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return false;
            }

        }

        public static void ModificarUsuario( Usuario usuarioModificado)
        {
            try


            { 


            using (var context = new SistemaGestionContext())

            {

                var usuarioExistente = context.Usuarios.FirstOrDefault(us => us.Id == usuarioModificado.Id);
                if (usuarioExistente != null)
                {
                    usuarioExistente.Id = usuarioModificado.Id;
                    usuarioExistente.Nombre = usuarioModificado.Nombre;
                    usuarioExistente.Apellido = usuarioModificado.Apellido;
                    usuarioExistente.NombreUsuario = usuarioModificado.NombreUsuario;
                    usuarioExistente.Contraseña = usuarioModificado.Contraseña;
                    usuarioExistente.Mail = usuarioModificado.Mail;
                    context.SaveChanges();


                }
            }
            }


            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el producto: " + ex.Message);

                return;
            }
         }
    }
}










