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

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                _rigidBoy2D.AddTorque(_rotationSpeed);
            else if (Input.GetKey(KeyCode.RightArrow))
                _rigidBoy2D.AddTorque(-_rotationSpeed);
        }
    }
}

