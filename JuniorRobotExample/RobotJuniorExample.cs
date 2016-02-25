using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode;
namespace JASC_JuniorRobotExample_1
{
    class RobotJuniorExample : JuniorRobot
    {

        public override void Run()
        {
            // -- Initialization of the robot --

            //colores (Tanque,cañon,radar,balas,scaner)
            SetColors(RED,ORANGE,RED,PURPLE,RED);
            

            while (true)
            {
                TurnRight(180);
                Ahead(100);
            }
        }

        #region funciones basicas

        // Ahead  --> se mueve adelante por pixeles
        // Back   --> se mueve atras en pixeles
        // TurnGunTo -->mueve el cañon a un angulo especifico
        // Fire  --> dispara con la potencia especificada
        // TurnTo --> mueve el tanque a un angulo especifico
        #endregion

        #region atributos basicos

        // Energy --> energia restante del tanque
        // Others --> total de enemigos
        // ScannedAngle --> angulo del ultimo tanque enemigo encontrado

        #endregion

        /*Funcion cuando golpean al robot*/
        public override void OnHitByBullet()
        {
            
        }

        /*Cuando el robot encuentra a un enemigo*/
        public override void OnScannedRobot()
        {
            TurnGunTo(ScannedAngle);
            Fire(10);
        }

        /*Cuando el robot golpea al enemigo*/
        public override void OnHitRobot()
        {
            
        }


        /*Cuando encuentra una muralla*/
        public override void OnHitWall()
        {

        }


    }
}
