using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 4f;

    public void moveBall(Vector3 input) { 
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.z);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
