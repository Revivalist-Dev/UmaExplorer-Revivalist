using System.Windows.Forms;
using UmaMusumeData;

namespace UmaMusumeExplorer.Controls.StoryEventViewer
{
    public partial class StoryEventViewerControl : UserControl
    {
        public StoryEventViewerControl()
        {
            InitializeComponent();
        }

        private async void StoryEventViewerControl_Load(object sender, System.EventArgs e)
        {
            await Task.Run(() =>
            {
                var manifestEntries = UmaDataHelper.GetManifestEntries();
                foreach (var entry in manifestEntries)
                {
                    Invoke(() => storyEventTreeView.Nodes.Add(entry.Name));
                }
            });
        }
    }
}