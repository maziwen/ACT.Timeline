﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Interop;
using FairyZeta.Framework.WPF.ViewModels;

namespace FairyZeta.Framework.WPF.Views
{
    /// <summary> ColorDialogView
    /// </summary>
    public partial class ColorDialogView : UserControl
    {
        public ColorDialogView()
        {            
            this.InitializeComponent();

            this.Color = Colors.White;

            this.Loaded += this.ColorDialogContent_Loaded;
            this.PredefinedColorsListBox.SelectionChanged += this.PredefinedColorsListBox_SelectionChanged;
            this.RTextBox.TextChanged += (s, e) => this.ToHex();
            this.GTextBox.TextChanged += (s, e) => this.ToHex();
            this.BTextBox.TextChanged += (s, e) => this.ToHex();
            this.ATextBox.TextChanged += (s, e) => this.ToHex();
            this.HexTextBox.LostFocus += (s, e) =>
            {
                var color = Colors.White;

                try
                {
                    color = (Color)ColorConverter.ConvertFromString(this.HexTextBox.Text);
                }
                catch
                {
                }

                this.RTextBox.Text = color.R.ToString();
                this.GTextBox.Text = color.G.ToString();
                this.BTextBox.Text = color.B.ToString();
                this.ATextBox.Text = color.A.ToString();

                this.ToPreview();
            };
        }

        private void ColorDialogContent_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (PredefinedColor predefinedColor in this.PredefinedColorsListBox.Items)
            {
                if (predefinedColor.Color == this.Color)
                {
                    this.PredefinedColorsListBox.SelectedItem = predefinedColor;

                    var item =
                        this.PredefinedColorsListBox.ItemContainerGenerator.ContainerFromItem(predefinedColor)
                        as ListBoxItem;

                    if (item != null)
                    {
                        item.Focus();
                    }
                }
            }
        }

        public Color Color { get; set; }

        public void Apply()
        {
            var color = Colors.White;

            try
            {
                color = (Color)ColorConverter.ConvertFromString(this.HexTextBox.Text);
            }
            catch
            {
            }

            this.Color = color;
        }

        private void PredefinedColorsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.PredefinedColorsListBox.SelectedItem != null)
            {
                var color = ((PredefinedColor)this.PredefinedColorsListBox.SelectedItem).Color;

                this.RTextBox.Text = color.R.ToString();
                this.GTextBox.Text = color.G.ToString();
                this.BTextBox.Text = color.B.ToString();
                this.ATextBox.Text = color.A.ToString();
            }
        }

        private void ToHex()
        {
            byte a, r, g, b;
            byte.TryParse(this.ATextBox.Text, out a);
            byte.TryParse(this.RTextBox.Text, out r);
            byte.TryParse(this.GTextBox.Text, out g);
            byte.TryParse(this.BTextBox.Text, out b);

            var color = Color.FromArgb(a, r, g, b);

            this.HexTextBox.Text = color.ToString();

            this.ToPreview();
        }

        private void ToPreview()
        {
            var color = Colors.White;

            try
            {
                color = (Color)ColorConverter.ConvertFromString(this.HexTextBox.Text);
            }
            catch
            {
            }

            this.PreviewRectangle.Fill = new SolidColorBrush(color);
        }
    }
}
