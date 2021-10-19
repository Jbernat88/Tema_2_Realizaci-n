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
        
    }
}
