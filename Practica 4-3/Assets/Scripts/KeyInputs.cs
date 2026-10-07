using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Key down & up: Enter
        if (Input.GetKeyUp(KeyCode.Return))
            print("Se ha pulsado enter");

        if (Input.GetKeyDown(KeyCode.Return))
            print("Se ha pulsado enter");

        if (Input.GetKey(KeyCode.Return))
            print("Se ha pulsado enter");

        //Other keys
        if (Input.GetKey(KeyCode.A))
            print("Se ha pulsado A");

        if (Input.GetKey(KeyCode.LeftArrow))
            print("Se ha pulsado LeftArrow");

        if (Input.GetKey(KeyCode.F1))
            print("Se ha pulsado F1");

        if (Input.GetKey(KeyCode.Space))
            print("Se ha pulsado Space");

        if (Input.GetKey(KeyCode.Escape))
            print("Se ha pulsado Escape");

        if (Input.GetKey(KeyCode.LeftAlt)) Input.GetKey(KeyCode.RightAlt);
                print("Se ha pulsado leftAlt");
    }
}
