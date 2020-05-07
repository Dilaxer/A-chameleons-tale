using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Animator mainCameraAnimator;
    public Animator thoughtBubble;

    public AudioSource windSound;

    public float howMuchTimeToWaitUntilMoveOut;


    void Start()
    {
        mainCameraAnimator.Play("MoveIn");
        StartCoroutine(showSolution());        
    }


    
    IEnumerator showSolution()
    {
        yield return new WaitForSeconds(.2f);
        windSound.Play();
        yield return new WaitForSeconds(howMuchTimeToWaitUntilMoveOut);
        mainCameraAnimator.Play("MoveOut");
        windSound.Play();      
        thoughtBubble.enabled = true;
    }
}
