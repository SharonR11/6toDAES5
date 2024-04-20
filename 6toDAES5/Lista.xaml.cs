using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _6toDAES5
{
    /// <summary>
    /// Lógica de interacción para Lista.xaml
    /// </summary>
    public partial class Lista : Window
    {
        private string connectionString = "Data Source=DESKTOP-BBBE09E\\SQLEXPRESS;Initial Catalog=Neptuno;User Id=userSharon;Password=010203";

        public Lista()
        {
            InitializeComponent();
            MostrarEmpleados();
        }
        private void MostrarEmpleados()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("USP_ListarEmpleados", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleado empleado = new Empleado(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetString(3),
                                    reader.GetDateTime(4)
                                );

                                dataGrid.Items.Add(empleado);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void btnRegistrarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

    }
}
