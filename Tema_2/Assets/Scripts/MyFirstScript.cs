using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Joan";
   [SerializeField] private bool game0ver;
    */

    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;

    public bool isRaining = false;

    public int playerAge = 35;



    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + "-" + y + " = " + (x - y));  
        Debug.Log($"Division: {x} + {y} = {x / y}");
        Debug.Log($"Multiplicacion: {x} + {y} = {x * y}");
        Debug.Log(string.Format("Division: ¨{0} / {1} = {2}", x, y, x * y));
        */
       /*      
        if(isRaining == true)
        {
            Debug.Log("Lleva paraguas");
        } 
        else
        {
            Debu.Log("No lleves paraguas");
        }
        */

        if (playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad");

        }else if (playerAge >= 13)
        {
            Debug.Log("Eres adolescente");
        }
        else
        {
            Debug.Log("Eres un niño");
        }
         
        

        






        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
