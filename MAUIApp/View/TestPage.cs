namespace MyMAUIApp.View;

public class TestPage : ContentPage
{
    int count = 0;

    Label lblCounter;

    public TestPage()
    {

        var scrollView = new ScrollView();

        var stackLayout = new StackLayout();
        scrollView.Content = stackLayout;

        lblCounter = new Label
        {

            Text = "Count 0",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center

        };

        stackLayout.Children.Add(lblCounter);


        var btnCount = new Button
        {
            Text = "Click to Count",
            HorizontalOptions = LayoutOptions.Center
        };

        stackLayout.Children.Add(btnCount);
        btnCount.Clicked += OnCounterClicked;


        this.Content = scrollView;


    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        count++;

        lblCounter.Text = $"Count :{count}";
        SemanticScreenReader.Announce(lblCounter.Text);

    }

}