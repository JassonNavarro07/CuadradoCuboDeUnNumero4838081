namespace CuadradoCuboDeUnNumero4838081
{

    ///<Summary>
    ///<Createddate>29/05/2024</createddate>
    ///<company></company>
    ///<lastmodificationdate>02/06/2024</lastmodificationdate>
    ///<lastmodificationdescription>
    ///
    ///</lastmodificationdescription>
    ///<lastmodifierautor>Jasson Navarro</lastmodifierautor>
    ///</Summary>
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            
        }
        #region evento button
        private void Button_Clicked(object sender, EventArgs e)
        {
            double cubo, cuadrado, numero;
            numero = Convert.ToDouble(entry1.Text);
            cubo = numero * numero * numero;
            cuadrado = numero* numero;
            entry2.Text =  cubo.ToString();
            entry3.Text = cuadrado.ToString();
        }
        #endregion 
    }

}
