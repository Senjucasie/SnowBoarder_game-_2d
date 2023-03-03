using GampePlay.Events;
using UnityEngine;


[RequireComponent(typeof(SurfaceEffector2D))]
public class SnowSurfaceHandler : MonoBehaviour
{
    private SurfaceEffector2D _surfaceEffector2D;

    private void Awake()
    {
        _surfaceEffector2D = GetComponent<SurfaceEffector2D>();
    }

    private void OnEnable()
    {
        GamePlayEventBroker.ChangePlayerSpeed += ChangeSpeed;
        GamePlayEventBroker.GameOver += StopSurfaceSpeed;
    }

  

    private void ChangeSpeed(float speed)
    {
        _surfaceEffector2D.speed = speed;
    }

    private void StopSurfaceSpeed() => _surfaceEffector2D.speed = 0;
   

    private void OnDisable()
    {
        GamePlayEventBroker.ChangePlayerSpeed -= ChangeSpeed;
        GamePlayEventBroker.GameOver -= StopSurfaceSpeed;
    }

}
