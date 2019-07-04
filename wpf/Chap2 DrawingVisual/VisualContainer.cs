using System.Windows;
using System.Windows.Media;

namespace wpf.Chap2_DrawingVisual
{
    public class VisualContainer : FrameworkElement
    {
        private SectorVisual _visual = new SectorVisual();

        protected override Visual GetVisualChild(int index)
        {
            return _visual;
        }

        protected override int VisualChildrenCount
        {
            get
            {
                return 1;
            }
        }
    }
}
