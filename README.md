# BrickOut

Ова е имплементација на играта Brick која целта е да се скршат сите тули без притоа да падне топката и притоа да се стигне до што е можно поголемо ниво.

Со самото стартување на играта се појавува следниот екран.
</br>
<a href="/kmojanovska/BrickOut/blob/BrickOut/brickOut/Resources/Start%20Game.png">
  <img src="https://github.com/kmojanovska/BrickOut/blob/BrickOut/brickOut/Resources/Start%20Game.png">
</a>
</br>
<ul>
  <li>
    Paddle: Оваа класа ни е за палката која ја користиме за топчето да не ни падне и притоа да ги скршиме сите тули.
  </li>
  <li>
    Ball: Oваа класа ни е за топката кој ја користиме за кршење на тулите и преку неа го уравуваме одбивањето од ѕидовите од палката и нејзиното движење.
  </li>
  <li>
    Form1: Оваа форма ни е главната која ни е за прикажување на играта каде преку интеракција со неа комуницираме со другите класи и ја менуваме состојбата на играта.
  </li>
  
</ul>

```chsarp
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
```
