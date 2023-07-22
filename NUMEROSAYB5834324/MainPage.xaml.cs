namespace NUMEROSAYB5834324;

public partial class MainPage : ContentPage
{

    /// <summary>
    /// <Createddate>22/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>22/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL LABEL COLORES Y LA IMAGEN TAMAÑO
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON 
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double NumA = Convert.ToDouble(NB.Text);
        double NumB = Convert.ToDouble(NB.Text);

        double resultado = Math.Pow((NumA + NumB), 2) / 2;

		Re.Text = "El resultado es: " + resultado;


    }
}

