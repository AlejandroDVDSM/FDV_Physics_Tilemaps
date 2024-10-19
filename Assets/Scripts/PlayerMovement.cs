using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10.0f;
    
    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector3 _direction;

    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody2D;
    
    private static readonly int IsWalking = Animator.StringToHash("isWalking");

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");

        if (_horizontalMovement != 0)
        {
            _animator.SetBool(IsWalking, true);
            _spriteRenderer.flipX = _horizontalMovement > 0;
            
            _direction = new Vector3(_horizontalMovement, 0, 0).normalized;
        }
        else
        {
            _animator.SetBool(IsWalking, false);
        }
    }

    private void FixedUpdate()
    {
        if (_horizontalMovement != 0)
        {
            _rigidbody2D.MovePosition(transform.position + _direction * (_moveSpeed * Time.fixedDeltaTime));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log($"<{gameObject.name}> has collided with <{other.gameObject.name}>");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"<{gameObject.name}> triggered");
    }
}