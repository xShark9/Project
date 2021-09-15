using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project1.Components
{
    public partial class EgoldsFormStyle : Component
    {
        #region -- Свойства --

        public Form Form { get; set; }

        private fStyle formStyle = fStyle.None;

        public fStyle FormStyle
        {
            get => formStyle;
            set
            {
                formStyle = value;
                Sign();
            }
        }

        public enum fStyle
        {
            None,
            UserStyle,
            SimpleDark,
            TelegramStyle
        }

        #endregion

        #region -- Переменные --

        private Color HeaderColor = Color.DimGray;

        private int HeaderHeight = 28;

        private Size IconSize = new Size(14, 14);

        private StringFormat SF = new StringFormat();

        private Font Font = new Font("Arial", 8.75F, FontStyle.Regular);

        Pen WhitePen = new Pen(Color.White) { Width = 1.55F };

        bool MousePressed = false; // Кнопка мыши нажата
        Point clickPosition;       // Начальная позиция курсора в момент клика
        Point moveStartPosition;   // Начальная позиция формы в момент клика

        Rectangle rectBtnClose = new Rectangle();

        bool btnCloseHovered = false;

        #endregion

        public EgoldsFormStyle()
        {
            InitializeComponent();
        }

        public EgoldsFormStyle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Sign()
        {
            if(Form != null)
            {
                Form.Load += Form_Load;
            }
        }

        private void Apply()
        {
            SF.Alignment = StringAlignment.Near;
            SF.LineAlignment = StringAlignment.Center;

            Form.FormBorderStyle = FormBorderStyle.None;

            SetDoubleBuffered(Form);

            OffsetControls();

            Form.Paint += Form_Paint;
            Form.MouseDown += Form_MouseDown;
            Form.MouseUp += Form_MouseUp;
            Form.MouseMove += Form_MouseMove;
            Form.MouseLeave += Form_MouseLeave;

        }

        private void OffsetControls()
        {
            Form.Height = Form.Height + HeaderHeight;

            foreach(Control ctrl in Form.Controls)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + HeaderHeight);
                ctrl.Refresh();
            }
        }

        #region -- Form Events --

        private void Form_Load(object sender, EventArgs e)
        {
            Apply();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }
        private void Form_MouseLeave(object sender, EventArgs e)
        {
            btnCloseHovered = false;
            Form.Invalidate();
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {

                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosition)));
                Form.Location = Point.Add(moveStartPosition, frmOffset);
            }
            else
            {
                if (rectBtnClose.Contains(e.Location))
                {
                    if (btnCloseHovered == false)
                    {
                        btnCloseHovered = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (btnCloseHovered == true)
                    {
                        btnCloseHovered = false;
                        Form.Invalidate();
                    }
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= HeaderHeight)
            {
                MousePressed = true;
                clickPosition = Cursor.Position;
                moveStartPosition = Form.Location;
            }
            
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;

            if(e.Button == MouseButtons.Left)
            {
                if (rectBtnClose.Contains(e.Location))
                    Form.Close();
            }
        }

        #endregion

        private void DrawStyle(Graphics graph)
        {
            graph.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectHeader = new Rectangle(0, 0, Form.Width - 1, HeaderHeight);
            Rectangle rectBorder = new Rectangle(0, 0, Form.Width - 1, Form.Height -1);

            Rectangle rectTittleText = new Rectangle(rectHeader.X + 25, rectHeader.Y, rectHeader.Width, rectHeader.Height);
            Rectangle rectIcon = new Rectangle(
                rectHeader.Height / 2 - IconSize.Width / 2,
                rectHeader.Height / 2 - IconSize.Height / 2,
                IconSize.Width, IconSize.Height
                );

            rectBtnClose = new Rectangle(rectHeader.Width - rectHeader.Height, rectHeader.Y, rectHeader.Height, rectHeader.Height);
            Rectangle rectCrosshair = new Rectangle(
                rectBtnClose.X + rectBtnClose.Width / 2 - 5,
                rectBtnClose.Height / 2 - 5,
                10,10);

            // Шапка
            graph.DrawRectangle(new Pen(HeaderColor), rectHeader);
            graph.FillRectangle(new SolidBrush(HeaderColor), rectHeader);

            // Текст заголовка
            graph.DrawString(Form.Text, Font, new SolidBrush(Color.White), rectTittleText, SF);

            // Иконка
            graph.DrawImage(Form.Icon.ToBitmap(), rectIcon);

            // Кнопка X
            graph.DrawRectangle(new Pen(btnCloseHovered ? Color.Red : HeaderColor), rectBtnClose);
            graph.FillRectangle(new SolidBrush(btnCloseHovered ? Color.Red : HeaderColor), rectBtnClose);
            DrawCrosshair(graph, rectCrosshair, WhitePen);

            // Обводка
            graph.DrawRectangle(new Pen(Color.Black), rectBorder);

        }

        private void DrawCrosshair(Graphics graph, Rectangle rect, Pen pen)
        {
            graph.DrawLine(pen, rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
            graph.DrawLine(pen, rect.X + rect.Width, rect.Y, rect.X, rect.Y + rect.Height);
        }

        public static void SetDoubleBuffered(Control c) 
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo pDoubleBuffered =
                typeof(Control).GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance );

            pDoubleBuffered.SetValue(c, true, null);
        }

    }
}
