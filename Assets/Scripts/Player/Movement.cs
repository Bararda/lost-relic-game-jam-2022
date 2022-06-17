using UnityEngine;

namespace Player
{
    public class Movement : MonoBehaviour
    {
        public Rigidbody2D rigidbody2d;
        public float speed = 100f;
        public float maxSpeed = 50f;
        private Animator _animator;
        private static readonly int IsHoldingDownKey = Animator.StringToHash("isHoldingDownKey");
        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void FixedUpdate()
        {
            HandleMovement();
        }

        private void HandleMovement()
        {
            if (Input.GetKey(KeyCode.A))
            {
                // multiply be mass so that the movement is not affected by the mass of the object
                rigidbody2d.AddForce(-transform.right * (speed * rigidbody2d.mass), ForceMode2D.Force);
                rigidbody2d.velocity = new Vector2(Mathf.Clamp(rigidbody2d.velocity.x, -maxSpeed, 0f), rigidbody2d.velocity.y);
                _animator.SetBool(IsHoldingDownKey, true);
                _spriteRenderer.flipX = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rigidbody2d.AddForce(transform.right * (speed * rigidbody2d.mass), ForceMode2D.Force);
                rigidbody2d.velocity = new Vector2(Mathf.Clamp(rigidbody2d.velocity.x, 0f, maxSpeed), rigidbody2d.velocity.y);
                _animator.SetBool(IsHoldingDownKey, true);
                _spriteRenderer.flipX = false;
            }
            else
            {
                _animator.SetBool(IsHoldingDownKey, false);
            }

        }
    }
}
