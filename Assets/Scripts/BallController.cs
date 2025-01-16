using Unity.VisualScripting.InputSystem;
using UnityEngine;

public class BallController : MonoBehaviour
{
  public Rigidbody sphereRigidBody;
  public float ballSpeed = 2f;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    Vector2 inputVector = Vector2.zero;
    if (Input.GetKey(KeyCode.W))
    {
      inputVector += Vector2.up;
    }
    if (Input.GetKey(KeyCode.D))
    {
      inputVector += Vector2.right;
    }
    if (Input.GetKey(KeyCode.A))
    {
      inputVector += Vector2.left;
    }
    if (Input.GetKey(KeyCode.S))
    {
      inputVector += Vector2.down;
    }

    Vector3 inputXYZPlane = new Vector3(inputVector.x, 0, inputVector.y);
    sphereRigidBody.AddForce(inputXYZPlane * ballSpeed);
  }
}
