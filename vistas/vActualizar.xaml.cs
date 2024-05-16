
//using static Android.Graphics.ColorSpace;

using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Net.Http;

namespace aajila7.vistas;

public partial class vActualizar : ContentPage
{
    private Estudiante objectestudiante;
    public vActualizar(Estudiante datos)
	{
		InitializeComponent();
        txtCodigo.Text=datos.codigo.ToString(); 
        txtNombre.Text=datos.nombre;
        txtApellido.Text=datos.apellido; 
        txtedad.Text=datos.edad.ToString();
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            // Construye los datos a enviar para la actualización
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtedad.Text);
            // Construye la URL incluyendo el código del estudiante
            string url = $"http://localhost/prueba/post.php?codigo={txtCodigo.Text}&nombre={txtNombre.Text}&apellido={txtApellido.Text}&edad={txtedad.Text}";
            // Realiza la solicitud PUT con los datos actualizados
            byte[] respuesta = cliente.UploadValues(url, "PUT", parametros);
            // Convierte la respuesta a una cadena (opcional, dependiendo de tus necesidades)
            string respuestaString = System.Text.Encoding.UTF8.GetString(respuesta);

            // Una vez actualizado, regresa a la página principal
            Navigation.PushAsync(new vistas.ini());
        }
        catch (Exception ex)
        {
            DisplayAlert("Alerta", ex.Message, "cerrar");
        }
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            // Construye la URL incluyendo el código del estudiante
            string url = $"http://localhost/prueba/post.php?codigo={txtCodigo.Text}";
            // Realiza la solicitud DELETE
            cliente.UploadString(url, "DELETE", "");
            // Una vez eliminado, regresa a la página principal
            Navigation.PushAsync(new vistas.ini());
        }
        catch (Exception ex)
        {
            DisplayAlert("Alerta", ex.Message, "cerrar");
        }
    }
}