namespace Hangman
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void PlayTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game());
        }


    }

}
