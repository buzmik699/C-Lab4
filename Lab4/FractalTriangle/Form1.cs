using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FractalTriangle
{
    public partial class Form1 : Form
    {
        private Point A, B, C; // Вершины треугольника
        private Point currentPoint; // Текущая точка
        private List<Point> points; // Список точек для шагов
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            points = new List<Point>();
            this.DoubleBuffered = true; // Убираем мерцание
        }

        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            // Генерируем случайные координаты для треугольника
            A = new Point(random.Next(0, this.ClientSize.Width), random.Next(0, this.ClientSize.Height));
            B = new Point(random.Next(0, this.ClientSize.Width), random.Next(0, this.ClientSize.Height));
            C = new Point(random.Next(0, this.ClientSize.Width), random.Next(0, this.ClientSize.Height));

            // Очищаем форму и сбрасываем список точек
            points.Clear();
            currentPoint = Point.Empty; // Сбрасываем текущую точку
            this.Invalidate(); // Перерисовываем форму
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Рисуем треугольник
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawLine(pen, A, B);
                e.Graphics.DrawLine(pen, B, C);
                e.Graphics.DrawLine(pen, C, A);
            }

            // Рисуем все точки и соединяем их линиями
            if (points.Count > 0)
            {
                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        e.Graphics.DrawLine(pen, points[i], points[i + 1]);
                    }

                    // Соединяем последнюю точку с первой
                    e.Graphics.DrawLine(pen, points[points.Count - 1], points[0]);
                }
            }

            // Рисуем текущую точку, если она задана
            if (currentPoint != Point.Empty)
            {
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillEllipse(brush, currentPoint.X - 5, currentPoint.Y - 5, 10, 10);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Устанавливаем текущую точку при клике мышью
            if (IsPointInTriangle(e.Location, A, B, C))
            {
                currentPoint = e.Location;
                points.Clear(); // Сбрасываем список точек
                points.Add(currentPoint); // Добавляем первую точку
                this.Invalidate();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSteps.Text, out int steps) && steps > 0)
            {
                for (int i = 0; i < steps; i++)
                {
                    Step();
                }
            }
        }

        private void Step()
        {
            // Генерируем случайное число от 1 до 3
            int vertex = random.Next(1, 4);

            // Определяем новую точку
            if (vertex == 1) // A
                currentPoint = Midpoint(currentPoint, A);
            else if (vertex == 2) // B
                currentPoint = Midpoint(currentPoint, B);
            else if (vertex == 3) // C
                currentPoint = Midpoint(currentPoint, C);

            // Добавляем текущую точку в список точек
            points.Add(currentPoint);

            // Перерисовываем форму
            this.Invoke((MethodInvoker)delegate {
                this.Invalidate();
            });
        }

        private Point Midpoint(Point p1, Point p2)
        {
            return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }

        private bool IsPointInTriangle(Point pt, Point A, Point B, Point C)
        {
            // Используем метод площади для определения, находится ли точка внутри треугольника
            float area = Math.Abs((A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y)) / 2.0f);
            float area1 = Math.Abs((pt.X * (B.Y - C.Y) + B.X * (C.Y - pt.Y) + C.X * (pt.Y - B.Y)) / 2.0f);
            float area2 = Math.Abs((A.X * (pt.Y - C.Y) + pt.X * (C.Y - A.Y) + C.X * (A.Y - pt.Y)) / 2.0f);
            float area3 = Math.Abs((A.X * (B.Y - pt.Y) + B.X * (pt.Y - A.Y) + pt.X * (A.Y - B.Y)) / 2.0f);

            return area == area1 + area2 + area3;
        }
    }
}
