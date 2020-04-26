using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfIconButtonControlLibrary
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfIconButtonControlLibrary"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfIconButtonControlLibrary;assembly=WpfIconButtonControlLibrary"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:IconButton/>
    ///
    /// </summary>
    public class IconButton : Button
    {
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
        }

        #region PathData

        public static readonly DependencyProperty PathDataProperty =
            DependencyProperty.Register(nameof(PathData), typeof(Geometry), typeof(IconButton), new PropertyMetadata(Geometry.Empty));

        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        #endregion

        #region TextProperty
        
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(IconButton),
                new PropertyMetadata(default(string)));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        #endregion

        #region Orientation

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register(nameof(Orientation), typeof(Orientation), typeof(IconButton),
                new PropertyMetadata(default(Orientation)));

        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        #endregion

        #region TextVisibility

        public static readonly DependencyProperty TextVisibilityProperty =
            DependencyProperty.Register(nameof(TextVisibility), typeof(Visibility), typeof(IconButton),
                new PropertyMetadata(default(Visibility)));

        public Visibility TextVisibility
        {
            get { return (Visibility)GetValue(TextVisibilityProperty); }
            set { SetValue(TextVisibilityProperty, value); }
        }

        #endregion

        #region IconVisibility

        public static readonly DependencyProperty IconVisibilityProperty =
            DependencyProperty.Register(nameof(IconVisibility), typeof(Visibility), typeof(IconButton),
                new PropertyMetadata(default(Visibility)));

        public Visibility IconVisibility
        {
            get { return (Visibility)GetValue(IconVisibilityProperty); }
            set { SetValue(IconVisibilityProperty, value); }
        }

        #endregion
    }
}
