using PropertyApp.ViewModel;

namespace PropertyApp.View;

public partial class Landing : ContentPage
{
	public Landing()
	{
		InitializeComponent();
		this.BindingContext = new LandingViewModel();
		(SectionList.Children[0] as RadioButton).IsChecked = true;
	}
}