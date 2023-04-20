using ColorAndBalls;

Color ball1Color = new Color(123, 211, 107);
Ball ball1 = new Ball(100, ball1Color);

Color ball2Color = new Color(123, 111, 17);
Ball ball2 = new Ball(222, ball1Color);

Color ball3Color = new Color(23, 1, 23);
Ball ball3 = new Ball(33, ball1Color);

Color ball4Color = new Color(12, 255, 255);
Ball ball4 = new Ball(555, ball1Color);

int randomThrownTime = new Random().Next(100) + 1;
for (int i = 0; i < randomThrownTime; i++)
{
    ball1.Throw();
    ball2.Throw();
    ball3.Throw();
    ball4.Throw();

}
Console.WriteLine("ball1's thrown time is {0}, ball2's thrown time is {1}, ball3's thrown time is {2} ball4's thrown time is {3}"
                    , ball1.numThrows, ball2.numThrows, ball3.numThrows, ball4.numThrows);
ball1.Pop();
ball3.Pop();

int randomThrownTime2 = new Random().Next(100) + 1;
for (int i = 0; i < randomThrownTime2; i++)
{
    ball1.Throw();
    ball2.Throw();
    ball3.Throw();
    ball4.Throw();

}

Console.WriteLine("ball1's thrown time is {0}, ball2's thrown time is {1}, ball3's thrown time is {2} ball4's thrown time is {3}"
                    , ball1.numThrows, ball2.numThrows, ball3.numThrows, ball4.numThrows);