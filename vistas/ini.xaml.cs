using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace aajila7.vistas;

public partial class ini : ContentPage
{
	private const string url = "http://localhost/prueba/post.php";
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Estudiante> estud;
	public ini()
	{
		InitializeComponent();
		obtener();
	}
	public async void obtener()
	{
		var content = await cliente.GetStringAsync(url);
		List<Estudiante> mostrarEstudiante = JsonConvert.DeserializeObject<List<Estudiante>>(content);
		estud = new ObservableCollection<Estudiante>(mostrarEstudiante);
		listaEstudiantes.ItemsSource = estud;
	}

    private void btnIngreso_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new vAgregar());
    }

    private void listaEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		var objetoestudiante=(Estudiante)e.SelectedItem;
		Navigation.PushAsync(new vActualizar(objetoestudiante));
    }
}