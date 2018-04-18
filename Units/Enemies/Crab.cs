using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class Crab : Enemy
    {
        Texture2D hide;
        Animation attack;



        public Crab(Vector2 position)
        {
            this.texture = ContentManager.crabidle;
            this.walk = ContentManager.crabwalk;
            this.jump = ContentManager.crabidle;
            this.fall = ContentManager.crabidle;
            this._dead = ContentManager.crabdead;
            this.hide = ContentManager.crabhide;
            this.attack = ContentManager.crabattack;
            this.HP = 6;
            //SetInStartPosition(0, 50 * 5);
            this.position = position;

            this.hitbox = new Rectangle(
                (int)position.X - 10,
                (int)position.Y,
                30,
                70);

            this.speedOfMove = 4.0f;
            this.speedOfJump = 4.0f; //10
            this.speedOfMoveInAir = 3.0f;
            this.gravity = 0.5f; //05
            this.isOnGroundBool = true;

            direction = Direction.Right;

        }

        public new void Draw(SpriteBatch spriteBatch)
        {
            position.X = (int)position.X;
            position.Y = (int)position.Y;




            //spriteBatch.Draw(texture, position, Color.White * 1f);

            //вправо 
            if (state == State.Idle && direction == Direction.Right)
            {
                spriteBatch.Draw(texture, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }
            if (state == State.Hide && direction == Direction.Right)
            {
                spriteBatch.Draw(hide, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }
            if (state == State.Attack && direction == Direction.Right)
            {
                spriteBatch.Draw(attack.getSprite(), position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }
            if (state == State.Walk && direction == Direction.Right)
            {

                spriteBatch.Draw(walk.getSprite(), position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);

            }
            if (state == State.Jump && direction == Direction.Right)
            {
                spriteBatch.Draw(jump, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }
            if (state == State.Fall && direction == Direction.Right)
            {
                spriteBatch.Draw(fall, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }
            if (state == State.Dead && direction == Direction.Right)
            {
                spriteBatch.Draw(_dead, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }

            //влево
            if (state == State.Idle && direction == Direction.Left)
            {
                spriteBatch.Draw(texture, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
            }
            if (state == State.Hide && direction == Direction.Left)
            {
                spriteBatch.Draw(hide, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
            }
            if (state == State.Attack && direction == Direction.Left)
            {
                spriteBatch.Draw(attack.getSprite(), position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
            }
            if (state == State.Walk && direction == Direction.Left)
            {
                spriteBatch.Draw(walk.getSprite(), position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
            }
            if (state == State.Jump && direction == Direction.Left)
            {
                spriteBatch.Draw(jump, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
            }
            if (state == State.Fall && direction == Direction.Left)
            {
                spriteBatch.Draw(fall, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
            }
            if (state == State.Dead && direction == Direction.Left)
            {
                spriteBatch.Draw(_dead, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
            }



        }


        public new void Update(GameTime gametime)
        {

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
            attack.update(gametime);

            movement();

            if (isOnGroundBool)
            {
                if (!dead)
                {

                    if ((Game1.Player1.position.X - position.X) >= 250 || (position.X - Game1.Player1.position.X) >= 250)
                    {
                        state = State.Hide;                        
                    }
                    else if (  Game1.Player1.position.X - position.X <= 60 && position.X  - Game1.Player1.position.X <= 60)
                    {
                        if (Game1.Player1.position.Y - position.Y <= 0 && position.Y - Game1.Player1.position.Y <= 33)
                        {


                            if (!Game1.Player1.dead)
                            {

                                state = State.Attack;
                                Game1.Player1.HP -= 1;
                                if (direction == Direction.Right)
                                {
                                    Game1.Player1.motion.X = 6;
                                    Game1.Player1.motion.Y = -5;
                                }
                                else
                                {
                                    Game1.Player1.motion.X = -6;
                                    Game1.Player1.motion.Y = -5;
                                }

                            }
                        }
                    }
                    else if (motion.X == 0)
                    {
                        state = State.Idle;
                    }
                    else
                    {
                        state = State.Attack;
                        //state = State.Walk;
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



            bool found = false;
            foreach (Wall platform in Game1.map.walls)
            {
                if (isOnGround(hitbox, platform.hitbox))
                {
                    found = true;
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

        private void movement()
        {
            if (HP > 0)
            {
                if (isOnGroundBool == true)
                {

                }

                if (position.X > Game1.Player1.position.X && (position.X - Game1.Player1.position.X) < 250 )
                {
                    if (isOnGroundBool)
                    {
                        if (motion.X > -speedOfMove)
                        {
                            motion.X += -2;
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
                if (position.X < Game1.Player1.position.X && (Game1.Player1.position.X - position.X ) < 250)
                {
                    if (isOnGroundBool)
                    {
                        if (motion.X < speedOfMove)
                        {
                            motion.X += +2;
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

                

            }
        }


    }

}
