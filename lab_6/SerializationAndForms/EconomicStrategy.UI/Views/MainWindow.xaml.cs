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
using EconomicStrategy.Model;
using System.Windows.Media.Animation;
using System.Media;
using EconomicStrategy.UI.ViewModel;

namespace EconomicStrategy.UI.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowDataModel model;
        private Storyboard storyBoard;
        private MediaPlayer mediaPlayer;

        public MainWindow(MainWindowDataModel model)
        {
            this.model = model;
            InitializeComponent();
            generateMapGrid();
            drawMap();
            generateBuilds();
            generateResources();
            addStoryBoard();
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri(@"C:\Files\Musics\Mono\01 - Studio Albums\2001 - Under The Pipal Tree [Tzadik, TZ 7237]\01. Karelia (Opus 2).mp3"));
            
        }

        private void addStoryBoard()
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 1.0;
            myDoubleAnimation.To = 0.0;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(2000));
            myDoubleAnimation.AutoReverse = true;

            storyBoard = new Storyboard();
            storyBoard.Children.Add(myDoubleAnimation);
            Storyboard.SetTargetName(myDoubleAnimation, saveButton.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Button.OpacityProperty));

            this.RegisterName(saveButton.Name, saveButton);
        }

        private void generateMapGrid()
        {
            Map map = model.game.getMap();
            for (int i = 0; i < map.width; i++)
            {
                mapGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < map.height; i++)
            {
                mapGrid.RowDefinitions.Add(new RowDefinition());
            }
        }

        private void drawMap()
        {
            mapGrid.Children.Clear();
            model.map.Clear();
            Map map = model.game.getMap();
            double step = mapGrid.Width / map.width;
            for (int x = 0; x < map.width; x++)
            {
                for (int y = 0; y < map.height; y++)
                {
                    MapObject obj = map.get(x, y);
                    TextBlock text = new TextBlock() { Text = obj == null ? "" : obj.ToString() };
                    Grid.SetColumn(text, x);
                    Grid.SetRow(text, y);
                    mapGrid.Children.Add(text);
                    if (obj != null) {
                        model.map.Add(new MapItem() { build = obj.ToString(), x = x, y = y });
                    }
                }
            }
        }

        private void generateResources()
        {
            ResourceList resources = model.game.getResourceList();
            model.resources.Clear();
            resources.get().Select(type => resources.get(type)).Select(resource => new ResourceItem() { resource = resource.getResourceType().getName(), count = resource.getCount() }).ToList().ForEach(item => model.resources.Add(item));
        }

        private void generateBuilds()
        {
            model.builds.Clear();
            BuildType.VALUES.Select(build => build.getName()).ToList().ForEach(name => model.builds.Add(name));
            ReliefType.VALUES.Select(build => build.getName()).ToList().ForEach(name => model.builds.Add(name));
            resourcesGrid.Items.Refresh();
        }

        private void buildButton_Click(object sender, RoutedEventArgs e)
        {
            try {
                String buildName = (String)buildsList.SelectedItem;
                int x = Int32.Parse(xField.Text);
                int y = Int32.Parse(yField.Text);
                MapEnum menum = null;
                MapObject mobj = null;
                try
                {
                    menum = BuildType.VALUES.Where(type => type.getName() == buildName).First();
                    if (menum != null)
                    {
                        mobj = new Build((BuildType)menum);
                    }
                }
                catch (Exception) { }
                try
                {
                    menum = ReliefType.VALUES.Where(type => type.getName() == buildName).First();
                    if (menum != null)
                    {
                        mobj = new Relief((ReliefType)menum);
                    }
                }
                catch (Exception) { }
                model.game.create(mobj, x, y);
                drawMap();
                generateResources();
                generateBuilds();
            } catch (Exception)
            {
                
            }
        }

        private void skipButton_Click(object sender, RoutedEventArgs e)
        {
            model.game.skip();
            drawMap();
            generateResources();
            generateBuilds();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            model.Save();
        }

        private void saveButton_MouseLeave(object sender, MouseEventArgs e)
        {
            storyBoard.Stop(this);
            mediaPlayer.Pause();
        }

        private void saveButton_MouseEnter(object sender, MouseEventArgs e)
        {
            storyBoard.Begin(this);
            mediaPlayer.Play();
        }
    }
}
