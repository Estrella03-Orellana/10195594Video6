namespace _10195594Video6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// En el evento clicked del botón lo que realiza es que al escribir números o letras
        /// deja un espacio de por medio, y solo se pueden ingresar 10 digitos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pasando = e.OldTextValue;
            string nuevo = e.NewTextValue;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }

}
