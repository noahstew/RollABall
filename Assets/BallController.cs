using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 4f;
    [SerializeField] private float jumpForce = 10f;

    public void moveBall(Vector3 input) { 
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.z);
        Vector3 inputYPlane = new Vector3(0, input.y, 0);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
        sphereRigidbody.AddForce(inputYPlane * jumpForce);
    }
}
