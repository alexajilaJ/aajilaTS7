namespace aajila7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        public class Estudiante
        {
            public int codigo { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public int edad { get; set; }

        }
    }

}
