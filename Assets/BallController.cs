using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody; // Ball Rigidbody
    [SerializeField] private float ballSpeed = 4f; // Movement speed
    [SerializeField] private float jumpForce = 10f; // Jump force
    private bool isGrounded = false; // Grounded state

    // Detect collision when landing
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3) // Detects if ground (layer 3) is touched
        {
            isGrounded = true;
        }
    }

    // Detect collision when leaping
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 3) // Detects if ground (layer 3) is touched
        {
            isGrounded = false;
        }
    }

    // Move the ball
    public void moveBall(Vector3 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.z); // Vector 3 representation of input
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed); // Moving ball

        if (input.y > 0 && isGrounded) // Jump check
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Instant velocity change in Y direction
        }
    }
}
