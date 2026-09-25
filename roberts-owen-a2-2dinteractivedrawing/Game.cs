// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    /// 

    //Checks whether or not the blinds are open.
    bool blindsOpen = false;

    //Gets a random sky and ground
    int random_sky = Random.Integer(3);
    int random_ground = Random.Integer(3);

    public void Setup()
    {
        Window.SetTitle("Randomized Blinds");
        Window.SetSize(400, 400);

    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {

        //Checks if blinds are closed
        if (blindsOpen == false)
        {

            //Draws background
            Window.ClearBackground(79, 142, 194);
            Draw.SetFillColor(79, 142, 194);

            Draw.SetLineSize(10);
            Draw.SetLineColor(99, 53, 33);
            Draw.Square(100, 100, 200);

            Draw.SetFillColor(222, 221, 209);
            Draw.SetLineSize(0);
            Draw.Rectangle(80, 80, 240, 220);
        }
        else
        {

            //Draws background
            Window.ClearBackground(79, 142, 194);
            Draw.SetFillColor(79, 142, 194);

            Draw.SetLineSize(10);
            Draw.SetLineColor(99, 53, 33);
            Draw.Square(100, 100, 200);

            Draw.SetFillColor(222, 221, 209);
            Draw.SetLineSize(0);
            Draw.Rectangle(80, 80, 240, 35);

            //Blue sky
            if (random_sky == 0)
            {
                Draw.SetFillColor(46, 202, 219);
                Draw.SetLineSize(0);
                Draw.Rectangle(110, 115, 180, 150);

                Draw.SetFillColor(255, 255, 255);
                Draw.Ellipse(140,145,45,15);
                Draw.Ellipse(170, 125, 45, 8);
                Draw.Ellipse(250, 125, 45, 12);
            }
            //Autumn sky
            else if (random_sky == 1)
            {
                Draw.SetFillColor(247, 131, 59);
                Draw.SetLineSize(0);
                Draw.Rectangle(110, 115, 180, 150);

                Draw.SetFillColor(237, 193, 166);
                Draw.Ellipse(140, 145, 45, 15);
                Draw.Ellipse(210, 150, 45, 9);
                Draw.Ellipse(250, 125, 45, 12);
            }
            //Winter sky
            else if (random_sky == 2)
            {
                Draw.SetFillColor(23, 36, 179);
                Draw.SetLineSize(0);
                Draw.Rectangle(110, 115, 180, 150);

                Draw.SetFillColor(255, 255, 255);
                Draw.Circle(140, 160, 2);
                Draw.Circle(160, 165, 2);
                Draw.Circle(120, 120, 2);
                Draw.Circle(250, 140, 2);
                Draw.Circle(220, 150, 2);
                Draw.Circle(157, 136, 2);
                Draw.Circle(170, 120, 2);
                Draw.Circle(190, 145, 2);
                Draw.Circle(204, 120, 2);
                Draw.Circle(227, 126, 2);
                Draw.Circle(267, 125, 2);
                Draw.Circle(121, 138, 2);
                Draw.Circle(264, 153, 2);
            }

            //Grass ground
            if (random_ground == 0)
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(133, 219, 46);
                Draw.Rectangle(110, 240, 180, 50);
            }
            //Autumn ground
            else if (random_ground == 1)
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(156, 76, 16);
                Draw.Rectangle(110, 240, 180, 50);

                Draw.SetFillColor(204, 107, 35);
                Draw.Triangle(120, 240, 150, 240, 135, 210);
                Draw.Triangle(170, 240, 200, 240, 185, 210);
                Draw.Triangle(220, 240, 250, 240, 235, 210);
            }
            //Winter ground
            else if (random_ground == 2)
            {
                Draw.SetLineSize(0);
                Draw.SetFillColor(207, 205, 202);
                Draw.Rectangle(110, 240, 180, 50);

                Draw.Triangle(120, 240, 210, 240, 165, 150);
                Draw.Triangle(180, 240, 260, 240, 220, 185);
            }
        }

        //Checks if the left mouse button was pressed
        if (Input.IsMouseButtonPressed(MouseButton.Left))
        {
            //Checks if the blinds are closed
            if (blindsOpen == false)
            {
                //Updates the variable to make them open
                blindsOpen = true;

                //Gets a random ground and sky
                random_ground = Random.Integer(3);
                random_sky = Random.Integer(3);

            }
            //Checks if blinds are open
            else
            {
                //Updates blinds to closed
                blindsOpen = false;
            }
        }

    }
}

