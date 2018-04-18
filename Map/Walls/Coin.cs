using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class Coin
    {
        public Vector2 size;
        public Vector2 position;
        public Rectangle hitbox;
        public Texture2D sprite;
        public int value;
        public int keys;
        public int boost;


        public Coin(Vector2 size, Vector2 position, Texture2D sprite, int value, int keys, int boost)
        {
            this.size = size;
            this.position = position;
            this.sprite = sprite;
            this.value = value;
            this.keys = keys;
            this.boost = boost;
            
            hitbox = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.Yellow);
                //spriteBatch.DrawString(ContentManager.font, value.ToString(), position , Color.Orange);
                ContentManager.DrawText(spriteBatch, ContentManager.font, value.ToString(), Color.Black, Color.Yellow, 1f, position);
            }
            if (!Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.White);
            }
        }

    }
}
