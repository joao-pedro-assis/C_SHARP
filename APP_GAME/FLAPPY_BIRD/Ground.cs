using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FLAPPY_BIRD
{
    internal class Ground
    {
        public Texture2D texture {get; set; }  
        public Rectangle rectangle;

        public Ground(Texture2D texture) { 
           this.texture = texture;
            rectangle = new(0, 736, 1024, 64);


        }
        public void Draw(GameTime gameTime,SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }

}
