using System;
using UnityEngine;

namespace Brackeys2022.Scripts.Player
{
    public enum PlayerType
    {
        WASD, Arrows
    }
    
    [RequireComponent(typeof(CharacterMovement))]
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField]
        private PlayerType _playerType;
        
        private CharacterMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<CharacterMovement>();
        }
        
        private void Update()
        {
            const string aKey = "a";
            const string dKey = "d";
            const string wKey = "w";
            const string sKey = "s";
            const string upKey = "up";
            const string downKey = "down";
            const string leftKey = "left";
            const string rightKey = "right";
            
            float horizontal;
            float vertical;
            if (_playerType == PlayerType.WASD)
            {
                horizontal = Input.GetKey(aKey) ? -1 : Input.GetKey(dKey) ? 1 : 0;
                vertical = Input.GetKey(wKey) ? 1 : Input.GetKey(sKey) ? -1 : 0;
            }
            else
            {
                horizontal = Input.GetKey(leftKey) ? -1 : Input.GetKey(rightKey) ? 1 : 0;
                vertical = Input.GetKey(upKey) ? 1 : Input.GetKey(downKey) ? -1 : 0;
            }
            
            _movement.Move(horizontal, vertical);
        }
    }
}