using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baguette : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static int nombreDeBaguette = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Vérifie si le joueur a passé sur l'objet
        if (collision.CompareTag("Player"))
        {

            nombreDeBaguette++;
            Destroy(gameObject);

        }
    }
}
