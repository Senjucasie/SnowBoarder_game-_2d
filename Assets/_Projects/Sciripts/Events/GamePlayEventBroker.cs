using System;
namespace GampePlay.Events
{
    public class GamePlayEventBroker
    {
        
        public static event Action GameOver;
        public static event Action GameFinished;
        public static event Action<float> ChangePlayerSpeed;
       

        public static void CallGameOver() => GameOver?.Invoke();
        public static void CallGameFinished() => GameFinished?.Invoke();
        public static void CallChangePlayerSpeed(float speed) => ChangePlayerSpeed?.Invoke(speed);
       

    }

}

