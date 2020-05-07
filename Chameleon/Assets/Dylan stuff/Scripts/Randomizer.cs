using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{

    public GameObject[] ColoredSquares = new GameObject[12];
    public int HowManyColoredSquaresCanThereBeInALevel;
    public Material[] colors = new Material[7];
    GameObject selectedSquare;

    void Awake()
    {        
        
            for (int i = 0; i < HowManyColoredSquaresCanThereBeInALevel; i++)
            {              
                selectedSquare = ColoredSquares[Random.Range(0, ColoredSquares.Length)];
            if (selectedSquare.activeSelf == false)
                selectedSquare.SetActive(true);
            else
                i--;
            }  

            
            for (int i = 0; i < ColoredSquares.Length; i++)
            {
                if (ColoredSquares[i].activeSelf == true)
                ColoredSquares[i].GetComponent<SpriteRenderer>().material = colors[Random.Range(0, colors.Length)];
            }             
    }
    
}
