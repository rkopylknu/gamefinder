using GameFinder.DI;
using GameFinder.UI.Buy;
using GameFinder.UI.Storage;
using GameFinder.Utils;
using System.Drawing;
using System.Windows.Forms;

namespace GameFinder.UI
{
    public partial class MainForm : Form, INavigator
    {
        private RepositoryModule repositoryModule { get; }

        public MainForm(RepositoryModule _repositoryModule)
        {
            repositoryModule = _repositoryModule;
            InitializeComponent();
            Navigate(Destination.Search);
        }

        public void Navigate(Destination destination)
        {
            Form form = null;
            switch (destination)
            {
                case Destination.Search: { 
                    form = new SearchForm(this, new BuyViewModel(repositoryModule));
                    break;
                }
                case Destination.Storage:
                {
                    form = new StorageForm(
                        this, 
                        new StorageViewModel(repositoryModule), 
                        new Storage.Create.CreateViewModel(repositoryModule));
                    break;
                }
            }
            if (form != null)
            {
                foreach (var child in MdiChildren) 
                    child.Close();

                form.MdiParent = this;
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(0, 0);
                form.Show();
            }
        }
    }
}
