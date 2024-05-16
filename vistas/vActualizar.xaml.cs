
//using static Android.Graphics.ColorSpace;

using System.Dynamic;
using System.Net.Http;

namespace aajila7.vistas;

public partial class vActualizar : ContentPage
{
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
        Estudiante updatedStudent = new Estudiante();
        {
            /*Codigo = int.Parse(txtCodigo.Text);
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Edad = int.Parse(txtedad.Text);*/
        };
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
        Estudiante studentToDelete = new Estudiante()
        {
            codigo = int.Parse(txtCodigo.Text),
        };

        // Call the DeleteStudent method to delete the student from your database
        //DeleteIndexBinder
       // DeleteStudent(studentToDelete);*/
        //var itemToDelete
       // var itemToDelete = (YourItemType)yourListView.SelectedItem;
        //var response = await httpClient.DeleteAsync($"your-api-url/{itemToDelete.Id}");

       /*/ if (response.IsSuccessStatusCode)
        {
            // Handle successful delete
        }
        else
        {
            // Handle error
        }*/
    }
}