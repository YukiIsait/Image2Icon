using Image2Icon.ViewModels;

using System.Windows;

namespace Image2Icon.Views;

public partial class MainWindow: Window {
    public MainWindow() {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private void WindowDragOver(object sender, DragEventArgs e) {
        if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
            e.Effects = DragDropEffects.Link;
        } else {
            e.Effects = DragDropEffects.None;
        }
        e.Handled = true;
    }

    private void WindowDrop(object sender, DragEventArgs e) {
        if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0) {
            ((MainWindowViewModel) DataContext).ImagePath = files[0];
        }
    }
}
