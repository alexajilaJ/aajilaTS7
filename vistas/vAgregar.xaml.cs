using System.Net;

namespace aajila7.vistas;

public partial class vAgregar : ContentPage
{
	public vAgregar()
	{
		InitializeComponent();
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
		try
		{
			WebClient cliente = new WebClient();
			var parametros = new System.Collections.Specialized.NameValueCollection();
			parametros.Add("codigo", txtCodigo.Text);
			parametros.Add("nombre", txtNombre.Text);	
			parametros.Add("apellido", txtApellido.Text);
			parametros.Add("edad", txtedad.Text);
			cliente.UploadValues("http://localhost/prueba/post.php", "POST", parametros);
			Navigation.PushAsync(new ini());
		}
		catch (Exception ex)
		{

			DisplayAlert("Alerta", ex.Message, "cerrar");
		}

    }
}