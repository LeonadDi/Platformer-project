using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class Animation
    {

        Texture2D[] sprites;
        int currentSprite;
        int framesAmount;
        public bool readyToDraw;

        float sequence;     //time to draw
        float elapsed;


        public Animation( Texture2D spritesheet, int frameamount, int framesizeX, int framesizeY, float seq)
        {
            sprites = new Texture2D[frameamount];
            framesAmount = frameamount;
            for (int i = 0; i < frameamount; i++)
            {
                sprites[i] =
                Utility.ImageCropper.Crop(spritesheet, new Rectangle(i * framesizeX, 0 * framesizeY, framesizeX, framesizeY));
            }

            this.sequence = seq;
            currentSprite = 0;
            
        }


        


        public void update(GameTime gt)
        {
            elapsed += (float)gt.ElapsedGameTime.Milliseconds;

            if (elapsed >= sequence)
            {
                currentSprite++;
                elapsed = 0;
            }
            
            
        }

        public Texture2D getSprite()
        {
            
            if (currentSprite >= sprites.Length)
            {
                currentSprite = 0;
            }
            return sprites[currentSprite];
        }



    }
}
