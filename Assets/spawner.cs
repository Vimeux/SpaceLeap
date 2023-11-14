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

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        float baguetteSpeed = (1 + Baguette.nombreDeBaguette * 0.2f);

        if (time > (queueTime / baguetteSpeed))
        {
            // Instancier l'avertissement
            GameObject warning = Instantiate(warningPrefab);
            warning.transform.position = transform.position + new Vector3((float)-0.4, Random.Range(-height, height), 0);
            Destroy(warning, 1f); // Détruire l'avertissement après une seconde

            // Utiliser Invoke pour retarder l'instanciation de l'obstacle
            Invoke(nameof(SpawnObstacle), 1f);
            
            time = 0;
        }
        time += Time.deltaTime;
    }

    void SpawnObstacle()
    {
        // Instancier l'obstacle après l'avertissement
        GameObject go = Instantiate(obstacle);
        go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(go, 10);
    }
}
