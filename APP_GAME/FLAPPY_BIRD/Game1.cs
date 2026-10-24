using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Runtime.Serialization.Formatters;

namespace FLAPPY_BIRD
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Bird Passaro;
        private Ground Ground;
        private tuboUp[] TubosUp;
        private tuboDown[] TubosDown;

        private int Score = 0;
        private SpriteFont Fonte;
        private bool IsPaused = false;
        private Texture2D telaGameOver;
        private Song Musica;
        private Texture2D Background;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this) 
            { 
            PreferredBackBufferWidth = 1024,
            PreferredBackBufferHeight = 800,
            };
            _graphics.ApplyChanges();
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.Window.Title = "FLAPPY BIRD";

            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D[] TexturaPassaro = new Texture2D[]
            {
                Content.Load<Texture2D>("flappy_animated/frame1"),
                Content.Load<Texture2D>("flappy_animated/frame2"),
                Content.Load<Texture2D>("flappy_animated/frame3"),
                Content.Load<Texture2D>("flappy_animated/frame4"),
                Content.Load<Texture2D>("flappy_animated/frame5"),
                Content.Load<Texture2D>("flappy_animated/frame6"),
                Content.Load<Texture2D>("flappy_animated/frame7"),
                Content.Load<Texture2D>("flappy_animated/frame8"),
                Content.Load<Texture2D>("flappy_animated/frame9"),
                Content.Load<Texture2D>("flappy_animated/frame10"),
                Content.Load<Texture2D>("flappy_animated/frame11"),
                Content.Load<Texture2D>("flappy_animated/frame12"),
                Content.Load<Texture2D>("flappy_animated/frame13"),
                Content.Load<Texture2D>("flappy_animated/frame14"),
                Content.Load<Texture2D>("flappy_animated/frame15"),
                Content.Load<Texture2D>("flappy_animated/frame16")
            };

            Passaro = new Bird(TexturaPassaro,
              Content.Load<SoundEffect>("asabatendo")
              );
            Passaro.Position(300, 300);
            telaGameOver = Content.Load<Texture2D>("gameOver");
            Musica = Content.Load<Song>("musica");
            MediaPlayer.Play(Musica);
            MediaPlayer.IsRepeating = true; 
            Ground = new Ground(Content.Load<Texture2D>("ground"));
            TubosDown = new tuboDown[6];
            TubosUp = new tuboUp[6];
            for (int i = 0; i < TubosUp.Length; i++)
            {
                TubosUp[i] = new tuboUp((Content.Load<Texture2D>("pipeup")));
                Random random = new Random();
                TubosUp[i].Position(1200 + random.Next(1,5) * 1,608);
            }
            for (int i = 0; i < TubosDown.Length; i++)
            {
                TubosDown[i] = new tuboDown((Content.Load<Texture2D>("pipedown")));
                Random random = new Random();
                 
                TubosDown[i].Position(1200 + random.Next(1, 5) * 1, 0);
            }
            Fonte = Content.Load<SpriteFont>("fonte");
            Background = Content.Load<Texture2D>("background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                IsPaused = false;
                Score = 0;
                LoadContent(); 
            }
            if (!IsPaused) 
            {

                LogicaJogo(gameTime);

            }
            if (Passaro.ColisaoCeu() || Passaro.ColisaoGround())
            {
                IsPaused = true;
            }
            base.Update(gameTime);
        }
        private void LogicaJogo(GameTime gameTime)
        {
         for (int i = 0;i < TubosUp.Length; i++)
            {
                TubosUp[i].Mover(ref Score);
                if (Passaro.ColisaoTuboUp(TubosUp[i])) IsPaused = true;   
            }
            
         for (int i = 0; i < TubosDown.Length; i++)
            {

                TubosDown[i].Mover(ref Score);
                if (Passaro.ColisaoTuboDown(TubosDown[i])) IsPaused = true;
            }
            Passaro.Update(gameTime);
        }  

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(Background,new Rectangle(0,0,1200,800),Color.White);
            DesenhaJogo(gameTime);
            _spriteBatch.End();
            base.Draw(gameTime);
            
        }

        private void DesenhaJogo(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);
            Ground.Draw(gameTime, _spriteBatch);
            Passaro.Draw(gameTime, _spriteBatch);

            for (int i = 0; i < TubosUp.Length; i++)
            {
                TubosUp[i].Draw(gameTime, _spriteBatch);
            }
            for (int i = 0; i < TubosDown.Length; i++)
            {
                TubosDown[i].Draw(gameTime, _spriteBatch);
            }
            DesenharPlacar(gameTime, _spriteBatch);
            if (IsPaused)
            {
                GameOver(gameTime,_spriteBatch);
            }
        }

        private void GameOver(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(telaGameOver, new Rectangle(200, 200, 800, 400), Color.White);
            spriteBatch.DrawString(Fonte, "Pressione enter para novo jogo",new Vector2(300,600),Color.Black);
        }

        private void DesenharPlacar(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Fonte,"PLACAR = " + Score.ToString().PadLeft(5,'0'),
                new Vector2(760,760),Color.Red);
        }
    }
}
