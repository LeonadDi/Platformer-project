using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2dGameProjectMG
{
    public class Upgrade
    {

        public Vector2 size;
        public Vector2 position;
        public Rectangle hitbox;
        public Texture2D sprite;
        public int value;




        public Upgrade( Vector2 position, Vector2 size, Texture2D sprite, int value)
        {
            this.size = size;
            this.position = position;
            this.sprite = sprite;
            this.value = value;
            hitbox = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.Gray);
                //spriteBatch.DrawString(ContentManager.font, value.ToString(), position , Color.Orange);
                //ContentManager.DrawText(spriteBatch, ContentManager.font, value.ToString(), Color.Black, Color.Yellow, 1f, position);
            }
            if (!Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.White);
            }
        }


    }
}
