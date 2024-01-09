using sviteriExamen.Models;
using System.Xml.Linq;

namespace sviteriExamen.Views;

public partial class LoginView : ContentPage
{
	
	public LoginView()
	{
		InitializeComponent();
	}

	public void executeLogin()
	{
		String userName = txtUser.Text;
		String password = txtPass.Text;
		UserLib lib = new UserLib();
		var user = lib.login(userName, password);
		if (user != null)
		{
			DisplayAlert("Ingreso Correcto", "Bienvenido "+user.UserName, "OK");
            /*Go to Register*/
            App.Current.MainPage = new NavigationPage(new RegisterView(user));

        }
		else
		{
            DisplayAlert("Credenciales incorrectas", "Intente nuevamente" , "OK");
        }
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
		this.executeLogin();
    }

    private void btnAbout_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Acerca de ",
           "Nombre: \t  Santiago Viteri \n" +
           "Versión: \t  1.0 \n" +
           "Uisrael 2024" +
           "", "OK");
    }
}