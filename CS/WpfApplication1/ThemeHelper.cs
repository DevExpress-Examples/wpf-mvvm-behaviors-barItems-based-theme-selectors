using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Bars;
using System.Reflection;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace ThemeHelperWPF
{
    public static class ThemeHelper
    {
        public static void InitThemeSubItems(BarSubItem barSubTheme) 
        {
            InitThemeSubItems(barSubTheme, true);
        }
        public static void InitThemeSubItems(BarSubItem barSubTheme, bool _UseLargeIcon=true)
        {
            foreach (Theme theme in Theme.Themes)
            {
                if (theme.Name == "HybridApp") break;
                BarButtonItem item = new BarButtonItem()
                {
                    Content = theme.Name,
                    Glyph = LoadImageByThemeName(theme.Name, _UseLargeIcon),
                };
                item.ItemClick += new ItemClickEventHandler(item_ItemClick);
                barSubTheme.ItemLinks.Add(item);
            }
        }
        public static void InitThemeGallery(RibbonGalleryBarItem galleryBarItem)
        {
            InitThemeGallery(galleryBarItem, true);
        }
        public static void InitThemeGallery(RibbonGalleryBarItem galleryBarItem, bool _UseLargeIcon=true)
        {
            InitThemeGallery(galleryBarItem.Gallery, _UseLargeIcon);
        }
        public static void InitThemeGallery(Gallery gallery)
        {
            InitThemeGallery(gallery, true);
        }
        public static void InitThemeGallery(Gallery gallery, bool _UseLargeIcon = true)
        {
            gallery.ItemClick += new GalleryItemEventHandler(Gallery_ItemClick);
            foreach (Theme theme in Theme.Themes)
            {
                if (theme.Name == "HybridApp") break;
                gallery.Groups[0].Items.Add(new GalleryItem()
                {
                    Caption = theme.Name,
                    Glyph = LoadImageByThemeName(theme.Name, _UseLargeIcon)
                });
            }
        }
        static void Gallery_ItemClick(object sender, GalleryItemEventArgs e)
        {
            ThemeManager.ApplicationThemeName = e.Item.Caption.ToString();
        }
        static void item_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemeManager.ApplicationThemeName = e.Item.Content.ToString();
        }
        private static ImageSource LoadImageByThemeName(string name, bool _UseLargeIcon)
        {
            string fileName = null;
            if (_UseLargeIcon) 
            {
                fileName = name + "_48x48";
            }
            else
            {
                fileName = name + "_16x16";
            }
            return new BitmapImage(new Uri(@"pack://application:,,,/"
             + Assembly.GetExecutingAssembly().GetName().Name
             + ";component/"
             + "Images/" + fileName + ".png", UriKind.Absolute));
        }
    }
}
