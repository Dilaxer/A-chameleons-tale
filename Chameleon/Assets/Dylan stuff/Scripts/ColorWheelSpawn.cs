using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorWheelSpawn : MonoBehaviour
{
    float yAxis;  

    void Update()
    {  
            yAxis = ColorWheel.pressedCube.transform.position.y;

            gameObject.transform.position = new Vector3(ColorWheel.pressedCube.transform.position.x,
            yAxis -= 1,
            gameObject.transform.position.z);
    }
}
