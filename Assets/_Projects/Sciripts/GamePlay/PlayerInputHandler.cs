using GampePlay.Events;
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
        [SerializeField] private float _boostSpeed;
        [SerializeField] private float _baseSpeed;

        private bool GameOver=false;

        private void OnEnable()
        {
            GamePlayEventBroker.GameOver += stopUpdate;
        }

        private void stopUpdate()
        {
            GameOver = true;
        }

        void FixedUpdate()
        {
            if (GameOver)
                return;

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
                GamePlayEventBroker.CallChangePlayerSpeed(_boostSpeed);
            }
            else
            {
                GamePlayEventBroker.CallChangePlayerSpeed(_baseSpeed);
            }
        }

        private void OnDisable()
        {
            GamePlayEventBroker.GameOver -= stopUpdate;
        }
    }
}

