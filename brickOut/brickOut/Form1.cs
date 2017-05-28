using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace brickOut
{
    public partial class Form1 : Form
    {
        Graphics paper;
        Paddle paddle = new Paddle();
        Ball ball = new Ball();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            paddle.drawPaddle(paper);
            ball.drawball(paper);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y > 230)
                paddle.movePaddle(e.X, e.Y);
            else
                paddle.movePaddle(e.X, 230);
            this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.moveball();
            ball.forCollision();
            ball.paddleCollision(paddle.PaddleRec);
            this.Invalidate();
        }
    }
}
