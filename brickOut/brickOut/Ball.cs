using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace brickOut
{
    public class Ball
    {
        private int x, y, dx, dy, xSpeed, ySpeed;
        private Image ballImg;
        private Rectangle ballRec;
        private Random randSpeed;

        private Rectangle BallRec
        {
            get { return ballRec; }
        }

        public Ball()
        {
            randSpeed = new Random();
            x = 150;
            y = 20;
            dx = 10;
            dy = 10;

            xSpeed = randSpeed.Next(5, 15);
            ySpeed = randSpeed.Next(5, 15);

            ballImg = brickOut.Properties.Resources.ball;
            ballRec = new Rectangle(x, y, dx, dy);
        }

        public void drawball(Graphics paper)
        {
            paper.DrawImage(ballImg, ballRec);
        }

        public void moveball()
        {
            ballRec.X += xSpeed;
            ballRec.Y += ySpeed;
        }

        public void forCollision()
        {
            if (ballRec.X < 0 || ballRec.X > 270)
            {
                xSpeed *= -1; //change the direction    
            }
            if (ballRec.Y < 0)
            {
                ySpeed *= -1;
            }
        }

        public void paddleCollision(Rectangle paddleRec)
        {
            if (paddleRec.IntersectsWith(ballRec))
            {
                ySpeed *= -1;
            }
        }
    }
}
