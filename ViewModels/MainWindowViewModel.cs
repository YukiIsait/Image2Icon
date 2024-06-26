﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Image2Icon.Models;
using Image2Icon.Utils;

using Microsoft.Win32;

using System;
using System.IO;
using System.Windows;

namespace Image2Icon.ViewModels;

public partial class MainWindowViewModel: ObservableObject {

    [ObservableProperty]
    private string? imagePath;

    [ObservableProperty]
    private bool shouldNormalizeAspectRatio = false;

    public IconSizeModel IconSizes { get; } = new IconSizeModel {
        Size256 = true,
        Size48 = true,
        Size32 = true,
        Size24 = true,
        Size16 = true
    };

    public MainWindowViewModel() { }

    [RelayCommand]
    private void OpenImageFile() {
        OpenFileDialog openFileDialog = new() {
            Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*"
        };
        if (File.Exists(ImagePath)) {
            openFileDialog.InitialDirectory = Path.GetDirectoryName(ImagePath);
            openFileDialog.FileName = ImagePath;
        }
        if (openFileDialog.ShowDialog() != true) {
            return;
        }
        ImagePath = openFileDialog.FileName;
    }

    [RelayCommand]
    private void Convert() {
        if (!File.Exists(ImagePath)) {
            MessageBox.Show("Image file does not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }
        SaveFileDialog saveFileDialog = new() {
            Filter = "Icon files (*.ico)|*.ico|All files (*.*)|*.*",
            InitialDirectory = Path.GetDirectoryName(ImagePath),
            FileName = Path.GetFileNameWithoutExtension(ImagePath)
        };
        if (saveFileDialog.ShowDialog() != true) {
            return;
        }
        try {
            ImageConversionUtil.ConvertImageToIcon(ImagePath!, saveFileDialog.FileName, IconSizes.Sizes, ShouldNormalizeAspectRatio);
            MessageBox.Show("Conversion completed.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        } catch (Exception e) {
            MessageBox.Show($"{e.Message[0].ToString().ToUpper()}{e.Message.Substring(1)}.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
