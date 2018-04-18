using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class Spike
    {
        Vector2 size;
        Vector2 position;
        public Rectangle hitbox;
        Texture2D sprite;
        public int damage = 5;

        public Spike(Vector2 size, Vector2 position, Texture2D sprite)
        {
            this.size = size;
            this.position = position;
            this.sprite = sprite;
            hitbox = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.Green);
            }
            if (!Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.White);
            }
        }

    }
}
