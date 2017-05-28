using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace brickOut
{
    public class Paddle
    {
        private int x, y, dx, dy;
        private Image paddleImg;
        private Rectangle paddleRec;

        public Rectangle PaddleRec
        {
            get { return paddleRec; }
        }

        public Paddle ()
	    {
            x = 0;
            y = 240;
            dx = 60;
            dy = 7;

            paddleImg = brickOut.Properties.Resources.paddle;
            paddleRec = new Rectangle(x,y,dx,dy);
	    }

        public void drawPaddle(Graphics paper)      
        {
            paper.DrawImage(paddleImg, paddleRec);
        }

        public void movePaddle(int mouseX, int mouseY)
        {
            paddleRec.X = mouseX - (paddleRec.Width/2) ;
            paddleRec.Y = mouseY;
        }

    }
}
