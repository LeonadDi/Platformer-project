using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2dGameProjectMG
{
    public class WSprite: TempWall
    {
        Vector2 size;
        Vector2 position;
        public Rectangle hitbox;
        Texture2D sprite;

        public WSprite(Vector2 size, Vector2 position, Texture2D sprite)
        {
            this.position = position;
            this.sprite = sprite;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Game1.markSprite)
            {
                //spriteBatch.Draw(sprite, position, Color.Red);
            }
            if (!Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.White);
            }
        }
    }
}
