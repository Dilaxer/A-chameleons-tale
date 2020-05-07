using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio_Tracker : MonoBehaviour
{
    public AudioClip currentClip;
    public AudioClip otherClip;

    IEnumerator start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        yield return new WaitForSeconds(0.1f);
        audio.clip = otherClip;
        audio.Play();

       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
