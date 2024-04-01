using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HuygensLight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            Image = new WriteableBitmap(512, 512, 96, 96, PixelFormats.Bgr32, null);

            CompositionTarget.Rendering += OnRender;
        }

        private void OnRender(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public WriteableBitmap Image { get; private set; }
    }
}