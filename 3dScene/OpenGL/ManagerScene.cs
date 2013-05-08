using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenGL.Object;
using OpenGL.Move;
using Tao.OpenGl;
using System.Drawing;
using System.Drawing.Imaging;
using System.Timers;

namespace OpenGL
{
    class ManagerScene
    {
        const double TIMER_INTERVAL = 50;
        const int NUMBER_OF_TEXTURE = 3;

        private Timer timer;
        private bool goComposition = true;

        private bool goCompositionObjects = true;
        private bool goCompositionLights = true;

        double angleScene;

        private int[] texture = new int[ManagerScene.NUMBER_OF_TEXTURE];

        //размеры сцены
        private const float WIDTH_SCENE = 2;
        private const float HEIGHT_SCENE = 2;

        private const int MAX_COUNT_LIGHT = 10;
        private Light[] light = new Light[ManagerScene.MAX_COUNT_LIGHT];

        private Cube movedCube;
        private float sizeMovedCube = 0.5f;

        private Ball jampedBall;
        private float radiusJampedBall = 0.25f;

        private Flat floor;
        private float sizeFloor = ManagerScene.WIDTH_SCENE;

        private Flat ceiling;
        private float sizeCeiling = ManagerScene.WIDTH_SCENE;

        private Ball nearBall;
        private Ball farBall;
        private float radiusPairBall = 0.125f;
        private const int TOGGLE_PERIUD_FAR = 3;
        private int waitToggleFar = ManagerScene.TOGGLE_PERIUD_FAR;
        private const int TOGGLE_PERIUD_NEAR = 9;
        private int waitToggleNear = ManagerScene.TOGGLE_PERIUD_NEAR;


        private Cylinder columnDownLeft;
        private Cylinder columnDownRight;
        private Cylinder columnUpLeft;
        private Cylinder columnUpRight;
        private float radiusColumn = 0.1f;
        private float heightColumn = ManagerScene.HEIGHT_SCENE;

        private ManagerMoves managerMoves;

        private MainForm form;

        public ManagerScene(MainForm mainForm)
        {
            this.managerMoves = new ManagerMoves();
            this.form = mainForm;
            this.timer = new Timer(ManagerScene.TIMER_INTERVAL);
            this.timer.Elapsed += new ElapsedEventHandler(this.tick);
            this.init();
            this.settingObjects();
            this.settingLight();

            this.timer.Start();
        }

        private void settingObjects()
        {
            Point3D startMovedCube = new Point3D((this.sizeMovedCube - ManagerScene.WIDTH_SCENE) / 2, (this.sizeMovedCube - ManagerScene.HEIGHT_SCENE) / 2, 0.0f);
            this.movedCube = new Cube(startMovedCube, this.texture[0], this.sizeMovedCube);
            this.managerMoves.oscillatoryMove(this.movedCube, new Point3D((-this.sizeMovedCube + ManagerScene.WIDTH_SCENE) / 2, (this.sizeMovedCube - ManagerScene.HEIGHT_SCENE) / 2, 0), 10);

            Point3D startJampedBall = new Point3D(0, this.radiusJampedBall-ManagerScene.HEIGHT_SCENE/2, 0);
            this.jampedBall = new Ball(startJampedBall, this.texture[1], this.radiusJampedBall);
            this.managerMoves.oscillatoryMove(this.jampedBall, new Point3D(0, -this.radiusJampedBall + ManagerScene.HEIGHT_SCENE / 2, 0), 20); 

            Point3D startFloor = new Point3D(0, -ManagerScene.HEIGHT_SCENE / 2, 0);
            this.floor = new Flat(startFloor, this.texture[1], this.sizeFloor);
            this.managerMoves.rotate(this.floor, new Point3D(0, 1, 0), 9000, 360, 3);

            Point3D startCeiling = new Point3D(0, ManagerScene.HEIGHT_SCENE / 2, 0);
            this.ceiling = new Flat(startCeiling, this.texture[1], this.sizeCeiling);
            this.managerMoves.rotate(this.ceiling, new Point3D(0, -1, 0), 9000, 360, 3);

            Point3D startColumnDownLeft = new Point3D(this.radiusColumn - ManagerScene.WIDTH_SCENE / 2, -ManagerScene.HEIGHT_SCENE / 2, - this.radiusColumn + ManagerScene.WIDTH_SCENE / 2);
            this.columnDownLeft = new Cylinder(startColumnDownLeft, this.texture[2], this.radiusColumn, this.radiusColumn, this.heightColumn);
            Point3D startColumnDownRight = new Point3D(-this.radiusColumn + ManagerScene.WIDTH_SCENE / 2, -ManagerScene.HEIGHT_SCENE / 2, -this.radiusColumn + ManagerScene.WIDTH_SCENE / 2);
            this.columnDownRight = new Cylinder(startColumnDownRight, this.texture[2], this.radiusColumn, this.radiusColumn, this.heightColumn);
            Point3D startColumnUpLeft = new Point3D(this.radiusColumn - ManagerScene.WIDTH_SCENE / 2, -ManagerScene.HEIGHT_SCENE / 2, this.radiusColumn - ManagerScene.WIDTH_SCENE / 2);
            this.columnUpLeft = new Cylinder(startColumnUpLeft, this.texture[2], this.radiusColumn, this.radiusColumn, this.heightColumn);
            Point3D startColumnUpRight = new Point3D(-this.radiusColumn + ManagerScene.WIDTH_SCENE / 2, -ManagerScene.HEIGHT_SCENE / 2, this.radiusColumn - ManagerScene.WIDTH_SCENE / 2);
            this.columnUpRight = new Cylinder(startColumnUpRight, this.texture[2], this.radiusColumn, this.radiusColumn, this.heightColumn);

            Point3D startNearBall = new Point3D(0, this.radiusPairBall - ManagerScene.HEIGHT_SCENE / 2, - this.radiusPairBall + ManagerScene.WIDTH_SCENE / 2);
            this.nearBall = new Ball(startNearBall, this.texture[0], this.radiusPairBall);
            Point3D startFarBall = new Point3D(0, this.radiusPairBall - ManagerScene.HEIGHT_SCENE / 2, this.radiusPairBall - ManagerScene.WIDTH_SCENE / 2);
            this.farBall = new Ball(startFarBall, this.texture[0], this.radiusPairBall);
            this.farBall.toggleVisible();

            this.goCompositionObjects = false;

            
        }

