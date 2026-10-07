using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslacionDePlanetas : MonoBehaviour
{  
    public Transform Sol;
    public int Velocidad;

    private Vector3 posicionAnterior;
    // Start is called before the first frame update
    void Start()
    {

        Sol = GameObject.Find("Sol").transform;
        GameObject.Find("Mercurio");
        GameObject.Find("Venus");
        GameObject.Find("Tierra");
        GameObject.Find("Luna");
        GameObject.Find("Marte");
        GameObject.Find("Jupiter");
        GameObject.Find("Saturno");
        GameObject.Find("Urano");
        GameObject.Find("Neptuno");
    }

    // Update is called once per frame
    void Update()
    {
        posicionAnterior = transform.position;

        transform.rotation = Sol.rotation;
        transform.RotateAround(Sol.position, Vector3.up, Velocidad * Time.deltaTime);
        
        Vector3 direccion = transform.position - posicionAnterior;
        direccion.Normalize();
        Debug.DrawRay(transform.position, direccion * 5f);
       
    }
}
