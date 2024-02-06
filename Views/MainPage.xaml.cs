using Neptune.Templates;

namespace Neptune.Views;

public partial class MainPage : ContentPage
{
    private readonly OptionSheet optionSheet;
    int count = 0;

    public MainPage(OptionSheet optionSheet)
    {
        InitializeComponent();
        this.optionSheet = optionSheet;
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await optionSheet.ShowAsync();
    }
}
