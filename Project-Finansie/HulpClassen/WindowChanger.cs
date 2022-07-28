using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Microsoft.Win32;
using MaterialDesignThemes;
using MaterialDesignThemes.Wpf;

namespace Project_Finansie.HulpClassen
{
    public static class WindowChanger
    {
        private static double CalculateDpiFactors()
        {
            Window MainWindow = Application.Current.MainWindow;
            PresentationSource MainWindowPresentationSource = PresentationSource.FromVisual(MainWindow);
            Matrix m = MainWindowPresentationSource.CompositionTarget.TransformToDevice;

            if (m.M11 == 1.25)
            {
                return m.M11 * 0.78;
            }
            else
            {
                return 1;
            }

        }
        public static void WindowSizeChanger(Card Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }
        public static void WindowSizeChanger(Button Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }
        }

        public static void WindowSizeChanger(TextBlock Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)

        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }


        }
        public static void WindowSizeChanger(ComboBox Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)

        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }

        public static void WindowSizeChanger(TextBox Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)

        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }

        public static void WindowSizeChanger(DockPanel Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)

        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }

        public static void WindowSizeChanger(ScrollViewer Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)

            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }


        }
        public static void WindowSizeChanger(ItemsControl Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }

        public static void WindowSizeChanger(Label Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }

        public static void WindowSizeChanger(FlowDocumentReader Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }

        public static void WindowSizeChanger(Rectangle Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }
        public static void WindowSizeChanger(DatePicker Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }
        public static void WindowSizeChanger(CheckBox Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }
        public static void WindowSizeChanger(Grid Instance, double WindownSizeChangeHightPersentile = 1, double WindownSizeChangeWidthPersentile = 1, bool UpdateForWindowScaling = false)
        {
            double thisDpiFactor = CalculateDpiFactors();
            if (UpdateForWindowScaling == false)
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * WindownSizeChangeWidthPersentile, Top = Instance.Margin.Top * WindownSizeChangeHightPersentile, Right = Instance.Margin.Right * WindownSizeChangeWidthPersentile, Bottom = Instance.Margin.Bottom * WindownSizeChangeHightPersentile };
            }
            else
            {
                Instance.Margin = new System.Windows.Thickness { Left = Instance.Margin.Left * thisDpiFactor, Top = Instance.Margin.Top * thisDpiFactor, Right = Instance.Margin.Right * thisDpiFactor, Bottom = Instance.Margin.Bottom * thisDpiFactor };
            }

        }
    }
}
