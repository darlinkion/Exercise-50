using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private BoxCollider2D _boxCollider2D;
    private Rigidbody2D _rigidbody2D;
    private float _deltaX;
    private bool _isGrounded;

    public float DeltaX => _deltaX;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        _deltaX = Input.GetAxis("Horizontal") * _speed;

        CheckGround();

        Vector2 movement = new Vector2(_deltaX, _rigidbody2D.velocity.y);
        _rigidbody2D.velocity = movement;

        _rigidbody2D.gravityScale = _isGrounded && DeltaX == 0 ? 0 : 1;

        if ((Input.GetKeyDown(KeyCode.Space)) && _isGrounded)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void CheckGround()
    {
        Vector3 max = _boxCollider2D.bounds.max;
        Vector3 min = _boxCollider2D.bounds.min;

        Vector2 corner1 = new Vector2(max.x, min.y-.1f);
        Vector2 corner2 = new Vector2(min.x, min.y-.2f);

        Collider2D hit = Physics2D.OverlapArea(corner1, corner2);

        _isGrounded = false;

        if (hit != null)
        {
            _isGrounded = true;
        }
    }
}
