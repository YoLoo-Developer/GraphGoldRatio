using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace GraphGoldRatio
{
    public partial class GraphForm : Form
    {
        private Pen penCoord; //Карандаш координат
        private Pen penBlock; //Карандаш сетки

        private Function[] func = new Function[0]; //Список функций

        private int sizeGraph = 10; //Размер графика
        private int sizeCell; //Размер клетки
        private int interval = 500; //Интервал просчёта функций
        private int xCenter, yCenter; //Координаты центра
        private Point offset; //Смещение 

        private double kX, kY; //Соотношение ширины/высоты графика к размеру графика
        private double mouseX, mouseY; //Координаты мыши
        private double from, to, eps; //Переменные для золотого сечения

        private bool plus; //Приближение графика
        private bool goldRatio; //Активено ли золотое сечение
        private bool maximum = true; //Максимум или минимум
        private bool textOffset = true; //Изменять текс
        private bool borders = true; //Границы

        //Настройки
        private bool smooth; //Сглаживание функции
        private bool grid; //Отрисовка сетки
        private bool arrows; //Отрисовка стрелок
        private bool values; //Отрисовка чисел
        private bool yAxis; //Отрисовка Y оси
        private bool xAxis; //Отрисовка X оси

        //Настройка функций
        private Point fStartPos = new Point(5, 10);
        private Size fSizeField = new Size(190, 30);
        private int fSizeIcon = 22;
        private int fSizeButton = 24;
        private Font fFont = new Font("Arial", 10);

        private Panel groupFields;
        private Button bAddFunc;

        private List<Field> fields = new List<Field>();
        private int fCount = 0;

        public GraphForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            penCoord = new Pen(Color.Blue);
            penBlock = new Pen(Color.LightGray);
            xCenter = graph.Width / 2;
            yCenter = graph.Height / 2;
            kX = graph.Width / sizeGraph;
            kY = graph.Height / sizeGraph;
            SettingsUpdate(null, null);

            InitializateFields();
            About about = new About();
            about.Show();
        }
        
        /// <summary>
        /// Инициализация полей
        /// </summary>
        private void InitializateFields()
        {
            groupFields = new Panel();
            groupFields.Parent = groupFunctions;
            groupFields.Location = new Point(groupFunctions.Location.X, groupFunctions.Location.Y + 5);
            groupFields.Size = new Size(groupFunctions.Size.Width - 10, groupFunctions.Size.Height - 20);
            groupFields.AutoScroll = true;

            bAddFunc = new Button();
            bAddFunc.Parent = groupFields;
            bAddFunc.Location = new Point(fStartPos.X, fStartPos.Y - 5);
            bAddFunc.Size = new Size(fSizeField.Width, 25);
            bAddFunc.Font = new Font("Arial", 9);
            bAddFunc.Text = "Add";
            bAddFunc.Click += CreateFieldGraph;
            CreateFieldGraph(null, null);
            fields[0].field.Text = "x^2";
            ReadFunctions(null, null);
        }

        #region Обработка компонентов
        /// <summary>
        /// Кнопка отчистки золотого сечения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            inputFrom.Text = "";
            inputTo.Text = "";
            goldRatio = false;
            BuildFunction();
        }

        /// <summary>
        /// Кнопка нахождения локального экстремума
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(inputFrom.Text, out from))
            {
                inputFrom.Text = "";
                return;
            }
            if (!Double.TryParse(inputTo.Text, out to))
            {
                inputTo.Text = "";
                return;
            }
            if (!Double.TryParse(inputEps.Text, out eps))
            {
                inputEps.Text = "0,01";
                eps = 0.01f;
            }
            if (to < from)
            {
                inputFrom.Text = "";
                inputTo.Text = "";
                return;
            }
            goldRatio = true;
            BuildFunction();
        }

        /// <summary>
        /// Движение мышки в графике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void graph_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = Math.Round(e.X / kX - sizeGraph/2 - offset.X / kX, 3);
            mouseY = -Math.Round(e.Y / kY - sizeGraph/2 - offset.Y / kY, 3);
            textCoord.Text = "Cursor position: x = " + mouseX.ToString() + "; y = " + mouseY.ToString();
        }

        /// <summary>
        /// Клик мышки по графику
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void graph_Click(object sender, EventArgs e)
        {
            settingsBox.Visible = false;
            textCCoord.Text = "Click position: x = " + mouseX.ToString() + "; y = " + mouseY.ToString();
        }

        /// <summary>
        /// Кнопка помощи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            AMethod aMethodWindow = new AMethod();
            aMethodWindow.Show();
        }

        /// <summary>
        /// Масштаб графика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeScale(object sender, EventArgs e)
        {
            bool dir = (sender == buttonPlus);
            int mult = sizeGraph / 10;
            if (sizeGraph < 10)
                mult = 1;

            if (dir)
            {
                if (sizeGraph > 10)
                {
                    sizeGraph -= 10;
                    interval -= 500;
                }
                else if (sizeGraph == 1)
                    return;
                else
                    sizeGraph--;
            }
            else
            {
                if (sizeGraph >= 10)
                {
                    sizeGraph += 10;
                    interval += 500;
                }
                else
                    sizeGraph++;
            }

            plus = !plus;
            textOffset = false;

            int changeX = offset.X / (int)kX / mult;
            int changeY = offset.Y / (int)kY / mult;
            kX = graph.Width / sizeGraph;
            kY = graph.Height / sizeGraph;

            mult = sizeGraph / 10;
            if (sizeGraph < 10)
                mult = 1;
            offset.X = changeX * (int)kX * mult;
            offset.Y = changeY * (int)kY * mult;

            inputOffsetX.Text = (-offset.X / kX).ToString();
            inputOffsetY.Text = (offset.Y / kY).ToString();

            textOffset = true;
            BuildFunction();
        }

        /// <summary>
        /// Создание поля для графика
        /// </summary>
        private void CreateFieldGraph(object sender, EventArgs e)
        {
            if (fCount != 0)
                fStartPos = new Point(fStartPos.X, fields[fCount - 1].field.Location.Y + fSizeField.Height + 1);

            //Иконка
            PictureBox icon = new PictureBox();
            icon.Parent = groupFields;
            icon.Location = new Point(fStartPos.X - 8, fStartPos.Y);
            icon.Size = new Size(fSizeIcon + 8, fSizeIcon);
            Bitmap bitmap = new Bitmap(icon.Width+8, icon.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawString((fCount + 1).ToString(), new Font("Arial", 7), new SolidBrush(Color.Black), new Point(1, 2));
            g.FillEllipse(new SolidBrush(colorGraph(fCount)), new Rectangle(8, 0, fSizeIcon, fSizeIcon));
            g.DrawImage(Properties.Resources.Graph, new Rectangle(8, 0, fSizeIcon, fSizeIcon));
            icon.Image = bitmap;
            fCount++;

            //Кнопка удаления
            Button button = new Button();
            button.Parent = groupFields;
            button.Location = new Point(fStartPos.X + fSizeField.Width - fSizeButton, fStartPos.Y);
            button.Size = new Size(fSizeButton, fSizeButton);
            button.Font = new Font("Arial", 9);
            button.Text = "x";
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Click += RemoveFunction;

            //Поле ввода
            TextBox field = new TextBox();
            field.Parent = groupFields;
            field.Location = new Point(fStartPos.X + fSizeIcon + 5, fStartPos.Y);
            field.Font = fFont;
            field.Size = new Size(fSizeField.Width - fSizeIcon - 5, fSizeField.Height);
            field.BorderStyle = BorderStyle.Fixed3D;
            field.TextChanged += ReadFunctions;

            fields.Add(new Field(icon, button, field));
            bAddFunc.Location = new Point(fStartPos.X, fStartPos.Y + fSizeField.Height - 5);
        }

        /// <summary>
        /// Чтение функций
        /// </summary>
        private void ReadFunctions(object sender, EventArgs e)
        {
            func = new Function[fCount];
            for (int i = 0; i < fCount; i++)
            {
                try { func[i] = new Function("f(x)=" + fields[i].field.Text); }
                catch { }
            }
            BuildFunction();
        }

        /// <summary>
        /// Удаление функции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFunction(object sender, EventArgs e)
        {
            int idR = 0; ;
            bool removed = false;
            for (int f = 1; f < fCount; f++)
            {
                if (sender == fields[f].bRemove)
                {
                    removed = true;
                    fields[f].icon.Visible = false;
                    fields[f].field.Visible = false;
                    fields[f].bRemove.Visible = false;
                    idR = f;
                    break;
                }
            }
            if (!removed) return;

            for (int f = fCount-1; f > idR; f--)
            {
                Bitmap bitmap = new Bitmap(fields[f].icon.Width + 8, fields[f].icon.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.DrawString((f).ToString(), new Font("Arial", 7), new SolidBrush(Color.Black), new Point(1, 2));
                g.FillEllipse(new SolidBrush(colorGraph(f - 1)), new Rectangle(8, 0, fSizeIcon, fSizeIcon));
                g.DrawImage(Properties.Resources.Graph, new Rectangle(8, 0, fSizeIcon, fSizeIcon));
                fields[f].icon.Image = bitmap;
                fields[f].icon.Location = fields[f - 1].icon.Location;
                fields[f].field.Location = fields[f - 1].field.Location;
                fields[f].bRemove.Location = fields[f - 1].bRemove.Location;
            }

            fCount--;
            fields.RemoveAt(idR);
            bAddFunc.Location = new Point(fStartPos.X, fields[fCount - 1].field.Location.Y + (fSizeField.Height + 1) - 5);
            ReadFunctions(null, null);
        }

        /// <summary>
        /// Открытие настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settingsBox.Visible = !settingsBox.Visible;
        }

        /// <summary>
        /// Обновление настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsUpdate(object sender, EventArgs e)
        {
            smooth = checkSmooting.Checked;
            grid = checkGrid.Checked;
            arrows = checkArrows.Checked;
            values = checkValues.Checked;
            xAxis = checkXAxis.Checked;
            yAxis = checkYAxis.Checked;
            borders = checkBorders.Checked;

            BuildFunction();
        }

        /// <summary>
        /// Выбор минимума или максимума
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseMinMax(object sender, EventArgs e)
        {
            if (sender == checkMax)
            {
                checkMax.Checked = true;
                checkMin.Checked = false;
            }
            else if (sender == checkMin)
            {
                checkMin.Checked = true;
                checkMax.Checked = false;
            }

            maximum = checkMax.Checked;
            BuildFunction();
        }
        
        /// <summary>
        /// Смещение графика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeOffset(object sender, EventArgs e)
        {
            int mult = sizeGraph / 10;
            if (sizeGraph < 10)
                mult = 1;
            textOffset = false;

            if (sender == buttonLeft)
                offset.X += (int)kX * mult;
            else if (sender == buttonRight)
                offset.X -= (int)kX * mult;
            else if (sender == buttonUp)
                offset.Y += (int)kY * mult;
            else if (sender == buttonDown)
                offset.Y -= (int)kY * mult;
            else 
                offset = new Point();
            
            inputOffsetX.Text = (-offset.X / kX).ToString();
            inputOffsetY.Text = (offset.Y / kY).ToString();

            textOffset = true;
            BuildFunction();
        }

        /// <summary>
        /// Изменение смещение текстом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChangeOffset(object sender, EventArgs e)
        {
            if (!textOffset)
                return;

            int x, y;
            int.TryParse(inputOffsetX.Text, out x);
            int.TryParse(inputOffsetY.Text, out y);

            x *= -(int)kX;
            y *= (int)kY;

            offset = new Point(x, y);
            BuildFunction();
        }
        #endregion

        /// <summary>
        /// Постройка графика
        /// </summary>
        private void BuildFunction()
        {
            Bitmap bitmap = new Bitmap(graph.Width, graph.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            if (smooth)
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //Рисование сетки
            if (grid)
                graphics = DrawGrid(graphics);
            //Отрисовка осей
            if (xAxis || yAxis || arrows)
                graphics = DrawAxis(graphics);
            //Рисование координат
            if (values)
                graphics = DrawValues(graphics);
            //Отрисовка названия осей
            graphics = DrawNameAxis(graphics);

            //Рисование функции
            graphics = DrawGraph(graphics);

            //Рисование золотого сечения
            if (goldRatio) 
                graphics = DrawGoldRatio(graphics);
            graph.Image = bitmap;
        }

        /// <summary>
        /// Отрисовка сетки
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private Graphics DrawGrid(Graphics g)
        {
            if (plus)
                sizeCell = graph.Width / 8;
            else
                sizeCell = graph.Width / 4;

            int amountX = graph.Width / sizeCell + 2;
            int amountY = graph.Height / sizeCell + 2;
            int offsetX = -offset.X / sizeCell;
            int offsetY = -offset.Y / sizeCell;

            for (int y = -amountY / 2 + offsetY; y < amountY / 2 + offsetY; y++)
            {
                for (int x = -amountX / 2 + offsetX; x < amountX / 2 + offsetX; x++)
                {
                    g.DrawRectangle(penBlock, sizeCell * x + xCenter + offset.X, sizeCell * y + yCenter + offset.Y, sizeCell, sizeCell);
                }
            }
            return g;
        }

        /// <summary>
        /// Отрисовка координат
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private Graphics DrawAxis(Graphics g)
        {
            if (xAxis)
                g.DrawLine(penCoord, 0, graph.Height / 2 + offset.Y, graph.Width, graph.Height / 2 + offset.Y);
            if (yAxis)
                g.DrawLine(penCoord, graph.Width / 2 + offset.X, graph.Height, graph.Width / 2 + offset.X, 0);
            if (arrows)
            {
                Point[] points = new Point[3];
                if (yAxis)
                {
                    //↑
                    if (offset.Y / kY > sizeGraph / -2)
                    {
                        points[0] = new Point(xCenter + offset.X, 0);
                        points[1] = new Point(xCenter - 5 + offset.X, 20);
                        points[2] = new Point(xCenter + 5 + offset.X, 20);
                        g.FillPolygon(new SolidBrush(penCoord.Color), points);
                    }

                    //↓
                    if (offset.Y / kY < sizeGraph / 2)
                    {
                        points[0] = new Point(xCenter + offset.X, graph.Height);
                        points[1] = new Point(xCenter - 5 + offset.X, graph.Height - 20);
                        points[2] = new Point(xCenter + 5 + offset.X, graph.Height - 20);
                        g.FillPolygon(new SolidBrush(penCoord.Color), points);
                    }
                }
                if (xAxis)
                {
                    //←
                    if (offset.X / kX > sizeGraph / -2)
                    {
                        points[0] = new Point(0, yCenter + offset.Y);
                        points[1] = new Point(20, yCenter - 5 + offset.Y);
                        points[2] = new Point(20, yCenter + 5 + offset.Y);
                        g.FillPolygon(new SolidBrush(penCoord.Color), points);
                    }

                    //→
                    if (offset.X / kX < sizeGraph / 2)
                    {
                        points[0] = new Point(graph.Width, yCenter + offset.Y);
                        points[1] = new Point(graph.Width - 20, yCenter - 5 + offset.Y);
                        points[2] = new Point(graph.Width - 20, yCenter + 5 + offset.Y);
                        g.FillPolygon(new SolidBrush(penCoord.Color), points);
                    }
                }
            }

            return g;
        }

        /// <summary>
        /// Отрисовка название осей
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private Graphics DrawNameAxis(Graphics g)
        {
            g.DrawString(nameXAxis.Text, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(graph.Width - nameXAxis.Text.Length * 8 - 16, yCenter - 20 + offset.Y));
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString(nameYAxis.Text, new Font("Arial", 10), new SolidBrush(Color.Black), new Point(xCenter - 20 + offset.X, 8), drawFormat);

            return g;
        }

        /// <summary>
        /// Отрисовка значений на графике
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private Graphics DrawValues(Graphics g)
        {
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString("0", drawFont, new SolidBrush(Color.Black), xCenter + offset.X, yCenter + offset.Y);

            string text;
            float step; 
            float pos;
            int offsetX = -offset.X / sizeCell;
            int offsetY = -offset.Y / sizeCell;
            int amount = 4;

            if (plus)
                amount *= 2;

            //X
            if (xAxis)
            {
                step = xCenter / (amount / 2);
                for (int x = -amount / 2 + offsetX; x <= amount / 2 + offsetX; x++)
                {
                    if (x == 0)
                        continue;

                    text = (sizeGraph / -2f + sizeGraph / (float)amount * (x + amount / 2)).ToString();
                    if (x == amount / 2)
                        pos = (x + amount / 2) * step - text.Length * 4 - 12;
                    else
                        pos = (x + amount / 2) * step;

                    g.DrawString(text, drawFont, drawBrush, pos + offset.X, yCenter + offset.Y);
                }
            }

            //Y
            if (yAxis)
            {
                step = yCenter / (amount / 2);
                for (int y = -amount / 2 + offsetY; y <= amount / 2 + offsetY; y++)
                {
                    if (y == 0)
                        continue;

                    text = (-(sizeGraph / -2f + sizeGraph / (float)amount * (y + amount / 2))).ToString();
                    if (y == amount / 2)
                        pos = (y + amount / 2) * step - 16;
                    else
                        pos = (y + amount / 2) * step;

                    g.DrawString(text, drawFont, drawBrush, xCenter + offset.X, pos + offset.Y);
                }
            }

            return g;
        }

        /// <summary>
        /// Отрисовка графика
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        private Graphics DrawGraph(Graphics g)
        {
            for (int i = 0; i < func.Length; i++)
            {
                if (func[i] == null) continue;

                Pen penGraph = new Pen(colorGraph(i));

                double step = (sizeGraph * 2f) / interval;
                double x1 = -sizeGraph + (-offset.X / kX), y1 = func[i].calculate(x1), x2, y2;

                for (int j = 0; j < interval; j++)
                {
                    x2 = x1 + step;
                    y2 = func[i].calculate(x2);
                    if (!double.IsNaN(y1) && !double.IsNaN(y2) && Math.Abs(y1) < graph.Height && Math.Abs(y2) < graph.Height)
                        g.DrawLine(penGraph, (float)(kX * x1 + xCenter) + offset.X, (float)(graph.Height - kY * y1 - yCenter) + offset.Y,
                            (float)(kX * x2 + xCenter) + offset.X, (float)(graph.Height - kY * y2 - yCenter) + offset.Y);
                    x1 = x2;
                    y1 = y2;
                }
            }
            return g;
        }

        /// <summary>
        /// Отрисовка золотого сечения
        /// </summary>
        private Graphics DrawGoldRatio(Graphics g)
        {
            if (func[0] == null) return g;

            float x, y, gX, gY;
            List<double> xLeftBorder = new List<double>();
            List<double> xRightBorder = new List<double>();
            Font drawFont = new Font("Arial", 8);

            double a = from, b = to;
            double x1 = 0, x2 = 0;

            //Вычисление количество нулей Eps
            double divid = eps;
            int zeroEps = 0;
            while (divid < 1)
            {
                divid *= 10;
                zeroEps++;
            }

            //Максимум/Минимум
            while (true)
            {
                xLeftBorder.Add(a);
                xRightBorder.Add(b);
                x1 = b - (b - a) / 1.618f;
                x2 = a + (b - a) / 1.618f;
                if (maximum)
                {
                    if (func[0].calculate(x1) <= func[0].calculate(x2))
                        a = x1;
                    else
                        b = x2;
                }
                else
                {
                    if (func[0].calculate(x1) >= func[0].calculate(x2))
                        a = x1;
                    else
                        b = x2;
                }
                if (Math.Abs(b - a) < eps)
                    break;
            }
            x = (float)(a + b) / 2f;
            gX = (float)(x * kX + xCenter) + offset.X;
            y = (float)func[0].calculate(x);
            gY = (float)(graph.Height - kY * y - yCenter) + offset.Y;
            if (maximum)
                g.DrawString(String.Format("max({0};{1})", Math.Round(x, zeroEps), Math.Round(y, zeroEps)), drawFont, new SolidBrush(Color.Black), new PointF(gX, gY));
            else
                g.DrawString(String.Format("min({0};{1})", Math.Round(x, zeroEps), Math.Round(y, zeroEps)), drawFont, new SolidBrush(Color.Black), new PointF(gX, gY));
            g.FillEllipse(new SolidBrush(Color.Purple), gX - 3, gY - 3, 6, 6);

            if (!borders)
                return g;

            //Границы
            for (int i = 0; i < xLeftBorder.Count; i++)
            {
                x = (float)(kX * xLeftBorder[i] + xCenter) + offset.X;
                y = (float)(graph.Height - kY * func[0].calculate(xLeftBorder[i]) - yCenter) + offset.Y;

                if (i < xLeftBorder.Count - 1 && Math.Abs(xLeftBorder[i] - xLeftBorder[i + 1]) < eps)
                {
                    g.DrawLine(new Pen(Color.Purple), x, yCenter + offset.Y, x, y);
                    break;
                }

                if (!borders)
                    continue;

                if (xLeftBorder.Count-1 == i)
                    g.DrawLine(new Pen(Color.Purple), x, yCenter + offset.Y, x, y);
                else
                    g.DrawLine(new Pen(Color.Gray), x, yCenter + offset.Y, x, y);
            }

            for (int i = 0; i < xRightBorder.Count; i++)
            {
                x = (float)(kX * xRightBorder[i] + xCenter) + offset.X;
                y = (float)(graph.Height - kY * func[0].calculate(xRightBorder[i]) - yCenter) + offset.Y;

                if (i < xRightBorder.Count - 1 && Math.Abs(xRightBorder[i] - xRightBorder[i + 1]) < eps)
                {
                    g.DrawLine(new Pen(Color.Purple), x, yCenter + offset.Y, x, y);
                    break;
                }

                if (xLeftBorder.Count - 1 == i)
                    g.DrawLine(new Pen(Color.Purple), x, yCenter + offset.Y, x, y);
                else
                    g.DrawLine(new Pen(Color.Gray), x, yCenter + offset.Y, x, y);
            }

            return g;
        }

        /// <summary>
        /// Цвет графика
        /// </summary>
        /// <param name="idLine"></param>
        /// <returns></returns>
        private Color colorGraph(int idLine)
        {
            Color color = Color.White;
            int coef = idLine;
            if (idLine > 5)
                coef %= 5;

            switch (coef)
            {
                case 0:
                    color = Color.Red;
                    break;
                case 1:
                    color = Color.DeepSkyBlue;
                    break;
                case 2:
                    color = Color.Gold;
                    break;
                case 3:
                    color = Color.Green;
                    break;
                case 4:
                    color = Color.Purple;
                    break;
                default:
                    color = Color.Black;
                    break;
            }
            return color;
        }
    }
}