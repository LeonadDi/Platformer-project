using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _2dGameProjectMG
{
    public class Mech
    {
        public Vector2 position;
        public Vector2 motion;
        public Vector2 movingThisFrame;


        protected Texture2D texture;
        public Texture2D jump;
        public Texture2D fall;
        public Texture2D _dead;
        public Animation walk;


        public int HP;
        public Boolean dead = false;

        public Rectangle hitbox;
        protected Rectangle groundTest;
        protected float gravity;
        protected float speedOfMove;
        protected float speedOfMoveInAir;
        protected float speedOfJump;
        protected bool isOnGroundBool;
        protected bool isOnWallBoolLeft;
        protected bool isOnWallBoolRight;
        protected bool intersect;



        public enum State { Idle, Walk, Jump, Fall, Dead, Hide, Attack };
        public enum Direction { Left, Right};

        public State state;
        public Direction direction;

        public void Update(GameTime gametime)
        {

        }

        public struct CorrectionVector2
        {
            public DirectionX DirectionX;
            public DirectionY DirectionY;
            public float X;
            public float Y;
        }

        public enum DirectionX
        {
            Left = -1,
            None = 0,
            Right = 1
        }

        public enum DirectionY
        {
            Up = -1,
            None = 0,
            Down = 1
        }




        public void SetInStartPosition(int x, int y)
        {
            position.X = x;
            position.Y = y;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            position.X = (int)position.X;
            position.Y = (int)position.Y;


        
            
        //spriteBatch.Draw(texture, position, Color.White * 1f);

        //вправо 
        if (state == State.Idle && direction == Direction.Right)
        {
            spriteBatch.Draw(texture, position, new Rectangle(0, 0, 64, 64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
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
            spriteBatch.Draw(texture, position, new Rectangle(0,0,64,64), Color.White, 0f, new Vector2(0, 0), 1.0f, SpriteEffects.FlipHorizontally, 0);
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


        public void spikeCheck()
        {
            if (dead)
            {
                return;
            }
            if (motion.Y>0)
            {

                foreach (Spike item in Game1.map.spikes)
                {
                    if (hitbox.isCollideVerti(item.hitbox,motion.Y))
                    {
                        HP -= item.damage;
                        if (HP>0)
                        {
                            motion.Y = -8;
                            motion.X = 0;
                        }

                        if (HP==0)
                        {
                            dead = true;
                        }
                        break;
                    }

                }

            }
        }


        public void collision(Mech a, List<Wall> b)
        {

            CollisionStuff.IsCollingWith(b, a);


            //------


            List<CorrectionVector2> corrections = new List<CorrectionVector2>();
            foreach (Wall sprite in b)
            {
                if(sprite.hitbox.Intersects(a.hitbox))
                    corrections.Add(GetCorrectionVector(a, sprite));
            }

            

            //------





            //------


            int horizontalSum = CollisionStuff.SumHorizontal(corrections);
            int verticalSum = CollisionStuff.SumVertical(corrections);

            DirectionX directionX = DirectionX.None;
            DirectionY directionY = DirectionY.None;


            if (horizontalSum <= (int)DirectionX.Left)
                directionX = DirectionX.Left;
            else if (horizontalSum >= (int)DirectionX.Right)
                directionX = DirectionX.Right;
            else
                directionX = DirectionX.None; // if they cancel each other out, i.e 2 Left and 2 Right

            


            if (verticalSum <= (float)DirectionY.Up)
                directionY = DirectionY.Up;
            else if (verticalSum >= (float)DirectionY.Down)
                directionY = DirectionY.Down;
            else
                directionY = DirectionY.None; // if they cancel each other out, i.e 1 Up and 1 Down


            //------


            CorrectionVector2 smallestCorrectionY = getSmallestCorrectionY(directionY, corrections);
            CorrectionVector2 smallestCorrectionX = getSmallestCorrectionX(directionX, corrections);

            if (Math.Abs(verticalSum) > Math.Abs(horizontalSum)) // start with Y, if collision = then try X
            {
                correctCollision(a ,smallestCorrectionY, false);
                CreateBounds(a);
                if (CollisionStuff.IsCollingWith(b, a))
                    correctCollision(a, smallestCorrectionX, true);
                else
                    directionX = DirectionX.None;
            }
            else if (Math.Abs(horizontalSum) > Math.Abs(verticalSum)) // start with X, if collision = then try Y
            {
                correctCollision(a, smallestCorrectionX, true);
                CreateBounds(a);
                if (CollisionStuff.IsCollingWith(b, a))
                    correctCollision(a, smallestCorrectionY, false);
                else
                    directionY = DirectionY.None;
            }


            if (directionY == DirectionY.Down)
            {
                a.movingThisFrame.Y = 0;
                a.motion.Y = 0;
            }

            //CreateBounds(a);
            




        }

        private void CreateBounds(Mech a)
        {
            a.hitbox.X += (int)a.movingThisFrame.X;
            a.hitbox.Y += (int)a.movingThisFrame.Y;
        }

        private CorrectionVector2 getSmallestCorrectionX(DirectionX directionX, List<CorrectionVector2> corrections)
        {
            CorrectionVector2 smallest = new CorrectionVector2();
            smallest.X = int.MaxValue;

            foreach (CorrectionVector2 correction in corrections)
            {
                if (correction.DirectionX == directionX && correction.X < smallest.X)
                    smallest = correction;
            }

            return smallest;
        }

        private CorrectionVector2 getSmallestCorrectionY(DirectionY directionY, List<CorrectionVector2> corrections)
        {
            CorrectionVector2 smallest = new CorrectionVector2();
            smallest.Y = int.MaxValue;

            foreach (CorrectionVector2 correction in corrections)
            {
                if (correction.DirectionY == directionY && correction.Y < smallest.Y)
                    smallest = correction;
            }

            return smallest;
        }


        private void correctCollision(Mech a ,CorrectionVector2 correction, bool correctHorizontal)
        {
            if (correctHorizontal)  // horizontal
            {
                a.position.X += (int)correction.X * (int)correction.DirectionX;
                a.movingThisFrame.X = 0;
                a.motion.X = 0;
            }
            else // vertical
            {
                a.position.Y += (int)correction.Y * (int)correction.DirectionY;
                a.movingThisFrame.Y = 0;
                a.motion.Y = 0;
            }
        }



        public CorrectionVector2 GetCorrectionVector(Mech a, Wall target)
        {
            CorrectionVector2 ret = new CorrectionVector2();
            

            float x1 = Math.Abs(a.getHitbox().Right - target.hitbox.Left);
            float x2 = Math.Abs(a.getHitbox().Left - target.hitbox.Right);
            float y1 = Math.Abs(a.getHitbox().Bottom - target.hitbox.Top);
            float y2 = Math.Abs(a.getHitbox().Top - target.hitbox.Bottom);

            // calculate displacement along X-axis
            if (x1 < x2)
            {
                ret.X = x1;
                ret.DirectionX = DirectionX.Left;
            }
            else if (x1 > x2)
            {
                ret.X = x2;
                ret.DirectionX = DirectionX.Right;
            }

            // calculate displacement along Y-axis
            if (y1 < y2)
            {
                ret.Y = y1;
                ret.DirectionY = DirectionY.Up;
            }
            else if (y1 > y2)
            {
                ret.Y = y2;
                ret.DirectionY = DirectionY.Down;
            }

            return ret;
        }





        public bool isOnGround(Rectangle box, Rectangle wall)
        {
            box.Height += 10;
            

            if (box.Intersects(wall))
            {
                return true;
            }
            return false;
        }


        public bool isOnWallLeft(Rectangle box, Rectangle wall)
        {
            //box.Height += 10;

            box.Width += 10;
            box.X += 10;

            if (box.Intersects(wall))
            {
                return true;
            }
            return false;
        }

        public bool isOnWallRight(Rectangle box, Rectangle wall)
        {
            //box.Height += 10;

            box.Width += 10;
            box.X -= 10;

            if (box.Intersects(wall))
            {
                return true;
            }
            return false;
        }


        public Rectangle getHitbox()
        {
            return hitbox;
        }

    }
}
