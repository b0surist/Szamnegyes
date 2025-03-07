using System.Windows;
using System.Windows.Controls;

namespace TicTacCounter
{
    public partial class MainWindow : Window
    {
        private int[,] table = new int[3, 3];
        private Label[,] labels = new Label[3, 3];

        public MainWindow()
        {
            InitializeGameGrid();
        }

        private void InitializeGameGrid()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Label label = new Label
                    {
                        Content = "0",
                        FontSize = 24,
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Center,
                        BorderThickness = new Thickness(1),
                        BorderBrush = System.Windows.Media.Brushes.Black
                    };

                    
                    labels[i, j] = label;
                }
            }
        }

        private void UpdateGrid()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    labels[i, j].Content = table[i, j].ToString();
        }

        private void IncrementArea(int x1, int y1, int x2, int y2)
        {
            for (int i = x1; i <= x2; i++)
                for (int j = y1; j <= y2; j++)
                    table[i, j]++;

            UpdateGrid();
        }

        public void ButtonA_Click(object sender, RoutedEventArgs e) => IncrementArea(0, 0, 1, 1);
        public void ButtonB_Click(object sender, RoutedEventArgs e) => IncrementArea(0, 1, 1, 2);
        public void ButtonC_Click(object sender, RoutedEventArgs e) => IncrementArea(1, 0, 2, 1);
        public void ButtonD_Click(object sender, RoutedEventArgs e) => IncrementArea(1, 1, 2, 2);

        public void Reset_Click(object sender, RoutedEventArgs e)
        {
            table = new int[3, 3];
            UpdateGrid();
        }
    }
}
