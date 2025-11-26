namespace Hangman
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void PlayButton_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Game());

            PlayButton.IsVisible = false;

            // Show the category selection
            CategorySelection.IsVisible = true;
        }

        private async void Category_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                // Get the category from CommandParameter
                string selectedCategory = button.CommandParameter?.ToString();

                // Navigate to Game page and pass the selected category
                await Navigation.PushAsync(new Game(selectedCategory));
            }
        }

        // Back button to return to main screen
        private void Back_Clicked(object sender, EventArgs e)
        {
            // Show the Play button again
            PlayButton.IsVisible = true;

            // Hide the category selection
            CategorySelection.IsVisible = false;
        }
    }
}
