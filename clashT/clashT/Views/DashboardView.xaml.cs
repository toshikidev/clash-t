using ReactiveUI;

namespace clashT.Views
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView
    {
        public DashboardView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {

            });
        }
    }
}
