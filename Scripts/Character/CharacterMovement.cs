using UnityEngine;

namespace Brackeys2022.Scripts.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField]
        private float speed = 5.0f;

        private Vector2 _direction;
        public Vector2 Direction
        {
            get => _direction;
            private set
            {
                value.Normalize();
            
                // ReSharper disable once RedundantCheckBeforeAssignment
                if (_direction == value) return;
            
            
                _direction = value;
            }
        }
        private Rigidbody2D rb;

        public void Move(Vector2 dir) => Direction = dir;
        public void Move(float x, float y) => Move(new Vector2(x, y));

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            UpdateVelocity();
        }

        private void UpdateVelocity()
        {
            rb.velocity = Direction * speed;
        }
    }   
}
