using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    public Material material;
    public static bool canColorWheelBeClosed = false;
    public AudioSource clickSound;

    void OnMouseOver()
    {         
         ColorWheel.pressedCube.GetComponent<Renderer>().material = material;
    }
    
    void OnMouseDown()
    {
        clickSound.Play();
        canColorWheelBeClosed = true;
    }

}
