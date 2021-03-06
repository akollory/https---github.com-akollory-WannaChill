﻿using System.Collections.Generic;
using Xamarin.Forms;

namespace LoginNavigation
{
    public class MasterPageCS : ContentPage
    {

        public ListView ListView { get { return listView; } }
        ListView listView;
        public MasterPageCS()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem()
            {
                Title = "Profile",
                TargetType = typeof(ProfilePage)

            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Settings",
                TargetType = typeof(SettingsPage)

            });

            listView = new ListView
            {
                ItemsSource = masterPageItems, 
                ItemTemplate = new DataTemplate (() =>
                {
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    return imageCell;
                }),

                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };


            Padding = new Thickness(0, 40, 0, 0);
            Icon = "hamburger.png";
            Title = "Wanna CHILL";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand, 
                Children = { listView}

            };
        }
    }
}