using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snake_Game
{
    class Food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;
        public Food(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Yellow);

            width = 10;
            height = 10;

            foodRec = new Rectangle(x, y, width, height);

        }

        public void foodLocation(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
 
        }

        public void drawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;

            paper.FillRectangle(brush, foodRec);
        }

    }
class Bonus 
    {
   private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle bonusRec;
        public Bonus(Random randBonus)
        {
            x = randBonus.Next(0, 29) * 10;
            y = randBonus.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Purple);

            width = 10;
            height = 10;

            bonusRec = new Rectangle(x, y, width, height);

        }

        public void bonusLocation(Random randBonus)
        {
            x = randBonus.Next(0, 29) * 10;
            y = randBonus.Next(0, 29) * 10;

        }

        public void drawBonus(Graphics paper)
        {
            bonusRec.X = x;
            bonusRec.Y = y;

            paper.FillRectangle(brush, bonusRec);
        }
              }

      
    }

