using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslacionLuna : MonoBehaviour
{
    private Transform Tierra;
    public int Velocidad;

    private Vector3 posicionAnterior;
    // Start is called before the first frame update
    void Start()
    {

        Tierra = GameObject.Find("Tierra").transform;

    }

    // Update is called once per frame
    void Update()
    {

        posicionAnterior = transform.position;

        transform.RotateAround(Tierra.position,Vector3.up, Velocidad * Time.deltaTime);
        Vector3 direccion = transform.position - posicionAnterior;
        direccion.Normalize();
        Debug.DrawRay(transform.position, direccion * 5f);

    }
}
