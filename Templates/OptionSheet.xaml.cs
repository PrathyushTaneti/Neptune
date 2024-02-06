using The49.Maui.BottomSheet;
namespace Neptune.Templates;

public partial class OptionSheet : BottomSheet
{
	public OptionSheet()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.DismissAsync();
    }
}