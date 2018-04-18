using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class Door
    {
        Vector2 size;
        Vector2 position;
        public Rectangle hitbox;
        Texture2D sprite;
        public int keyRequired;

        public Door(Vector2 size, Vector2 position, Texture2D sprite, int keyRequired)
        {
            this.size = size;
            this.position = position;
            this.sprite = sprite;
            this.keyRequired = keyRequired;
            this.hitbox = new Rectangle(
                (int)position.X,
                (int)position.Y,
                (int)size.X,
                (int)size.Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.Red);
                ContentManager.DrawText(spriteBatch, ContentManager.font, position.X / 50 + "\n" + position.Y / 50, Color.Black, Color.Yellow, 0.8f, position);
            }
            if (!Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.White);
            }
            //spriteBatch.Draw(sprite, position, Color.White);
        }
    }
}
