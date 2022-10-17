namespace MauiAppImageTest;

public partial class MainPage : ContentPage
{
	int count = 0;

    public string ImageUrlBad2 { get; set; } = "http://books.google.com/books/content?id=ArLbO9YdVMMC&printsec=frontcover&img=1&zoom=5&edge=curl&source=gbs_api";
    public MainPage()
	{
		InitializeComponent();
	}
	void onClick (object sender, EventArgs e)
	{
        dynamicImage.Source = ImageSource.FromUri(new System.Uri(ImageUrlBad2));
		//dynamicImage.Source = ImageSource.FromUri (new System.Uri(ImageUrlBad2.Replace ("&","&amp;")));
		System.Diagnostics.Debug.WriteLine("Changed imagesource");
	}
}

