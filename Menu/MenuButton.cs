using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class MenuButton
    {

        Texture2D _texture;
        Vector2 _position;
        Rectangle _rect;
        string _text;

        public bool selected;


        public MenuButton(string text, Vector2 position)
        {
            _text = text;
            _position = position;
        }


        public void _draw(SpriteBatch spriteBatch, bool selected)
        {
            if (selected == true)
            {
                ContentManager.DrawText(spriteBatch, ContentManager.font, _text, Color.Orange, Color.Yellow, 1f, _position);
                //spriteBatch.DrawString(ContentManager.font, _text, _position, Color.Yellow);
            }
            else
            {
                ContentManager.DrawText(spriteBatch, ContentManager.font, _text, Color.OrangeRed, Color.Orange, 1f, _position);
                //spriteBatch.DrawString(ContentManager.font, _text, _position, Color.DarkOrange);
            }

        }


        public void _update(GameTime gameTime)
        {
         


        }




    }
}
