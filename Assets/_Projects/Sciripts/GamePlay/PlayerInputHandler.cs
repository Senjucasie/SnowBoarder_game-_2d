using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SnowBoarder.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerInputHandler : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed = 1;
        [SerializeField] private Rigidbody2D _rigidBoy2D;
        [SerializeField] private SurfaceEffector2D _surfaceEffector;
        [SerializeField] private float _boostSpeed;
        [SerializeField] private float _baseSpeed;
      

        void FixedUpdate()
        {
            BoostPlayer();
            RotatePlayer();
        }

        private void RotatePlayer()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                _rigidBoy2D.AddTorque(_rotationSpeed);
            else if (Input.GetKey(KeyCode.RightArrow))
                _rigidBoy2D.AddTorque(-_rotationSpeed);
        }

        private void BoostPlayer()
        {
            if(Input.GetKey(KeyCode.Space))
            {
                _surfaceEffector.speed = _boostSpeed;
            }
            else
            {
                _surfaceEffector.speed = _baseSpeed;
            }

        }
    }
}