        private void settingLight()
        {
            Point3D start;
            Point3D ambient;
            Point3D diffuse;
            Point3D specular;
            float spotExponent;
            float spotCutoff;
            Object3D covering;
            float x = 0, y =0, z = 0;

            ambient = new Point3D(0.2f, 0.2f, 0.2f);
            diffuse = new Point3D(0.4f, 0.3f, 0.3f);
            specular = new Point3D(0.8f, 0.8f, 0.8f);
            spotExponent = 0;
            spotCutoff = 15;
            y = -ManagerScene.HEIGHT_SCENE / 2;

            for (int i = 0; i < 4; ++i)
            {
                switch (i % 4)
                {
                    case 0:
                        x = -ManagerScene.WIDTH_SCENE / 2;
                        z = ManagerScene.WIDTH_SCENE / 2;
                        break;
                    case 1:
                        x = -ManagerScene.WIDTH_SCENE / 2;
                        z = -ManagerScene.WIDTH_SCENE / 2;
                        break;
                    case 2:
                        x = ManagerScene.WIDTH_SCENE / 2;
                        z = -ManagerScene.WIDTH_SCENE / 2;
                        break;
                    case 3:
                        x = ManagerScene.WIDTH_SCENE / 2;
                        z = ManagerScene.WIDTH_SCENE / 2;
                        break;
                }
                start = new Point3D(x, y, z);
                covering = new Ball(start, 0, 0.01f, new Point3D(1, 1, 1));
                this.light[i] = new Light(Gl.GL_LIGHT0 + i, ambient, diffuse, specular, spotExponent, spotCutoff, covering);
            }

            float heightLamp = 0.05f;
            float radiusLamp = 0.1f;

            ambient = new Point3D(0.2f, 0.2f, 0.2f);
            diffuse = new Point3D(0.4f, 0.3f, 0.3f);
            specular = new Point3D(0.8f, 0.8f, 0.8f);
            spotExponent = 0;
            spotCutoff = 16;
            x = ManagerScene.WIDTH_SCENE / 5;
            y = ManagerScene.HEIGHT_SCENE / 2 - heightLamp;
            z = 0;
            start = new Point3D(x, y, z);
            covering = new Cylinder(start, 1, radiusLamp, radiusLamp, heightLamp, new Point3D(1, 1, 1));
            this.light[9] = new Light(Gl.GL_LIGHT4, ambient, diffuse, specular, spotExponent, spotCutoff, covering);
            this.managerMoves.circleWise(this.light[9], x, true, 1000);

            ambient = new Point3D(0.2f, 0.2f, 0.2f);
            diffuse = new Point3D(0.4f, 0.3f, 0.3f);
            specular = new Point3D(0.8f, 0.8f, 0.8f);
            spotExponent = 0;
            spotCutoff = 20;
            x = -ManagerScene.WIDTH_SCENE / 3;
            y = ManagerScene.HEIGHT_SCENE / 2 - heightLamp;
            z = 0;
            start = new Point3D(x, y, z);
            covering = new Cylinder(start, 1, radiusLamp, radiusLamp, heightLamp, new Point3D(1, 1, 1));
            this.light[8] = new Light(Gl.GL_LIGHT5, ambient, diffuse, specular, spotExponent, spotCutoff, covering);
            this.managerMoves.circleWise(this.light[8], x, false, 1200);

            this.goCompositionLights = false;
        }

