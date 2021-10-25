using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo
    [SerializeField] private string sound = "¡Brum, brum";

    [SerializeField] private string name; //Variable que designa el nombre de los vehiculos
    [SerializeField] private int numberWheels = 4; // Variable que guarda el numero de ruedas
    public bool hasSiren = false;
    [SerializeField] private bool isOn = true;
    [SerializeField] private float gasoline;







    // Start is called before the first frame update
    void Start()
    { /*
        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}"); 


        if (hasSiren)

        {
            Debug.Log($"{name} tiene sirena"); //Es un operador para idicar la variable sirena
        */
        if (isOn == true)
        {
            Debug.Log($"{sound}");
        }
        else if (hasSiren == true)

        {
            Debug.Log($"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no esta en marcha");
        }

        if (isOn)
        {
            if(gasoline <10)
            {
                Debug.Log($"A {name} le queda poca gasolina");
            }

            if(hasSiren)
            {
                Debug.Log(sound);
            }
            else
            {
                Debug.Log($"{name} no tiene sirena");
            }
        }
        else if (isOn == false)
        {
            Debug.Log($"{name} no esta en marcha");
        }



    
    }
   
    
    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {

            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += Vector3.right;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += Vector3.left;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += Vector3.up;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += Vector3.down;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += Vector3.forward;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position += Vector3.back;
        
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                transform.rotation *= Quaternion.Euler (0, 10, 0);
            }
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                transform.rotation *= Quaternion.Euler (0, -10, 0);
            }


        }

    }
}
