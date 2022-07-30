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
using System.Windows.Shapes;
using Project_Finansie.HulpClassen;

namespace Project_Finansie.Views
{
    /// <summary>
    /// Interaction logic for Ontvangste.xaml
    /// </summary>
    public partial class Ontvangste : Window
    {
        public Ontvangste()
        {
            InitializeComponent();
        }
        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {

            double newWindowHeight = e.NewSize.Height;
            double newWindowWidth = e.NewSize.Width;
            double prevWindowHeight = e.PreviousSize.Height;
            double prevWindowWidth = e.PreviousSize.Width;
            double windownSizeChangeHightPersentile = newWindowHeight / prevWindowHeight;
            double windownSizeChangeWidthPersentile = newWindowWidth / prevWindowWidth;
            if (windownSizeChangeHightPersentile < 20 && windownSizeChangeWidthPersentile < 20)
            {
                AllComponents(windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile);
            }

            if (windownSizeChangeHightPersentile > 20 && windownSizeChangeWidthPersentile > 20)

            {
                AllComponents(UpdateForWindowScaling: true);
            }
        }

        private void AllComponents(double windownSizeChangeHightPersentile = 1, double windownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            //Content
            WindowChanger.WindowSizeChanger(Grid_Ontvangste, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Txt_Berdag, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Txt_NaamVerzender, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Txb_Berdag, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Txb_NaamVerzender, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Btn_Toevoegen, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);

            //header-footer
            WindowChanger.WindowSizeChanger(Clrb_Black1, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Clrb_Header, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Clrb_Footer, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(btn_HomePage, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
            WindowChanger.WindowSizeChanger(Txt_Copyright, windownSizeChangeHightPersentile, windownSizeChangeWidthPersentile, UpdateForWindowScaling);
        }
    }
}
