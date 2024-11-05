using MauiNet8MVVMTemplate.ViewModels;

namespace MauiNet8MVVMTemplate.Views;

public partial class DemoView : ContentPage
{
	public DemoView(DemoViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
    }
}