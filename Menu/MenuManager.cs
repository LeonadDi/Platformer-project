using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGameProjectMG
{
    public class MenuManager
    {

        int selectedButton;
        KeyboardState keyboardState;
        KeyboardState previousState;
        public bool exit = false;

        public List<MenuButton> buttons = new List<MenuButton>();
        float buttonsYoffset = 440f;


        void setList()
        {
            buttons.Add(new MenuButton("Начать", new Vector2(30f, buttonsYoffset + 0)));
            buttons.Add(new MenuButton("Продолжить", new Vector2(30f, buttonsYoffset + 30f)));
            //buttons.Add(new MenuButton("О авторе", new Vector2(30f, buttonsYoffset + 60f)));
            buttons.Add(new MenuButton("Выйти", new Vector2(30f, buttonsYoffset + 90f)));
            selectedButton = 0;
        }


        public MenuManager()
        {
            setList();
        }




        public void _draw(SpriteBatch spriteBatch)
        {
            foreach (var item in buttons)
            {
                item._draw(spriteBatch, item.selected);
            }

        }


        public void _update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Enter) & !previousState.IsKeyDown(Keys.Enter))
            {
                if (selectedButton==0)
                {
                    Game1.createHero = true;
                    Game1.map.external_load(0);
                    Game1._state = Game1.GameState.Gameplay;
                    
                }

                if (selectedButton == 1)
                {
                    Game1._state = Game1.GameState.Gameplay;
                }

                if (selectedButton == 2)
                {
                    exit = true;
                }

            }

            if (keyboardState.IsKeyDown(Keys.Down) & !previousState.IsKeyDown(Keys.Down))
            {
                selectedButton += 1;
                if (selectedButton >= buttons.Count)
                {
                    selectedButton = 0;
                }

                
            }

            if (keyboardState.IsKeyDown(Keys.Up) & !previousState.IsKeyDown(Keys.Up))
            {
                selectedButton -= 1;
                if (selectedButton <= -1)
                {
                    selectedButton = buttons.Count-1;
                }

            }

            previousState = Keyboard.GetState();


            for (int i = 0; i < buttons.Count; i++)
            {
                if (i == selectedButton)
                {
                    buttons[i].selected = true;
                }
                else
                {
                    buttons[i].selected = false;
                }
            }
            
            foreach (var item in buttons)
            {
                //do something
            }
        }



    }
}
