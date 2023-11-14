using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5F;
    private float time = 0;
    public GameObject obstacle;
    public float height;
    // Update is called once per frame
    void Update()
    {
        float baguetteSpeed = (1 + Baguette.nombreDeBaguette * 0.1f);

        if (time > (queueTime / baguetteSpeed))
        {
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            time = 0;
            Destroy(go, 10);
        }
        time += Time.deltaTime;
    }
}