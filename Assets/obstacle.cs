using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
  public float speed;
  // Update is called once per frame
  void Update()
  {
    float baguetteSpeed = (1 + Baguette.nombreDeBaguette * 0.2f);

    transform.position += ((Vector3.left * speed * baguetteSpeed) * Time.deltaTime);
  }
}
