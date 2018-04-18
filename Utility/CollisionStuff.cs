using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    static class CollisionStuff
    {



        public static bool IsCollingWith(List<Wall> walls, Mech mech)
        {
            //Rectangle rec = mech.getHitbox();
            foreach (Wall wallCol in walls)
            {
                if (mech.getHitbox().Intersects(wallCol.hitbox))
                    return true;
            }

            return false;
        }


        public static int SumHorizontal(List<Mech.CorrectionVector2> corrections)
        {
            int summ = 0;
            foreach (var item in corrections)
            {

                summ += (int)item.DirectionX;

            }
            
            return summ;
        }

        public static int SumVertical(List<Mech.CorrectionVector2> corrections)
        {
            int summ = 0;
            foreach (var item in corrections)
            {

                summ += (int)item.DirectionY;

            }

            return summ;
        }





    }
}