        private void init()
        {
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glShadeModel(Gl.GL_SMOOTH);

            Gl.glEnable(Gl.GL_DEPTH_TEST);

            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT,
                      Gl.GL_NICEST);

            Gl.glEnable(Gl.GL_TEXTURE_2D);

            this.loadGLTextures();
        }

        public void draw()
        {
            if (!this.goComposition)
            {
               //System.Threading.Thread.Sleep(500);
                Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
                Gl.glLoadIdentity();

                Gl.glPushMatrix();
                Gl.glTranslated(0.0, 0, -4);
                //Gl.glTranslated(0.0, -0.5, -6.0);
                Gl.glRotated(angleScene, 0.0, 1.0, 0.0);

                this.movedCube.draw();
                this.jampedBall.draw();
                this.floor.draw();
                this.ceiling.draw();

                this.columnDownLeft.draw();
                this.columnDownRight.draw();
                this.columnUpLeft.draw();
                this.columnUpRight.draw();

                this.nearBall.draw();
                this.farBall.draw();

                for (int i = 0; i < ManagerScene.MAX_COUNT_LIGHT; ++i)
                    if (this.light[i] != null)
                        this.light[i].draw();

                Gl.glPopMatrix();

                Gl.glFlush();

                this.form.clearScene();
            }


        }

        private void tick(object sender, EventArgs eventCall)
        {
            if (this.goComposition)
                if (!this.goCompositionObjects || !this.goCompositionLights)
                    this.goComposition = false;

            this.angleScene += 0.5;
            //this.draw();
            this.toggleVisibleBall();
            this.form.clearScene();//очистка сценыы
        }

        private void toggleVisibleBall()
        {
            if (this.waitToggleNear == 0 && !this.goComposition)
            {
                this.nearBall.toggleVisible();
                this.waitToggleNear = ManagerScene.TOGGLE_PERIUD_NEAR;
            }
            else
                --this.waitToggleNear;

            if (this.waitToggleFar == 0 && !this.goComposition)
            {
                this.farBall.toggleVisible();
                this.waitToggleFar = ManagerScene.TOGGLE_PERIUD_FAR;
            }
            else
                --this.waitToggleFar;
        }

        private bool loadGLTextures()
        {
            bool status = false;                                                // Status Indicator
            Bitmap[] textureImage = new Bitmap[ManagerScene.NUMBER_OF_TEXTURE];                              // Create Storage Space For The Texture

            textureImage[0] = OpenGL.Properties.Resources.Tile___3;// Load The Bitmap
            textureImage[1] = OpenGL.Properties.Resources.rainbow;
            textureImage[2] = OpenGL.Properties.Resources.marble;
            //textureImage[0] = new Bitmap("Tile - 3.png");// Load The Bitmap
            //textureImage[1] = new Bitmap("rainbow.bmp");
            Gl.glGenTextures(ManagerScene.NUMBER_OF_TEXTURE, this.texture);
            // Check For Errors, If Bitmap's Not Found, Quit
            for (int i = 0; i < textureImage.Length; ++i)
            {
                if (textureImage[i] != null)
                {
                    status = true;                                                  // Set The Status To True

                   // Gl.glGenTextures(2, this.texture);                            // Create The Texture

                    textureImage[i].RotateFlip(RotateFlipType.RotateNoneFlipY);     // Flip The Bitmap Along The Y-Axis
                    // Rectangle For Locking The Bitmap In Memory
                    Rectangle rectangle = new Rectangle(0, 0, textureImage[i].Width, textureImage[i].Height);
                    // Get The Bitmap's Pixel Data From The Locked Bitmap
                    BitmapData bitmapData = textureImage[i].LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                    // Typical Texture Generation Using Data From The Bitmap
                    Gl.glBindTexture(Gl.GL_TEXTURE_2D, this.texture[i]);
                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB8, textureImage[i].Width, textureImage[i].Height, 0, Gl.GL_BGR, Gl.GL_UNSIGNED_BYTE, bitmapData.Scan0);
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
                    Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);

                    if (textureImage[i] != null)
                    {                                   // If Texture Exists
                        textureImage[i].UnlockBits(bitmapData);                     // Unlock The Pixel Data From Memory
                        textureImage[i].Dispose();                                  // Dispose The Bitmap
                    }
                }

            }

            return status;                                                      // Return The Status
        }
    }
}
