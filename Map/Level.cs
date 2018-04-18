using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class Level
    {
        int currentMapID;
        public int leftBorder;
        public int rightBorder;
        public int bottomBorder;



        internal void buildMap(ref List<Wall> walls, ref List<WSprite> wsprites, ref List<Spike> spikes, ref List<Portals> portals, ref List<Coin> coins, ref List<Enemy> enemies, ref List<Door> doors, Texture2D[] wallTexture)
        {
            walls = new List<Wall>();
            wsprites = new List<WSprite>();
            spikes = new List<Spike>();
            portals = new List<Portals>();
            coins = new List<Coin>();
            enemies = new List<Enemy>();


            switch (currentMapID)
            {


                case -1:
                    throw new Exception();

                case 0:
                    leftBorder = (-28 * 50);
                    rightBorder = (23 * 50);
                    bottomBorder = (3 * 50);
                    Game1.Player1.SetInStartPosition(-28*50, 6*50);

                    //coins.Add(new Coin(new Vector2(50, 50), new Vector2(6 * 50, 7 * 50), wallTexture[12], 5));


                    

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-28 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-27 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-26 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-25 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-24 * 50, 8 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-28 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-27 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-26 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-25 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-24 * 50, 8 * 50), wallTexture[4]));

                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-24 * 50, 7 * 50), wallTexture[12], 10, 0, 0));
                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-22 * 50, 7 * 50), wallTexture[12], 10, 0, 0));
                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-20 * 50, 7 * 50), wallTexture[12], 10, 0, 0));
                    

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-23 * 50, 8 * 50), wallTexture[1]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-23 * 50, 5 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-24 * 50, 5 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-25 * 50, 5 * 50), wallTexture[15]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-22 * 50, 5 * 50), wallTexture[16]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-23 * 50, 5 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-24 * 50, 5 * 50), wallTexture[4]));
                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-24 * 50, 4 * 50), wallTexture[12], 10, 0, 0));
                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-23 * 50, 4 * 50), wallTexture[12], 10, 0, 0));
                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-24 * 50, 3 * 50), wallTexture[12], 10, 0, 0));
                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-23 * 50, 3 * 50), wallTexture[12], 10, 0, 0));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-23 * 50, 6 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-23 * 50, 7 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-24 * 50, 6 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-24 * 50, 7 * 50), wallTexture[1]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-25 * 50, 6 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-25 * 50, 7 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-22 * 50, 6 * 50), wallTexture[18]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-22 * 50, 7 * 50), wallTexture[18]));


                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-23 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-22 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-21 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-20 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-19 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-18 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-17 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-16 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-15 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-14 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-13 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-12 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-11 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-10 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-9 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-8 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-7 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-6 * 50, 8 * 50), wallTexture[4]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-18 * 50, 6 * 50), wallTexture[8]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-15 * 50, 6 * 50), wallTexture[9]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-14 * 50, 6 * 50), wallTexture[10]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-13 * 50, 6 * 50), wallTexture[10]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-12 * 50, 6 * 50), wallTexture[9]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-11 * 50, 6 * 50), wallTexture[9]));

                    enemies.Add(new Crab(new Vector2(-9 * 50, 5 * 50)));
                    enemies.Add(new Crab(new Vector2(0 * 50, 6 * 50)));
                    enemies.Add(new Crab(new Vector2(16 * 50, 6 * 50)));


                    for (int i = -19; i <= -7 ; i++)
                    {
                        
                        wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(i * 50, 8 * 50), wallTexture[1]));
                    }
                    for (int i = -28; i <= -6; i++)
                    {

                        wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(i * 50, 9 * 50), wallTexture[2]));
                    }
                    for (int i = -28; i <= -6; i++)
                    {

                        wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(i * 50, 10 * 50), wallTexture[3]));
                    }

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-22 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-21 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-20 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-19 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-18 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-17 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-16 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-15 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-14 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-13 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-12 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-11 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-10 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-9 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-8 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-7 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-6 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-5 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-4 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-3 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-2 * 50, 8 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-2 * 50, 7 * 50), wallTexture[10]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-1 * 50, 7 * 50), wallTexture[9]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-0 * 50, 7 * 50), wallTexture[10]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(0 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 8 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 7 * 50), wallTexture[8]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 8 * 50), wallTexture[1]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(7 * 50, 7 * 50), wallTexture[9]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 7 * 50), wallTexture[10]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 7 * 50), wallTexture[9]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 7 * 50), wallTexture[9]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(8 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(9 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(12 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(15 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(21 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(22 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(23 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(23 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(23 * 50, 6 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(23 * 50, 5 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(23 * 50, 4 * 50), wallTexture[1]));


                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 7 * 50), wallTexture[22]));
                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 7 * 50), wallTexture[23]));

                    

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-5 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-4 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-3 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-2 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-1 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(0 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(1 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(7 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 9 * 50), wallTexture[2]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-5 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-4 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-3 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-2 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-1 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(0 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(7 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 8 * 50), wallTexture[4]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 8 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 8 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 9 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 9 * 50), wallTexture[3]));


                    spikes.Add(new Spike(new Vector2(50, 50), new Vector2(12 * 50, 9 * 50), wallTexture[21]));
                    spikes.Add(new Spike(new Vector2(50, 50), new Vector2(13 * 50, 9 * 50), wallTexture[21]));


                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 9 * 50), wallTexture[21]));
                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 9 * 50), wallTexture[21]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 9 * 50), wallTexture[18]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 9 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 8 * 50), wallTexture[16]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 8 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 7 * 50), wallTexture[15]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(14 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 7 * 50), wallTexture[16]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(16 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(17 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(18 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(19 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(20 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(21 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(22 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(22 * 50, 7 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(22 * 50, 6 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(22 * 50, 5 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(22 * 50, 4 * 50), wallTexture[15]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(23 * 50, 4 * 50), wallTexture[4]));

                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 7 * 50), wallTexture[22]));
                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 7 * 50), wallTexture[26]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(19 * 50, 7 * 50), wallTexture[22]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(19 * 50, 7 * 50), wallTexture[23]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(21 * 50, 7 * 50), wallTexture[22]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(21 * 50, 7 * 50), wallTexture[24]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-5 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-4 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-3 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-2 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-1 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-0 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(1 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(7 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(16 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(17 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(18 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(19 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(20 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(21 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(22 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(23 * 50, 10 * 50), wallTexture[3]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(16 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(17 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(18 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(19 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(20 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(21 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(22 * 50, 9 * 50), wallTexture[2]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(23 * 50, 9 * 50), wallTexture[2]));

                    portals.Add(new Portals(new Vector2(50, 75), new Vector2(20 * 50, 7 * 50), wallTexture[6], 1, new Vector2(1 * 50, 6 * 50), "портала."));

                    break;


                case 1:

                    leftBorder = (-2 * 50);
                    rightBorder = (20 * 50);
                    bottomBorder = (3 * 50);

                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(3.5f * 50, 6 * 50), wallTexture[45], 0, 0, 2));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-2 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(0 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 7 * 50), wallTexture[1]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 3 * 50), wallTexture[1]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 3 * 50), wallTexture[1]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 3 * 50), wallTexture[1]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 4 * 50), wallTexture[1]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 3 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(8 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(9 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(12 * 50, 8 * 50), wallTexture[1]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 6 * 50), wallTexture[1]));

                    
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(15 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 6 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 5 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 4 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 3 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 3 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 3 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 3 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 3 * 50), wallTexture[1]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(9 * 50, 5 * 50), wallTexture[33]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 5 * 50), wallTexture[36]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 5 * 50), wallTexture[35]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(12 * 50, 5 * 50), wallTexture[35]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 5 * 50), wallTexture[35]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 8 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 7 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 6 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 6 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 6 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 6 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 5 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 5 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 5 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 5 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 4 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 4 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 4 * 50), wallTexture[1]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 4 * 50), wallTexture[1]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-2 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-0 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(8 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(9 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(12 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(15 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 9 * 50), wallTexture[2]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 9 * 50), wallTexture[2]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-2 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-0 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(8 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(9 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(12 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(15 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 10 * 50), wallTexture[3]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 10 * 50), wallTexture[3]));



                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-2 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(-1 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(0 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 8 * 50), wallTexture[4]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 7 * 50), wallTexture[15]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 7 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 7 * 50), wallTexture[4]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 7 * 50), wallTexture[16]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(5 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(6 * 50, 8 * 50), wallTexture[4])); 
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(7 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(14 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 8 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 7 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 6 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 5 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 4 * 50), wallTexture[17]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 3 * 50), wallTexture[15]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(16 * 50, 3 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(17 * 50, 3 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(18 * 50, 3 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(19 * 50, 3 * 50), wallTexture[4]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(20 * 50, 3 * 50), wallTexture[4]));



                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 2 * 50), wallTexture[6]));

                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 2 * 50), wallTexture[7]));
                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(2 * 50, 2 * 50), wallTexture[6]));


                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 5 * 50), wallTexture[5]));
                    
                    //wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(4 * 50, 6 * 50), wallTexture[3]));
                   
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(3 * 50, 2 * 50), wallTexture[5]));
                    

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(14 * 50, 7 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 7 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 7 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 7 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(14 * 50, 6 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 6 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 6 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 6 * 50), wallTexture[27]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 7 * 50), wallTexture[29]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 7 * 50), wallTexture[28]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 7 * 50), wallTexture[28]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 6 * 50), wallTexture[29]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(9 * 50, 6 * 50), wallTexture[28]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 6 * 50), wallTexture[28]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(8 * 50, 5 * 50), wallTexture[32]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(14 * 50, 5 * 50), wallTexture[38]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 4 * 50), wallTexture[28]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 4 * 50), wallTexture[28]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(10 * 50, 3 * 50), wallTexture[28]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 3 * 50), wallTexture[28]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 4 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 4 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 3 * 50), wallTexture[27]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(13 * 50, 3 * 50), wallTexture[27]));

                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 7 * 50), wallTexture[22]));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(15 * 50, 7 * 50), wallTexture[25]));

                    portals.Add(new Portals(new Vector2(50, 75), new Vector2(12 * 50, 7 * 50), wallTexture[40], 1, new Vector2(11 * 50, 3 * 50 +25), "двери."));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(12 * 50, 6 * 50), wallTexture[39]));

                    portals.Add(new Portals(new Vector2(50, 75), new Vector2(11 * 50, 4 * 50), wallTexture[40], 1, new Vector2(12 * 50, 6 * 50 + 25), "двери."));
                    wsprites.Add(new WSprite(new Vector2(50, 50), new Vector2(11 * 50, 3 * 50), wallTexture[39]));

                    portals.Add(new Portals(new Vector2(50, 75), new Vector2(19 * 50, 2 * 50), wallTexture[6], 3, new Vector2(-2 * 50, 6 * 50), "перехода."));

                    break;
                case 3:


                    leftBorder = (-2 * 50);
                    rightBorder = (22 * 50);
                    bottomBorder = (3 * 50);

                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(1 * 50, 2 * 50), wallTexture[44], 10, 0, 1));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-2 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(0 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[41]));
                    //spikes.Add(new Spike(new Vector2(50, 50), new Vector2(2 * 50, 9 * 50), wallTexture[21]));
                    //spikes.Add(new Spike(new Vector2(50, 50), new Vector2(3 * 50, 9 * 50), wallTexture[21]));
                    //spikes.Add(new Spike(new Vector2(50, 50), new Vector2(4 * 50, 9 * 50), wallTexture[21]));
                    //spikes.Add(new Spike(new Vector2(50, 50), new Vector2(5 * 50, 9 * 50), wallTexture[21]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 9 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 10 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 10 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 10 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 9 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(8 * 50, 8 * 50), wallTexture[41]));
                    spikes.Add(new Spike(new Vector2(50, 50), new Vector2(8 * 50, 7 * 50), wallTexture[21]));
                    spikes.Add(new Spike(new Vector2(50, 50), new Vector2(9 * 50, 7 * 50), wallTexture[21]));
                    spikes.Add(new Spike(new Vector2(50, 50), new Vector2(10 * 50, 7 * 50), wallTexture[21]));
                    spikes.Add(new Spike(new Vector2(50, 50), new Vector2(11 * 50, 7 * 50), wallTexture[21]));
                    spikes.Add(new Spike(new Vector2(50, 50), new Vector2(12 * 50, 7 * 50), wallTexture[21]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(9 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(10 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(11 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(12 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(15 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(18 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 6 * 50), wallTexture[41]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(17 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(16 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(15 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(14 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 4 * 50), wallTexture[41]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(6 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 3 * 50), wallTexture[41]));
                
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(21 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(22 * 50, 7 * 50), wallTexture[41]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(0 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-2 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(19 * 50, 7 * 50), wallTexture[2]));

                    for (int i = -2; i <= 1; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, 9 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 2; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, 10 * 50), wallTexture[1])); }
                    for (int i = 6; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, 10 * 50), wallTexture[1])); }
                    for (int i = 7; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, 9 * 50), wallTexture[1])); }
                    for (int i = 13; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, 8 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, -1 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, -2 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, -3 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, -4 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, -5 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, -6 * 50), wallTexture[1])); }
                    for (int i = -2; i <= 22; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(i * 50, -7 * 50), wallTexture[1])); }
                    for (int i = 0; i <= 2; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(20 * 50, i * 50), wallTexture[1])); }
                    for (int i = 0; i <= 4; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(21 * 50, i * 50), wallTexture[1])); }
                    for (int i = 0; i <= 3; i++) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(22 * 50, i * 50), wallTexture[1])); }


                    coins.Add(new Coin(new Vector2(50, 50), new Vector2(-1 * 50, 2 * 50), wallTexture[13], 0, 1, 0));

                    doors.Add(new Door(new Vector2(50, 50), new Vector2(21 * 50, 5 * 50), wallTexture[46], 1));
                    doors.Add(new Door(new Vector2(50, 50), new Vector2(21 * 50, 6 * 50), wallTexture[47], 1));

                    portals.Add(new Portals(new Vector2(50, 75), new Vector2(22 * 50, 6 * 50), wallTexture[6], 4, new Vector2(-2 * 50, 6 * 50), "перехода."));



                    break;
                case 4:
                    leftBorder = (-2 * 50);
                    rightBorder = (28 * 50);
                    bottomBorder = (1 * 50);

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-2 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(0 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 8 * 50), wallTexture[41]));

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 8 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 7 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 6 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 5 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 2 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(2 * 50, 1 * 50), wallTexture[41]));

                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 8 * 50), wallTexture[41]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 7 * 50), wallTexture[41]));
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 6 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 5 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 4 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 3 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 2 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(-1 * 50, 1 * 50), wallTexture[41]));
                    for (int i = 8; i >= 6; i--) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(5 * 50, i * 50), wallTexture[1])); }
                    for (int i = 8; i >= 4; i--) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(4 * 50, i * 50), wallTexture[1])); }
                    for (int i = 8; i >= 1; i--) { walls.Add(new Wall(new Vector2(50, 50), new Vector2(3 * 50, i * 50), wallTexture[1])); }
                    for (int i = 6; i <= 28; i++) { spikes.Add(new Spike(new Vector2(50, 50), new Vector2(i * 50, 8 * 50), wallTexture[21])); }

                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(7 * 50, 1 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(13 * 50, 1 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(23 * 50, 1 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(24 * 50, 1 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(24 * 50, 2 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(25 * 50, 1 * 50), wallTexture[41]));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(26 * 50, 1 * 50), wallTexture[41]));
                    enemies.Add(new Crab(new Vector2(50 * 26, 50 * -1)));
                    enemies.Add(new Crab(new Vector2(50 * 13, 50 * -1)));
                    walls.Add(new Wall(new Vector2(50, 50), new Vector2(28 * 50, 1 * 50), wallTexture[41]));

                    break;

            }


        }

        

        internal void createWalls(ref List<Wall> walls, Texture2D[] wallTexture)
        {
            switch (currentMapID)
            {
                case 0:
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 2 * 50), wallTexture[0]));
                    break;
                case 1:
                    //walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 2 * 50), wallTexture[1]));
                    break;
                default:
                    break;
            }


            //walls.Add(new Wall(new Vector2(50, 50), new Vector2(1 * 50, 2 * 50), wallTexture[0]));
        }

        internal void createWSprites(ref List<WSprite> wsprites, Texture2D[] wallTexture)
        {
            
        }



        internal void setCurrent(int currentID)
        {
            currentMapID = currentID;
        }

        
    }
}
