using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _20230924
{
    public partial class MainWindow : Window
    {
        private List<Triangle> triangles = new List<Triangle>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double A, B, C;
            bool number = double.TryParse(textBox.Text, out A);
            bool number1 = double.TryParse(textBox1.Text, out B);
            bool number2 = double.TryParse(textBox2.Text, out C);

            if (!number || A <= 0 || !number1 || B <= 0 || !number2 || C <= 0)
            {
                MessageBox.Show("請輸入正數!", "Error!");
                return;
            }

            Triangle triangle = new Triangle(A, B, C);
            triangles.Add(triangle);

            if (triangle.IsValid)
            {
                label.Background = new SolidColorBrush(Colors.Green);
                label.Content = $"邊長 {A}, {B}, {C} 可構成三角形";
            }
            else
            {
                label.Background = new SolidColorBrush(Colors.Red);
                label.Content = $"邊長 {A}, {B}, {C} 不可構成三角形";
            }

            UpdateTextBlock();
        }

        private void UpdateTextBlock()
        {
            textBlock.Text = "測試結果：\n";

            foreach (Triangle triangle in triangles)
            {
                string result = triangle.IsValid ? "可構成" : "不可構成";
                textBlock.Text += $"邊長 {triangle.SideA}, {triangle.SideB}, {triangle.SideC} {result}三角形\n";
            }
        }
    }

    public class Triangle
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        public bool IsValid { get; private set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

            IsValid = IsTriangleValid(a, b, c);
        }

        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b;
        }
    }
}
