using sviteriExamen.Models;

namespace sviteriExamen.Views;

public partial class RegisterView : ContentPage
{
	public RegisterView(User user)
	{
		InitializeComponent();
        lblUser.Text = "Usuario logueado: \t"+user.UserName;

    }

    public void calculate()
    {
        Decimal total = 1500;
        Decimal amountpending = total - Decimal.Parse(txtStartAmount.Text);
        Decimal feeAmount = amountpending / 4;
        Decimal feeWithInteresting = feeAmount * Decimal.Parse("1.04");
        txtMonthPay.Text = feeWithInteresting + "";
    }

    public bool validateInfo() {

        bool valid = false;
        try
        {

            valid = Int32.Parse(txtYears.Text) > 18 && (Decimal.Parse(txtStartAmount.Text) > 0 && Decimal.Parse(txtStartAmount.Text) < 1500) &&
                (txtFecha.Date < DateTime.Now);
        }
        catch (Exception)
        {

        }

        return valid;
    }

    private void btnCalculate_Clicked_1(object sender, EventArgs e)
    {
        if (validateInfo())
        {
            this.calculate();
        }
        else
        {
            DisplayAlert("Error de validaciòn", "Corrija los datos e intente nuevamente", "OK");
        }
    }

    private void btnSummary_Clicked(object sender, EventArgs e)
    {
        if (validateInfo())
        {
            DisplayAlert("Resumen",
            "Nombre: \t\t" + txtName.Text + "\n" +
            "Apellido: \t\t" + txtLastName.Text + "\n" +
            "Edad: \t\t" + txtYears.Text + "\n" +
            "Fecha: \t\t" + txtFecha.Date.ToString("yyyy-MM-dd") + "\n" +
             "Ciudad: \t\t" + txtCity.Text + "\n" +
            "Pais: \t\t" + txtCountry.Text + "\n" +
            "Monto inicial: \t\t" + txtStartAmount.Text + "\n" +
            "Pago mensual: \t\t" + txtMonthPay.Text + "\n" +
            "Pago total: \t\t" + (Decimal.Parse(txtStartAmount.Text) + (Decimal.Parse(txtMonthPay.Text) * 4)) + "\n" +
            "", "OK");
        }
        else
        {
            DisplayAlert("Error de validaciòn", "Corrija los datos e intente nuevamente", "OK");
        }
    }

    private void btnLogout_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new LoginView());
    }
}