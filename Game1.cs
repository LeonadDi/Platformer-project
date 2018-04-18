using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace _2dGameProjectMG
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {

        public enum GameState
        {
            MainMenu,
            Gameplay,
            EndOfGame,
            About,
            Exit,
        }

        public MenuManager menuManager;
        public static GameState _state = GameState.MainMenu;

        public static void setState()
        {
            _state = GameState.MainMenu;
        }


        

        public static bool createHero;

        public static Map map;
        //public static List<Wall> walls= new List<Wall>();
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static Player Player1;
        public Camera camera;
        public Texture2D menuBG;
        

        public static bool markSprite { get; set; }
        



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
            markSprite = false;


            menuManager = new MenuManager();
        }

        
        protected override void Initialize()
        {
           base.Initialize();

            
            camera = new Camera(GraphicsDevice.Viewport);
        }

        
        protected override void LoadContent()
        {
           
            spriteBatch = new SpriteBatch(GraphicsDevice);

            menuBG = Content.Load<Texture2D>("the_new_dawn_mainmenubackground");

            ContentManager.font = Content.Load<SpriteFont>("font");


            ContentManager.tempTexture = Content.Load<Texture2D>("heroalter");
            ContentManager.herojump = Content.Load<Texture2D>("heroalter_jump");
            ContentManager.herofall = Content.Load<Texture2D>("heroalter_fall");
            ContentManager.herowalk = new Animation(Content.Load<Texture2D>("heroalter_walkspritesheet"), 4, 64, 64, 150);
            ContentManager.herodead = Content.Load<Texture2D>("heroalter_dead");

            ContentManager.crabidle = Content.Load<Texture2D>("stone_crab_idle");
            ContentManager.crabhide = Content.Load<Texture2D>("stone_crab_ambush");
            ContentManager.crabdead = Content.Load<Texture2D>("stone_crab_dead");
            ContentManager.crabwalk = new Animation(Content.Load<Texture2D>("stone_crab_walk"), 2, 64, 64, 300);
            ContentManager.crabattack = new Animation(Content.Load<Texture2D>("stone_crab_attack"), 3, 64, 64, 150);

            ContentManager.wallsArray = new Texture2D[50];

            ContentManager.wallsArray[0] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(0 * 50, 0 * 50, 50, 50)); //Чистая земля
            ContentManager.wallsArray[1] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(1 * 50, 0 * 50, 50, 50)); //Земля
            ContentManager.wallsArray[2] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(2 * 50, 0 * 50, 50, 50)); //Земля-почва
            ContentManager.wallsArray[3] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(3 * 50, 0 * 50, 50, 50)); //Почва
            ContentManager.wallsArray[4] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(4 * 50, 0 * 50, 50, 50)); //Трава
            ContentManager.wallsArray[5] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(5 * 50, 0 * 50, 50, 50)); //Пустота
            ContentManager.wallsArray[6] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(6 * 50, 0 * 50, 50, 50)); //Куст
            ContentManager.wallsArray[7] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(7 * 50, 0 * 50, 50, 50)); //Высокая трава
            ContentManager.wallsArray[8] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(0 * 50, 1 * 50, 50, 50)); //Камень
            ContentManager.wallsArray[9] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(1 * 50, 1 * 50, 50, 50)); //Цветы 1
            ContentManager.wallsArray[10] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(2 * 50, 1 * 50, 50, 50)); //Цветы 2
            ContentManager.wallsArray[11] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(3 * 50, 1 * 50, 50, 50)); //Низ земли
            ContentManager.wallsArray[12] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(4 * 50, 1 * 50, 50, 50)); //Монета
            ContentManager.wallsArray[13] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(5 * 50, 1 * 50, 50, 50)); //Ключ
            ContentManager.wallsArray[14] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(6 * 50, 1 * 50, 50, 50)); //Небо
            ContentManager.wallsArray[15] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(7 * 50, 1 * 50, 50, 50)); //Земля с травой выступ лево
            ContentManager.wallsArray[16] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(0 * 50, 2 * 50, 50, 50)); //Земля с травой выступ право
            ContentManager.wallsArray[17] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(1 * 50, 2 * 50, 50, 50)); //Стена край лево
            ContentManager.wallsArray[18] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(2 * 50, 2 * 50, 50, 50)); //Стена край право
            ContentManager.wallsArray[19] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(3 * 50, 2 * 50, 50, 50)); //Стена низ угол лево
            ContentManager.wallsArray[20] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(4 * 50, 2 * 50, 50, 50)); //Стена низ угол право
            ContentManager.wallsArray[21] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(5 * 50, 2 * 50, 50, 50)); //Пики
            ContentManager.wallsArray[22] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(6 * 50, 2 * 50, 50, 50)); //Табличка
            ContentManager.wallsArray[23] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(7 * 50, 2 * 50, 50, 50)); //Стрелка вправо
            ContentManager.wallsArray[24] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(0 * 50, 3 * 50, 50, 50)); //Стрелка влево
            ContentManager.wallsArray[25] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(1 * 50, 3 * 50, 50, 50)); //Стрелка вверх
            ContentManager.wallsArray[26] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(2 * 50, 3 * 50, 50, 50)); //Стрелка вниз
            ContentManager.wallsArray[27] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(3 * 50, 3 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[28] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(4 * 50, 3 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[29] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(5 * 50, 3 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[30] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(6 * 50, 3 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[31] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(7 * 50, 3 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[32] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(0 * 50, 4 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[33] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(1 * 50, 4 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[34] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(2 * 50, 4 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[35] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(3 * 50, 4 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[36] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(4 * 50, 4 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[37] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(5 * 50, 4 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[38] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(6 * 50, 4 * 50, 50, 50)); //Дом
            ContentManager.wallsArray[39] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(7 * 50, 4 * 50, 50, 50)); //Дверь 1
            ContentManager.wallsArray[40] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(0 * 50, 5 * 50, 50, 50)); //Дверь 2
            ContentManager.wallsArray[41] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(1 * 50, 5 * 50, 50, 50)); //Пещера 1
            ContentManager.wallsArray[42] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(2 * 50, 5 * 50, 50, 50)); //Пещера 2
            ContentManager.wallsArray[43] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(3 * 50, 5 * 50, 50, 50)); //Пещера 3
            ContentManager.wallsArray[44] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(4 * 50, 5 * 50, 50, 50)); //дабл джамп
            ContentManager.wallsArray[45] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(5 * 50, 5 * 50, 50, 50)); //вол джамп
            ContentManager.wallsArray[46] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(6 * 50, 5 * 50, 50, 50)); //дверь 1
            ContentManager.wallsArray[47] = Utility.ImageCropper.Crop(Content.Load<Texture2D>("16x16_grassland_new"), new Rectangle(7 * 50, 5 * 50, 50, 50)); //дверь 2



            //wallsArray[8] = Content.Load<Texture2D>("greenbox");
            //wallsArray[9] = Content.Load<Texture2D>("title1");
            //wallsArray[10] = Content.Load<Texture2D>("title2");
            //wallsArray[11] = Content.Load<Texture2D>("title3");



            //wallsArray[1] = Content.Load<Texture2D>("wall25");
            Player1 = new Player();
            
            map = new Map(ContentManager.wallsArray);
            map.advancedInitMap();
        }

        public void crHero()
        {
            Player1 = new Player();
        }
               
        protected override void UnloadContent()
        {
            
        }

        public Camera getCamera()
        {
            return camera;
        }

        
        protected override void Update(GameTime gameTime)
        {


            
            switch (_state)
            {
                case GameState.MainMenu:
                    UpdateMainMenu(gameTime);
                    break;
                case GameState.Gameplay:
                    UpdateGameplay(gameTime);
                    break;
                case GameState.EndOfGame:
                    //UpdateEndOfGame(gameTime);
                    break;
                
            }
         
            base.Update(gameTime);
        }

                

        private void UpdateMainMenu(GameTime gameTime)
        {
            menuManager._update(gameTime);
            if (menuManager.exit)
            {
                Exit();
            }
            
        }

        private void UpdateGameplay(GameTime gameTime)
        {
            if (createHero)
            {
                crHero();
                createHero = false;
            }

            if (Player1 != null)
            {
                Player1.Update(gameTime);
                camera.Update(gameTime, Player1);
            }

            foreach (Crab item in map.enemies)
            {
                
                item.Update(gameTime);
            }
            
        }

        protected override void Draw(GameTime gameTime)
        {

            switch (_state)
            {
                case GameState.MainMenu:
                    DrawMainMenu(gameTime);
                    break;
                case GameState.Gameplay:
                    DrawGameplay(gameTime);
                    break;
                case GameState.EndOfGame:
                    //DrawEndOfGame(gameTime);
                    break;
            }
          
            base.Draw(gameTime);
        }

        private void DrawMainMenu(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGreen);
            spriteBatch.Begin();

            spriteBatch.Draw(menuBG, new Vector2(0, 0), Color.White);

            menuManager._draw(spriteBatch);

            spriteBatch.End();

        }

        private void DrawGameplay(GameTime gameTime)
        {
            if (map.currentMapID == 0 || map.currentMapID == 1 || map.currentMapID == 2)
            {
                GraphicsDevice.Clear(Color.LightBlue);
            }
            if (map.currentMapID == 3 || map.currentMapID == 4)
            {
                GraphicsDevice.Clear(Color.RosyBrown);
            }
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, camera.transform);

            

            foreach (Wall test in map.walls)
            {
                test.Draw(spriteBatch);
            }

            foreach (WSprite test in map.wsprites)
            {
                test.Draw(spriteBatch);
            }

            foreach (Door test in map.doors)
            {
                test.Draw(spriteBatch);
            }

            foreach (Spike test in map.spikes)
            {
                test.Draw(spriteBatch);
            }

            foreach (Portals test in map.portals)
            {
                test.Draw(spriteBatch);
            }

            foreach (Coin test in map.coins)
            {
                test.Draw(spriteBatch);
            }

            foreach (Crab test in map.enemies)
            {
                test.Draw(spriteBatch);
            }

            if (Player1!=null)
            {
                Player1.Draw(spriteBatch);
            }





            if (Player1 != null)
            {
                /*spriteBatch.DrawString(font, "camX:" + (int)camera.center.X, new Vector2(camera.center.X + 20, camera.center.Y + 400), Color.Orange);
                spriteBatch.DrawString(font, "camY:" + (int)camera.center.Y, new Vector2(camera.center.X + 20, camera.center.Y + 430), Color.Orange);

                spriteBatch.DrawString(font, "X:" + (float)Player1.position.X/50, new Vector2(camera.center.X + 20, camera.center.Y + 550), Color.Orange);
                spriteBatch.DrawString(font, "Y:" + (float)Player1.position.Y/50, new Vector2(camera.center.X + 20, camera.center.Y + 573), Color.Orange);
                spriteBatch.DrawString(font, "XVelocity:" + Player1.movingThisFrame.X, new Vector2(camera.center.X + 150, camera.center.Y + 550), Color.Orange);
                spriteBatch.DrawString(font, "YVelocity:" + Player1.movingThisFrame.Y * -1, new Vector2(camera.center.X + 150, camera.center.Y + 573), Color.Orange);

                spriteBatch.DrawString(font, "G-Time: " + gameTime.TotalGameTime.Minutes + "m" + gameTime.TotalGameTime.Seconds + "s", new Vector2(camera.center.X + 20, camera.center.Y + 527), Color.Orange);
                spriteBatch.DrawString(font, "El-Time: " + gameTime.ElapsedGameTime.TotalMilliseconds, new Vector2(camera.center.X + 20, camera.center.Y + 500), Color.Orange);

                spriteBatch.DrawString(font, "State:" + Player1.state, new Vector2(camera.center.X + 20, camera.center.Y + 475), Color.Orange);
                spriteBatch.DrawString(font, "Dirctn:" + Player1.direction, new Vector2(camera.center.X + 190, camera.center.Y + 475), Color.Orange);*/
                ContentManager.DrawText(spriteBatch, ContentManager.font, "HP:" + Player1.HP, Color.White, Color.Black, 1f, new Vector2(camera.center.X + 10, camera.center.Y + 475));
                //spriteBatch.DrawString(ContentManager.font, "HP:" + Player1.HP, new Vector2(camera.center.X + 10, camera.center.Y + 475), Color.Orange);
                ContentManager.DrawText(spriteBatch, ContentManager.font, "Score:" + Player1.Score, Color.White, Color.Black, 1f, new Vector2(camera.center.X + 10, camera.center.Y + 500));
                ContentManager.DrawText(spriteBatch, ContentManager.font, "Keys: " + Player1.Key, Color.White, Color.Black, 1f, new Vector2(camera.center.X + 10, camera.center.Y + 525));

                //ContentManager.DrawText(spriteBatch, ContentManager.font, Player1.maxjumps.ToString(), Color.White, Color.Black, 1f, new Vector2(camera.center.X + 500, camera.center.Y + 500));
                //ContentManager.DrawText(spriteBatch, ContentManager.font, Player1.jumpsdone.ToString(), Color.White, Color.Black, 1f, new Vector2(camera.center.X + 500, camera.center.Y + 550));

                //spriteBatch.DrawString(ContentManager.font, "Score:" + Player1.Score, new Vector2(camera.center.X + 10, camera.center.Y + 500), Color.Orange);
            }

            if (Player1 != null)
            {
                foreach (var item in Game1.map.portals)
                {
                    if (Player1.hitbox.Intersects(item.hitbox))
                    {

                        item.drawMessage(spriteBatch, Player1);
                    }
                }
            }

            spriteBatch.End();
        }
    }
}
