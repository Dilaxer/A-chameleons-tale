using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int howMuchTimeDoesPlayerHaveToMemorize;
    public TextMeshProUGUI countText;

    void Update()
    {
        countText.text = howMuchTimeDoesPlayerHaveToMemorize.ToString();

        if (howMuchTimeDoesPlayerHaveToMemorize == -1)
        {
            Destroy(countText);
        }
    }

    void Start()
    {
        StartCoroutine(startCountdown());
    }

    IEnumerator startCountdown()
    {
        yield return new WaitForSeconds(2);

        for (int i = howMuchTimeDoesPlayerHaveToMemorize; i >= 0; i--)
        {
            howMuchTimeDoesPlayerHaveToMemorize--;
            yield return new WaitForSeconds(1);
        }

    }
    
}
