using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{
    private int myNum ;
    private int randNum;
    private int counter; //Contador de intentos
    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);
            CompareToRandomNumber(myNum);
            counter ++;
        } // a la variable counter le sumamos 1
    }
    public void CompareToRandomNumber (int userNum)
    {

        if (userNum > randNum)
        {
            Debug.Log("Te has pasado. A la proxima!");
        }
        if (userNum < randNum)
        {
            Debug.Log("Te has quedado corto. Intentalo de nuevo!");
        }
        if (userNum == randNum)
        {
            Debug.Log("ARA VAS. Has dado en el clavo!");
            Debug.Log($"Has utilizado {counter} intentos");
        }


    }



}