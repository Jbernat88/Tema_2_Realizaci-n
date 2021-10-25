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
    public bool isCold;


    // Start is called before the first frame update
    void Start()
    {
        HelloWorld();
        if (x == 2 && y <= 5)

        {
            Debug.Log("Verdadero");

        }
        else
        {
            Debug.Log("Falso");
        }


        //transform.position = new Vector3(0,0,0);
        transform.position = Vector3.down;
        Debug.Log(transform.position);






        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + "-" + y + " = " + (x - y));  
        Debug.Log($"Division: {x} + {y} = {x / y}");
        Debug.Log($"Multiplicacion: {x} + {y} = {x * y}");
        Debug.Log(string.Format("Division: ¨{0} / {1} = {2}", x, y, x * y));
        */

        if (isRaining == true)
        {
            if (isCold == true)
            {
                Debug.Log("Lleva paraguas y sudadera");
            }
            else
            {
                Debug.Log("No llueve. No lleves paraguas");
            }
        }
        else
        {


            if (isCold == true)
            {
                Debug.Log("Lleva una sudadera");
            }
            else
            {
                Debug.Log("Disfruta del dia");
            }

        }
        if (playerAge >= 18)
            {
                Debug.Log("Eres mayor de edad");

            }
            else if (playerAge >= 13)
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
           //Debug.Log(transform.position);
           if (Input.GetKeyDown(KeyCode.RightArrow))
           {
            transform.position += Vector3.right; 
           }
           if (Input.GetKeyDown(KeyCode.LeftArrow))
           {
            transform.position += Vector3.left;
           }
           if (Input.GetKeyDown(KeyCode.UpArrow))
           {
            transform.position += Vector3.up;
           }
           if (Input.GetKeyDown(KeyCode.DownArrow))
           {
            transform.position += Vector3.down;
           }
           if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }

    
    
    
    
        }

         public void HelloWorld()
    {
        Debug.Log("Hola, Mundo");
    }






    }


