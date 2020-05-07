using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWheel : MonoBehaviour
{

    public Animator colorWheelAnimator;
    static bool hasMouseBeenPressed = false;
    public static GameObject pressedCube;
    public PolygonCollider2D[] colorColliders = new PolygonCollider2D[8];
    public Material expectedMaterial;
    bool canLevelManagerBeAccessed = true;

    public GameObject correspondingColoredSquare;

    public AudioSource clickSound;

    void Start()
    {
        pressedCube = gameObject;

        expectedMaterial = correspondingColoredSquare.GetComponent<SpriteRenderer>().sharedMaterial;
    }


    void Update()
    {
        if (SetColor.canColorWheelBeClosed)
        {
            ColorWheelFadeOut();
            SetColor.canColorWheelBeClosed = false;
        }

        if (gameObject.GetComponent<SpriteRenderer>().sharedMaterial == expectedMaterial && canLevelManagerBeAccessed)
        {
            canLevelManagerBeAccessed = false;
            LevelManager.correctColor++;
        }
        else if (gameObject.GetComponent<SpriteRenderer>().sharedMaterial != expectedMaterial && !canLevelManagerBeAccessed)
        {
                canLevelManagerBeAccessed = true;
                LevelManager.correctColor--;
        }
            
    }
      

    void OnMouseDown()
    {        
        if (!hasMouseBeenPressed)
        {
            clickSound.Play();
            StartCoroutine(ColorWheelFadeIn());
        }
        else if (hasMouseBeenPressed)
        {
            ColorWheelFadeOut();
        }
    }



    void ColorWheelFadeOut()
    {
        colorWheelAnimator.Play("ColorWheelFadeOut");
        hasMouseBeenPressed = false;

        for (int i = 0; i < colorColliders.Length; i++)
        {
            colorColliders[i].enabled = false;
        }
    }

    IEnumerator ColorWheelFadeIn()
    {
        pressedCube = gameObject;
        yield return new WaitForSeconds(.05f);
        colorWheelAnimator.Play("ColorWheelFadeIn");
        hasMouseBeenPressed = true;

        for (int i = 0; i < colorColliders.Length; i++)
        {
            colorColliders[i].enabled = true;
        }
    }
}
