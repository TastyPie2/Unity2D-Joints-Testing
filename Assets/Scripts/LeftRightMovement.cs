using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class LeftRightMovement : MonoBehaviour {
    private const string HorizontalInputAxisString = "Horizontal";

    private Rigidbody2D _rigidbody2D;
    [SerializeField] private float speed;

    public float jumpForce;

    private void Start() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float horizontalInput = Input.GetAxis(HorizontalInputAxisString);
        Vector2 movementDirection = Vector2.right * horizontalInput;
        _rigidbody2D.AddForce(movementDirection * (speed * Time.deltaTime), ForceMode2D.Impulse); // Reordered for performance

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    private void Jump()
    {
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
    }

}