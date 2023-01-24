using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class LeftRightMovement : MonoBehaviour {
    private const string HorizontalInputAxisString = "Horizontal";

    private Rigidbody2D _rigidbody2D;
    [SerializeField] private float speed;

    private void Start() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float horizontalInput = Input.GetAxis(HorizontalInputAxisString);
        Vector2 movementDirection = Vector2.right * horizontalInput;
        _rigidbody2D.AddForce(movementDirection * (speed * Time.deltaTime)); // Reordered for performance
    }
}
