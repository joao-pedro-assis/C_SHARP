using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FLAPPY_BIRD
{
    public class tuboUp
    {
        public Texture2D textura { get; set; }
        public Rectangle rectangle;

        private int PosY;
        private int PosX;
        private int velocidade = 5;
        public tuboUp(Texture2D textura)
        
        {
            this.textura = textura;
            rectangle = new(PosX, PosY, 64, 128);
        }
        public void Position(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            rectangle.Y = PosY;
            rectangle.X = PosX;
            spriteBatch.Draw(textura, rectangle, Color.White);
            
        }
        public void Mover(ref int Score)
        {
            if(PosX < -64)
            {
                Random Pos = new ();
                PosX += Pos.Next(1008, 1600);
                int Altura = Pos.Next(64,336);
                rectangle.Height = Altura;
                PosY = 736 - Altura;  
                velocidade = Pos.Next(5,10);
                Score++;
            }
            PosX -= velocidade;

        }

        public Rectangle GetRectangle()
        {
            return rectangle;
        }

        
    }
}
