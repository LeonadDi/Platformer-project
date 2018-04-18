using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2dGameProjectMG
{
    public class Portals
    {
        Vector2 size;
        Vector2 position;
        public Rectangle hitbox;
        Texture2D sprite;
        int ID;
        int LinkWorldID;
        Vector2 LinkCoords;
        bool garb;
        private bool intersect;
        string type;

        public Portals(Vector2 size, Vector2 position, Texture2D sprite, /*int ID,*/ int LinkWorldID, Vector2 LinkCoords, string type)
        {
            this.size = size;
            this.position = position;
            this.sprite = sprite;
            this.hitbox = new Rectangle(
                (int)position.X,
                (int)position.Y,
                (int)size.X,
                (int)size.Y);
            //this.ID = ID;
            this.LinkWorldID = LinkWorldID;
            this.LinkCoords = LinkCoords;
            this.type = type;
        }



        public void Teleport(ref Map map, Player player)
        {
            if (map.currentMapID != LinkWorldID)
            {
                map.external_load(LinkWorldID);
            }
            player.setCoords((int)LinkCoords.X, (int)LinkCoords.Y);

        }


        public void drawMessage(SpriteBatch spriteBatch, Player plr)
        {
            //spriteBatch.DrawString(ContentManager.font, "'X'", new Vector2(plr.position.X + 20, plr.position.Y - 30), Color.White);
            ContentManager.DrawText(spriteBatch, ContentManager.font, "Нажмите клавишу 'x'\nдля использования " + type, Color.Black, Color.Orange, 0.8f, new Vector2(plr.position.X - 90, plr.position.Y - 60));//+20;-30
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            if (Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.Blue);
            }

            

            if (!Game1.markSprite)
            {
                spriteBatch.Draw(sprite, position, Color.White * 1.0f);
            }
        }



    }
}