using System;
using UnityEngine;

namespace Brackeys2022.Scripts.Player
{
    [RequireComponent(typeof(CharacterMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private CharacterMovement _movement;

        private void Awake()
        {
            _movement = GetComponent<CharacterMovement>();
        }
        
        private void Update()
        {
            _movement.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}