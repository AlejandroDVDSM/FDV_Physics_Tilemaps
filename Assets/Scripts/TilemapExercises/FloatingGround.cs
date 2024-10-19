using UnityEngine;

public class FloatingGround : MonoBehaviour
{
    [SerializeField] private float _leftLimit;
    [SerializeField] private float _rightLimit;
    
    [SerializeField] private float _moveSpeed = 1.0f;
    
    private Rigidbody2D _rigidbody2D;
    private bool _isHeadingRight;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (transform.position.x < _leftLimit)
        {
            _rigidbody2D.MovePosition(transform.position + Vector3.right * (_moveSpeed * Time.fixedDeltaTime));
            _isHeadingRight = true;
        } else if (transform.position.x > _rightLimit)
        {
            _rigidbody2D.MovePosition(transform.position + Vector3.left * (_moveSpeed * Time.fixedDeltaTime));
            _isHeadingRight = false;
        } else if (transform.position.x > _leftLimit && transform.position.x < _rightLimit)
        {
            if (_isHeadingRight)
                _rigidbody2D.MovePosition(transform.position + Vector3.right * (_moveSpeed * Time.fixedDeltaTime));
            else
                _rigidbody2D.MovePosition(transform.position + Vector3.left * (_moveSpeed * Time.fixedDeltaTime));
        }
    }
}
