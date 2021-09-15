using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public class EgoldsCard : Control 
    {

        #region -- Переменные --

        Animation animCurtain;
        private float CurtainHeight;

        private bool MouseEntered = false;
        private bool MousePressed = false;

        #endregion

        #region -- Свойства --

        public string TextHeader { get; set; } = "Header";
        public Font FontHeader { get; set; } = new Font("Verdana",12F,FontStyle.Bold);
        public Color ForeColorHeader { get; set; } = Color.White;
        public string TextHeader1 { get; set; } = "Header1";
        public Font FontHeader1 { get; set; } = new Font("Verdana", 8.25F, FontStyle.Regular);
        public Color ForeColorHeader1 { get; set; } = Color.Black;

        public Color BackColorCurtain { get; set; } = Color.Tomato;
        #endregion
        public EgoldsCard()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(250, 200);
            CurtainHeight = Height - 60;

            Font = new Font("Verdaba", 9F, FontStyle.Regular);
            BackColor = Color.White;

            animCurtain = new Animation();
            animCurtain.Value = CurtainHeight;

           
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectCurtain = new Rectangle(0, 0, Width - 1, (int)animCurtain.Value);

            graph.FillRectangle(new SolidBrush(BackColor), rect);

            graph.DrawRectangle(new Pen(BackColorCurtain), rectCurtain);
            graph.FillRectangle(new SolidBrush(BackColorCurtain), rectCurtain);

            graph.DrawRectangle(new Pen(BackColor), rect);

            if(animCurtain.Value == 50)
            {
                graph.DrawString(TextHeader1, FontHeader, new SolidBrush(ForeColorHeader1),
                new Rectangle(15, 70, Width - 15, Height - 70));
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), 15, Height - 37);
            graph.DrawString(TextHeader, FontHeader, new SolidBrush(ForeColorHeader), 
                new Rectangle(15, 15, rectCurtain.Width, rectCurtain.Height));
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (Height <= 100)
                Height = 100;
            if (Width <= 100)
                Width = 100;

            CurtainHeight = Height - 60;

            animCurtain = new Animation();
            animCurtain.Value = CurtainHeight;

            Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            DoCurtainAnimation();

            //Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            DoCurtainAnimation();

            //Invalidate();

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }

        private void DoCurtainAnimation()
        {
            if (MouseEntered == true)
            {
                animCurtain = new Animation("Curtain_" + Handle, Invalidate, animCurtain.Value, 50);
            }
            else
            {
                animCurtain = new Animation("Curtain_" + Handle, Invalidate, animCurtain.Value, CurtainHeight);
            }

            Animator.Request(animCurtain,true);
        }


    }
}
