using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class Camera
    {
        public Matrix transform;
        Viewport view;
        public Vector2 center;


        public Camera(Viewport newView)
        {
            view = newView;
        }


        public void Update(GameTime gametime, Player gm)
        {

            center = new Vector2(gm.getHitbox().Center.X  -400 - gm.getHitbox().Width/2, gm.getHitbox().Center.Y  - 330);


            if (center.X - 0 <= Game1.map.level.leftBorder)
            {
                center.X = Game1.map.level.leftBorder;
            }

            if (center.X +750 >= Game1.map.level.rightBorder)
            {
                center.X = Game1.map.level.rightBorder - 750;
            }

            if (center.Y + 200 >= Game1.map.level.bottomBorder)
            {
                center.Y = Game1.map.level.bottomBorder - 200;
            }

            transform = Matrix.CreateScale(new Vector3(1, 1, 1)) * 
                Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0));

        }

    }
}
