using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaguetteCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MettreAJourNombreDeBaguette(Baguette.nombreDeBaguette);
    }

    public Text nombreDeBaguetteText;

    // Met à jour le Text avec le nombre actuel
    public void MettreAJourNombreDeBaguette(int nombreDeBaguette)
    {
        nombreDeBaguetteText.text = nombreDeBaguette.ToString();
    }
}

