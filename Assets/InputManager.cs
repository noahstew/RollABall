using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{

    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();

    void Update()
    {
        Vector3 inputVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector3.right;
        }

        OnMove?.Invoke(inputVector);
    }
}
