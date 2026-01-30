namespace MyMAUIApp;

public partial class TestXML : ContentPage
{
    int count = 0;
    public TestXML()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
        {
            lblCounter.Text = $"Count {count}";
        }
        else
        {
            lblCounter.Text = $"Count {count}";
        }

        SemanticScreenReader.Announce(lblCounter.Text);

    }
}