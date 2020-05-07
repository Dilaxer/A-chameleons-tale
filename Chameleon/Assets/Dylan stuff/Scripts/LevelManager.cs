using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static int correctColor = 0;
    public Animator blackScreen;
    public Animator Chameleon;
    public int indexOfSceneToLoad;
    public Animator fish;
    public Animator mainCamera;

    public GameObject artCanvas;
    public GameObject ChameleonGameObject;
    public AudioSource clickSound;
    public AudioSource eatingSound;
    public AudioSource splashSound;

    public GameObject[] gameObjectsToTurnOff = new GameObject[5];



    public void checkIfPuzzleIsSolved()
    {
        clickSound.Play();

        if (correctColor == 12)
        {
            StartCoroutine(youWin());
        }
        else
            StartCoroutine(youLose());
    }

       
    

    IEnumerator youWin()
    {
        artCanvas.SetActive(false);

        for (int i = 0; i < gameObjectsToTurnOff.Length; i++)
        {
            gameObjectsToTurnOff[i].SetActive(false);
        }


        Chameleon.Play("JumpOntoCanvasWin");
        mainCamera.Play("MoveIn");
        yield return new WaitForSeconds(1.2f);
        splashSound.Play();
        fish.Play("SwimBy");
        yield return new WaitForSeconds(2f);
        blackScreen.Play("FadeOutBlackScreen");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(indexOfSceneToLoad);
        correctColor = 0;
    }

    IEnumerator youLose()
    {
        artCanvas.SetActive(false);

        for (int i = 0; i < gameObjectsToTurnOff.Length; i++)
        {
            gameObjectsToTurnOff[i].SetActive(false);
        }

        Chameleon.Play("JumpOntoCanvasFail");
        mainCamera.Play("MoveIn");
        yield return new WaitForSeconds(1.2f);
        eatingSound.Play();
        splashSound.Play();
        fish.Play("Attack");
        yield return new WaitForSeconds(.38f);
        ChameleonGameObject.SetActive(false);
        artCanvas.SetActive(true);
        yield return new WaitForSeconds(.5f);
        mainCamera.Play("ZoomOut");
        yield return new WaitForSeconds(2f);
        blackScreen.Play("FadeOutBlackScreen");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
        correctColor = 0;
    }
}
