namespace CsFlowMonitor
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for ObjectDiffWindowControl.
    /// </summary>
    public partial class ObjectDiffWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDiffWindowControl"/> class.
        /// </summary>
        public ObjectDiffWindowControl()
        {
            this.InitializeComponent();
            textBox1.Text = "Here will be some object diff one day.";
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "ObjectDiffWindow");
        }
    }
}