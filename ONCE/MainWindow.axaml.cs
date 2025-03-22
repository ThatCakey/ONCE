using Avalonia.Controls;

namespace ONCE;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Viewport MainViewport = new();
            MainViewport.initialize(this.FindControl<Image>("Viewport"));

    }
}