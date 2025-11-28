namespace Hangman
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // When any category button is clicked, navigate to game
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
    }
}