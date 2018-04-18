using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public static class ContentManager
    {

        public static Texture2D tempTexture;
        public static Texture2D herojump;
        public static Texture2D herofall;
        public static Texture2D herodead;
        public static Animation herowalk;

        public static Texture2D crabidle;
        public static Texture2D crabhide;
        public static Animation crabwalk;
        public static Animation crabattack;
        public static Texture2D crabdead;

        public static Texture2D[] wallsArray;

        public static SpriteFont font;

        public static void DrawText(SpriteBatch spritebatch, SpriteFont font, string text, Color backColor, Color frontColor, float scale, Vector2 position)
        {
            Vector2 origin = Vector2.Zero;

            spritebatch.DrawString(font, text, position + new Vector2(1 * scale, 1 * scale), backColor, 0, origin, scale, SpriteEffects.None, 1f);
            spritebatch.DrawString(font, text, position + new Vector2(-1 * scale, 1 * scale), backColor, 0, origin, scale, SpriteEffects.None, 1f);
            spritebatch.DrawString(font, text, position + new Vector2(-1 * scale, -1 * scale), backColor, 0, origin, scale, SpriteEffects.None, 1f);
            spritebatch.DrawString(font, text, position + new Vector2(1 * scale, -1 * scale), backColor, 0, origin, scale, SpriteEffects.None, 1f);          

            spritebatch.DrawString(font, text, position, frontColor, 0, origin, scale, SpriteEffects.None, 0f);
        }

    }
}
