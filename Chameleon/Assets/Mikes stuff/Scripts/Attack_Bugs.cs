using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Bugs : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Control mechanic for mouse
    private void OnMouseDown()
    {
        if (GameObject.FindWithTag("Bugs"))
        {
            Score_Tracker.scoreValue += 1;
            Destroy(gameObject);
        }
    }





}
