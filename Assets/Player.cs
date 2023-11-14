using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
  public float velocity = 2.4f;
  private Rigidbody2D rigidbody;


  // public GameManager gameManager;
  public static bool isDead = false;


  void Start()
  {
    rigidbody = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      rigidbody.velocity = Vector2.up * velocity;
    }
  }


  private void OnCollisionEnter2D(Collision2D collision)
  {
    isDead = true;
    GameManager.GameOver();
  }

}
