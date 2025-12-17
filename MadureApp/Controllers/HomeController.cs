using MadureApp.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace MadureApp.Controllers
{
    public class HomeController : Controller
    {

        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MadureDB"].ConnectionString;

   
        public ActionResult Index()
        {
            
            var productosActivos = GetActiveProducts();
            return View(productosActivos);
        }

       
        public ActionResult Admin(int? editarId)
        {
            
            var productos = GetAllProducts();

 
            if (editarId.HasValue)
            {
                var productoEditar = productos.FirstOrDefault(p => p.ID_Producto == editarId.Value);
                if (productoEditar != null)
                {
                    ViewBag.ProductoEditar = productoEditar;
                }
            }

            return View(productos);
        }

        [HttpPost]
        public ActionResult SaveProduct(Producto producto)
        {
            if (ModelState.IsValid)
            {
                if (producto.ID_Producto == 0)
                {
                    InsertProduct(producto);
                }
                else
                {
                    UpdateProduct(producto);
                }
            }

            return RedirectToAction("Admin");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DeleteProduct(id);
            return RedirectToAction("Admin");
        }


        private List<Producto> GetActiveProducts()
        {
            var productos = new List<Producto>();

            using (var conn = new SqlConnection(connectionString))
            {

                var cmd = new SqlCommand("SELECT * FROM Productos WHERE Estado = 1 ORDER BY ID_Producto", conn);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            ID_Producto = (int)reader["ID_Producto"],
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Precio = (decimal)reader["Precio"],
                            Stock = (int)reader["Stock"],
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return productos;
        }

        private List<Producto> GetAllProducts()
        {
            var productos = new List<Producto>();

            using (var conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM Productos ORDER BY ID_Producto", conn);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            ID_Producto = (int)reader["ID_Producto"],
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Precio = (decimal)reader["Precio"],
                            Stock = (int)reader["Stock"],
                            Estado = (bool)reader["Estado"]
                        });
                    }
                }
            }

            return productos;
        }

        private void InsertProduct(Producto producto)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(
                    "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, Estado) " +
                    "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @Estado)", conn);

                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.Parameters.AddWithValue("@Estado", producto.Estado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateProduct(Producto producto)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(
                    "UPDATE Productos SET Nombre=@Nombre, Descripcion=@Descripcion, " +
                    "Precio=@Precio, Stock=@Stock, Estado=@Estado WHERE ID_Producto=@Id", conn);

                cmd.Parameters.AddWithValue("@Id", producto.ID_Producto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.Parameters.AddWithValue("@Estado", producto.Estado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteProduct(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("DELETE FROM Productos WHERE ID_Producto=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}