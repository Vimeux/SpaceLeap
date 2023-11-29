using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
  public float queueTime = 1.5f;
  private float time = 0;
  public GameObject obstacle;
  public GameObject warningPrefab; // Ajout du préfab d'avertissement
  public float height;
  private float heightVariable;

  void Start()
  {
    Time.timeScale = 0;
  }

  void Update()
  {
    float baguetteSpeed = (1 + Baguette.nombreDeBaguette * 0.2f);
    heightVariable = Random.Range(-height, height);

    if (time > (queueTime / baguetteSpeed))
    {
      if (warningPrefab != null) // Vérifier si le préfab est null
      {
        // Instancier l'avertissement
        GameObject warning = Instantiate(warningPrefab);
        warning.transform.position = transform.position + new Vector3((float)-0.4, heightVariable, 0);
        Destroy(warning, 1f); // Détruire l'avertissement après une seconde
      }

      // Utiliser Invoke pour retarder l'instanciation de l'obstacle
      GameObject go = Instantiate(obstacle);
      go.transform.position = transform.position + new Vector3(0, heightVariable, 0);
      Destroy(go, 10);

      time = 0;
    }
    time += Time.deltaTime;
  }
}
