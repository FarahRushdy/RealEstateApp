using PropertyApp.ViewModel;

namespace PropertyApp.View;

public partial class Details : ContentPage
{
	public Details(Model.Property SelectedProperty)
	{
		InitializeComponent();
		var viewModel = new DetailsViewModel() { SelectedProperty = SelectedProperty };
		viewModel.PropertyImages = SelectedProperty.Images.Take(2).ToList();
		viewModel.MoreItems = SelectedProperty.Images.Count - 2;

		this.BindingContext = viewModel;
	}
}