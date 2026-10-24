using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace FLAPPY_BIRD
{   
    internal class Bird
    {
        public Texture2D[] textura { get; set; }
        public Rectangle rectangle;
        private SoundEffect AsaBatendo;
        TimeSpan Tempo = TimeSpan.Zero;

        private int PosY;
        private int PosX;
        private int Gravidade;
        private int Frame = 0;
        public Bird(Texture2D[] textura, SoundEffect Som)
        {
            this.textura = textura;
            rectangle = new (PosX,PosY,60  ,60);
            this.Gravidade = 5;
            this.AsaBatendo = Som;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            rectangle.Y = PosY;
            rectangle.X = PosX;
            spriteBatch.Draw(textura[Frame], rectangle, Color.White);
            Frame++;
            if(Frame == textura.Length - 1)
            {
                Frame = 0;
            }
        }
        public void Position(int x, int y)
        {
            PosX = x;
            PosY = y;
            rectangle.X = PosX;
            rectangle.Y = PosY;
        }
        public void Update(GameTime gameTime)
        {
                              
            KeyboardState teclado = Keyboard.GetState();

            if (teclado.IsKeyUp(Keys.Space))  Gravidade = 5;
            if (teclado.IsKeyDown(Keys.Space)) Gravidade = -5;
            PosY += Gravidade;

            Tempo += gameTime.ElapsedGameTime;
            if(Tempo >= TimeSpan.FromSeconds(0.5))
            {
                Tempo -= TimeSpan.FromSeconds(0.5);
                AsaBatendo.Play();
            }    
            

        }
        public bool ColisaoCeu()
        {
            if(PosY < 0) return true;
            else return false;
        }
        public bool ColisaoGround()
        {
            if (PosY >= 672) return true;
            else return false;
        }

        public bool ColisaoTuboUp (tuboUp Tubo)
        {
            if (rectangle.Intersects(Tubo.GetRectangle()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ColisaoTuboDown(tuboDown Tubo)
        {
            if (rectangle.Intersects(Tubo.GetRectangle()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
