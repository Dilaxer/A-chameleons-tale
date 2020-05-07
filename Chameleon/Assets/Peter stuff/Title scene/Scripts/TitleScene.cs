using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    [SerializeField] float fallingSpeed = 1.5f;
    public Animator blackScreenAnimator;
    int buildIndex;

    void Update()
    {
        transform.localScale += new Vector3(0, fallingSpeed, 0) * Time.deltaTime;
    }

    public void loadScene(int buildIndex)
    {
        this.buildIndex = buildIndex;
        blackScreenAnimator.Play("FadeOutBlackScreen");
        StartCoroutine(waitAMoment());
    }

    IEnumerator waitAMoment()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(buildIndex);
    }

}