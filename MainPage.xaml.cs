namespace Photon.App;

public partial class MainPage : ContentPage
{
    int _count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		_count++;
		CounterLabel.Text = $"Current count: {_count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}

