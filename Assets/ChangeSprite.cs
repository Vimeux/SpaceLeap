using UnityEngine;

public class ChangeSprite : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;

    public Sprite sprite1;
    public Sprite sprite2;

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();


        MettreAJourSprite();
    }

    void MettreAJourSprite()
    {

        if (Baguette.nombreDeBaguette < 3)
        {
            spriteRenderer.sprite = sprite1;
        }
        else if (Baguette.nombreDeBaguette >= 3)
        {
            spriteRenderer.sprite = sprite2;
        }

    }

    void Update()
    {
        print(Baguette.nombreDeBaguette);
        MettreAJourSprite();
    }
}
