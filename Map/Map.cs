using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2dGameProjectMG
{
    public class Map
    {

        public Map(Texture2D[] sprite)
        {
            wallTexture = sprite;

            
        }


        

        Texture2D[] wallTexture;

        
        public Level level = new Level();

        public int currentMapID = 0;
        public List<Wall> walls = new List<Wall>();
        public List<WSprite> wsprites = new List<WSprite>();
        public List<Spike> spikes = new List<Spike>();
        public List<Portals> portals = new List<Portals>();
        public List<Door> doors= new List<Door>();
        public List<Coin> coins = new List<Coin>();
        public List<Enemy> enemies = new List<Enemy>();









        public void advancedInitMap()
        {
            loadLevel(currentMapID);
        }

        private void loadLevel(int currentMapID)
        {

            level.setCurrent(currentMapID);
            level.buildMap(ref walls, ref wsprites, ref spikes, ref portals, ref coins, ref enemies, ref doors, wallTexture);

        }


        public void external_load(int ID)
        {
            currentMapID = ID;
            loadLevel(currentMapID);
        }


        public void createWalls()
        {
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 8 * 50), wallTexture[0]));
           // //walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 7 * 50), wallTexture[0]));
           // //walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 6 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 7 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 7 * 50), wallTexture[0]));
           // //walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 6 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 3 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 3 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 3 * 50), wallTexture[0]));
           //// walls.Add(new Wall(new Vector2(0, 0), new Vector2(9 * 50, 5 * 50), wallTexture[9]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(15 * 50, 6 * 50), wallTexture[0]));

           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 3 * 50), wallTexture[0]));
           // //walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 4 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(8 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(9 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 8 * 50), wallTexture[0]));
           // //walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 7 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(12 * 50, 8 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 6 * 50), wallTexture[0]));
           // walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 4 * 50), wallTexture[0]));
            
        }

        public void createWSprites()
        {
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 7 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 7 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 7 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 7 * 50), wallTexture[5]));

            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(7 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 8 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 7 * 50), wallTexture[4]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 8 * 50), wallTexture[1]));


            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 4 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 3 * 50), wallTexture[6]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 2 * 50), wallTexture[7]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 3 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 2 * 50), wallTexture[6]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 3 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 2 * 50), wallTexture[7]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 2 * 50), wallTexture[6]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 3 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 3 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 6 * 50), wallTexture[1]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 5 * 50), wallTexture[5]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 5 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 4 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 4 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 6 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 6 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 5 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 4 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 6 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 6 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 5 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 6 * 50), wallTexture[0]));

            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 7 * 50), wallTexture[3]));

            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 7 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 7 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 6 * 50), wallTexture[3]));

            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 5 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 4 * 50), wallTexture[0]));
            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 5 * 50), wallTexture[0]));

            //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 2 * 50), wallTexture[5]));


        }






    }
}
