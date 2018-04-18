using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace _2dGameProjectMG
{
    public class Player : Mech
    {
        KeyboardState keyboardState;
        KeyboardState previousState;
        public int Score;
        public int Key;
        int l = 0;
        bool doublejumpobtained = false;
        bool walljumpobtained = false;

        enum LastWallJump { Left, Right, None };
        LastWallJump lastWall = new LastWallJump();

        bool foundWallleft;
        public bool foundWallright;

        public int jumpsdone = 0;
        public int maxjumps = 0;


        public Player()
        {
            Score = 0;


            this.texture = ContentManager.tempTexture;
            this.walk = ContentManager.herowalk;
            this.jump = ContentManager.herojump;
            this.fall = ContentManager.herofall;
            this._dead = ContentManager.herodead;
            this.HP = 20;
            //SetInStartPosition(0, 50 * 5);
            SetInStartPosition(-28 * 50, 6 * 50);

            this.hitbox = new Rectangle(
                (int)position.X - 10,
                (int)position.Y,
                30,
                70);

            this.speedOfMove = 5.0f;
            this.speedOfJump = 10.5f; //10
            this.speedOfMoveInAir = 6.0f;
            this.gravity = 0.5f; //05
            this.isOnGroundBool = true;

            previousState = Keyboard.GetState();
            direction = Direction.Right;
            lastWall = LastWallJump.None;
        }



        public new void Update(GameTime gametime)
        {
            if (doublejumpobtained)
            {
                maxjumps = 2;
            }
            foreach (Coin item in Game1.map.coins)
            {
                if (hitbox.isCollideVerti(item.hitbox, motion.Y))
                {
                    Score += item.value;
                    Key += item.keys;
                    if (item.boost==1)
                    {
                        doublejumpobtained = true;
                    }
                    if (item.boost == 2)
                    {
                        walljumpobtained = true;
                    }
                    Game1.map.coins.Remove(item);
                    break;
                }
            }

            if (HP <= 0)
            {
                dead = true;
                state = State.Dead;
            }
            spikeCheck();

            if (position.X <= Game1.map.level.leftBorder)
            {
                position.X = Game1.map.level.leftBorder;
            }

            if (position.X >= Game1.map.level.rightBorder)
            {
                position.X = Game1.map.level.rightBorder;
            }

            walk.update(gametime);

            if (isOnGroundBool)
            {
                lastWall = LastWallJump.None;
                if (!dead)
                {


                    if (motion.X == 0)
                    {
                        state = State.Idle;
                    }
                    else
                    {
                        state = State.Walk;
                    }
                }
                else
                {
                    state = State.Dead;
                }
            }
            else
            {
                if (!dead)
                {

                    if (motion.Y > 0)
                    {
                        state = State.Fall;
                    }
                    else
                    {
                        state = State.Jump;
                    }
                }
                else
                {
                    state = State.Dead;
                }
            }


            //hitbox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);


            movement();

            if (isOnGroundBool)
            {
                if (motion.X > speedOfMove)
                {
                    //motion.X = speedOfMove;
                }
                if (motion.X < -speedOfMove)
                {
                    //motion.X = -speedOfMove;
                }
            }
            else
            {
                if (motion.X > speedOfMoveInAir)
                {
                    //motion.X = speedOfMoveInAir;
                }
                if (motion.X < -speedOfMoveInAir)
                {
                    //motion.X = -speedOfMoveInAir;
                }
            }

            if (motion.X > 0)
            {
                if (isOnGroundBool)
                {
                    motion.X -= 1.0f;
                }
                else
                {
                    motion.X -= 0.2f;
                }
            }
            if (motion.X < 0)
            {
                if (isOnGroundBool)
                {
                    motion.X += 1.0f;
                }
                else
                {
                    motion.X += 0.2f;
                }
            }

            if (motion.X < 1 && motion.X > -1)
            {
                motion.X = 0f;
            }

            motion.Y += gravity;


            movingThisFrame.X = 0f;
            movingThisFrame.X += motion.X;

            movingThisFrame.Y = 0f;
            movingThisFrame.Y += motion.Y;

            //position.Y += motion.Y;



            //collision(this, Game1.map.walls);





            foreach (Wall platform in Game1.map.walls)
            {

                if (hitbox.isCollide1(platform.hitbox, movingThisFrame.X))
                {
                    if (movingThisFrame.X > 0)
                    {
                        while (hitbox.isCollide1(platform.hitbox, movingThisFrame.X))
                        {
                            //this.position.X += 1;

                            movingThisFrame.X -= 1.0f;

                            //if (movingThisFrame.X < 0) break;
                        }

                        movingThisFrame.X -= 1.0f;
                    }
                    else {
                        while (hitbox.isCollide1(platform.hitbox, movingThisFrame.X))
                        {
                            movingThisFrame.X += 1.0f;

                            //if (movingThisFrame.X > 0) break;
                        }

                        movingThisFrame.X += 1.0f;
                    }


                    movingThisFrame.X = 0;
                    motion.X = 0;
                }



                if (hitbox.isNearTopOf(platform.hitbox, motion.Y))
                {
                    if (motion.Y > 0)
                    {


                        this.position.Y = platform.hitbox.Top - 64;
                        //hitbox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
                        motion.Y = 0f;
                        movingThisFrame.Y = 0f;
                    }
                    else
                    {
                        this.position.Y = platform.hitbox.Bottom;
                        motion.Y = 0f;
                        movingThisFrame.Y = 0f;
                    }
                }



            }

            foreach (Door platform in Game1.map.doors)
            {
                if (hitbox.isCollide1(platform.hitbox, movingThisFrame.X))
                {
                    if (platform.keyRequired <= Key)
                    {
                        Game1.map.doors.Remove(platform);
                        break;
                    }

                    if (movingThisFrame.X > 0)
                    {
                        while (hitbox.isCollide1(platform.hitbox, movingThisFrame.X))
                        {
                            //this.position.X += 1;

                            movingThisFrame.X -= 1.0f;

                            //if (movingThisFrame.X < 0) break;
                        }

                        movingThisFrame.X -= 1.0f;
                    }
                    else {
                        while (hitbox.isCollide1(platform.hitbox, movingThisFrame.X))
                        {
                            movingThisFrame.X += 1.0f;

                            //if (movingThisFrame.X > 0) break;
                        }

                        movingThisFrame.X += 1.0f;
                    }


                    movingThisFrame.X = 0;
                    motion.X = 0;
                }



                if (hitbox.isNearTopOf(platform.hitbox, motion.Y))
                {
                    if (motion.Y > 0)
                    {


                        this.position.Y = platform.hitbox.Top - 64;
                        //hitbox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
                        motion.Y = 0f;
                        movingThisFrame.Y = 0f;
                    }
                    else
                    {
                        this.position.Y = platform.hitbox.Bottom;
                        motion.Y = 0f;
                        movingThisFrame.Y = 0f;
                    }
                }



            }


            bool found = false;
            foundWallleft = false;
            foundWallright = false;
            foreach (Wall platform in Game1.map.walls)
            {
                if (isOnGround(hitbox, platform.hitbox))
                {
                    found = true;
                }

                if (isOnWallRight(hitbox, platform.hitbox))
                {
                    foundWallleft = true;
                    
                }
                if (isOnWallLeft(hitbox, platform.hitbox))
                {
                    foundWallright = true;

                }
            }

            if (found)
            {
                isOnGroundBool = true;
            }
            else
            {
                isOnGroundBool = false;
            }

            if (foundWallleft)
            {
                isOnWallBoolLeft = true;
            }
            else
            {
                isOnWallBoolLeft = false;
            }

            if (foundWallright)
            {
                isOnWallBoolRight = true;
            }
            else
            {
                isOnWallBoolRight = false;
            }





            //_falseGround();
            position.X += movingThisFrame.X;
            position.Y += movingThisFrame.Y;




            hitbox = new Rectangle((int)position.X + 18, (int)position.Y, 27, 64);//30


            /////
            intersect = false;
            foreach (Wall platform in Game1.map.walls)
            {
                if (hitbox.isCollide1(platform.hitbox, movingThisFrame.X))
                {
                    intersect = true;
                }
            }
        }



        public void setCoords(int x, int y)
        {
            motion.Y = -1;
            this.position.X = x;
            this.position.Y = y;
            
        }



        private bool check()
        {
            return false;
        }




        private void movement()
        {
            keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.T) & !previousState.IsKeyDown(Keys.T))
            {

                if (Game1.map.currentMapID == 0)
                {
                    Game1.map.external_load(4);
                }
                else
                {
                    Game1.map.external_load(0);
                }

                
            }


            if (keyboardState.IsKeyDown(Keys.X) & !previousState.IsKeyDown(Keys.X))
            {

                foreach (var item in Game1.map.portals)
                {
                    if (this.hitbox.Intersects(item.hitbox))
                    {

                        item.Teleport(ref Game1.map, this);
                    }
                }
                


            }


            if (keyboardState.IsKeyDown(Keys.Escape) & !previousState.IsKeyDown(Keys.Escape))
            {

                Game1.setState();

            }




            if ( keyboardState.IsKeyDown(Keys.Q) & !previousState.IsKeyDown(Keys.Q) )
            {

                if (Game1.markSprite == true)
                {
                    Game1.markSprite = false;
                }
                else
                {
                    Game1.markSprite = true;
                }
            }

            if (keyboardState.IsKeyDown(Keys.R))
            {
                Game1.map.walls.Add(new Wall(new Vector2(50, 50), new Vector2(l * 50, 4 * 50), ContentManager.wallsArray[1]));
                l++;
            }

            if (HP > 0)
            {
                if (isOnGroundBool)
                {
                    jumpsdone = 0;
                }

                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    if (isOnGroundBool)
                    {
                        if (motion.X > -speedOfMove)
                        {
                            motion.X += -4;
                        }
                    }
                    else
                    {
                        if (motion.X > -speedOfMoveInAir)
                        {
                            motion.X += -1.5f;
                        }
                    }
                    direction = Direction.Left;
                }
                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    if (isOnGroundBool)
                    {
                        if (motion.X < speedOfMove)
                        {
                            motion.X += +4;
                        }
                    }
                    else
                    {
                        if (motion.X < speedOfMoveInAir)
                        {
                            motion.X += +1.5f;
                        }
                    }
                    direction = Direction.Right;
                }
                if (keyboardState.IsKeyDown(Keys.Z) & !previousState.IsKeyDown(Keys.Z))


                    if ((walljumpobtained && !isOnGroundBool && isOnWallBoolLeft) || (walljumpobtained && !isOnGroundBool && isOnWallBoolRight))
                    {
                        jumpsdone = 0;
                        if (isOnWallBoolLeft && lastWall != LastWallJump.Left)
                        {
                            motion.Y = -speedOfJump;
                            motion.X += 7;
                            lastWall = LastWallJump.Left;
                            direction = Direction.Right;
                        }
                        else if (isOnWallBoolRight && lastWall != LastWallJump.Right)
                        {
                            motion.Y = -speedOfJump;
                            motion.X -= 7;
                            lastWall = LastWallJump.Right;
                            direction = Direction.Left;
                        }
                    }
                    else if (jumpsdone < maxjumps || isOnGroundBool)
                    {
                        jumpsdone++;
                        if (jumpsdone == 1)
                        {
                            jumpsdone++;
                        }
                        motion.Y = -speedOfJump;
                    }
                    
                    

                    


            }
            previousState = Keyboard.GetState();
        }

        private void _falseGround()
        {
            if (position.Y > 400)
            {
                position.Y = 400;
                motion.Y = 0;
            }
        }        
    }
    
    static class RectangleHelper
    {

        public static bool isCollide(this Rectangle r1, Rectangle r2, float speedX)
        {
            float speedX1 = 0;
            float speedX2 = 0;
            if (speedX>0)
            {
                speedX2 = speedX;
                speedX1 = 0;
            }
            else
            {
                speedX1 = speedX;
                speedX2 = 0;
            }

            if (    r1.Left             <= r2.Right - speedX2 &&
                    r1.Right            >= r2.Left - speedX1 &&
                    r1.Bottom           >= r2.Top + 1       &&
                    r1.Top              <= r2.Bottom - 1    )
            {
                return true;
            }
            return false;
        }

        public static bool isCollide1(this Rectangle r1, Rectangle r2, float speedX)
        {
            float speedX1 = 0;
            float speedX2 = 0;

            
            r1.X += (int)speedX;
            


            if (r1.Intersects(r2))
            { 
                return true;
            }
            return false;
        }

        public static bool isCollideVerti(this Rectangle r1, Rectangle r2, float speedY)
        {
            
            if (r1.Bottom >= r2.Top - speedY &&
                r1.Top <= r2.Bottom - 5 &&
                r1.Right >= r2.Left   && 
                r1.Left <= r2.Right  ) 
            {
                return true;
            }
            return false;
        }

        public static bool isCollideVertiBottom(this Rectangle r1, Rectangle r2, float speedY)
        {

            if (r1.Bottom >= r2.Top - 5 &&
                r1.Top <= r2.Bottom + speedY &&
                r1.Right >= r2.Left &&
                r1.Left <= r2.Right)
            {
                return true;
            }
            return false;
        }



        public static bool isNearTopOf(this Rectangle r1, Rectangle r2, float speedY)
        {

            if (speedY > 0)
            {
                if(r1.Bottom >= r2.Top - speedY &&
                    r1.Bottom <= r2.Top + 0 &&
                    r1.Right >= r2.Left + 2 && //тут есичё было 5
                    r1.Left <= r2.Right - 2)
                {
                    return true;
                }

            }

            if (speedY < 0)
            {
                if (r1.Top >= r2.Bottom + speedY &&
                    r1.Top <= r2.Bottom + 0 &&
                    r1.Right >= r2.Left + 2 && //тут есичё было 5
                    r1.Left <= r2.Right - 2)
                {
                    return true;
                }

            }


            return false;

        }
        


        public static bool isNearSideOf(this Rectangle r1, Rectangle r2, float speedX)
        {
            if (speedX < 0)
            {
                if (r1.Left <= r2.Right - speedX &&
                    r1.Right >= r2.Left  &&
                    r1.Bottom >= r2.Top  &&
                    r1.Top <= r2.Bottom - 5)
                return true;
            }
            if (speedX > 0)
            {
                if (r1.Right >= r2.Left - speedX &&
                    r1.Left <= r2.Right  &&
                    r1.Bottom >= r2.Top  &&
                    r1.Top <= r2.Bottom - 5)
                    return true;
            }
            return false;
        }


        



    }
}
