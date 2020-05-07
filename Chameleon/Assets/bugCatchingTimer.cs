using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class bugCatchingTimer : MonoBehaviour
{

    public TextMeshProUGUI timer;
    public Animator blackscreen;

    IEnumerator Start()
    {
        for (int i = 8; i >= 0; i--)
        {
            timer.text = i.ToString();
            yield return new WaitForSeconds(1);
        }

        blackscreen.Play("FadeOutBlackScreen");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(8);

    }

    
}
