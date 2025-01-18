using System;
using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
  [SerializeField] private Rigidbody sphereRigidbody;
  [SerializeField] private float ballSpeed = 2f;
  [SerializeField] private float jumpHeight = 2f;
  private bool ballOnGround = true;

  public void MoveBall(Vector2 input)
  {
    Vector3 inputXYZPlane = new(input.x, 0, input.y);
    sphereRigidbody.AddForce(inputXYZPlane * ballSpeed);
  }

  public void Jump(bool jump)
  {
    if (jump & ballOnGround)
    {
      sphereRigidbody.AddForce(new Vector3(0, jumpHeight, 0));
    }
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.name == "Plane")
    {
      ballOnGround = true;
      Debug.Log("Entered collision with " + collision.gameObject.name);
    }
  }

  void OnCollisionExit(Collision collision)
  {
    if (collision.gameObject.name == "Plane")
    {
      ballOnGround = false;
      Debug.Log("Exited collision with " + collision.gameObject.name);
    }
  }
}
