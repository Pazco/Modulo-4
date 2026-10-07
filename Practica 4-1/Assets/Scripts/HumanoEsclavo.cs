using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanoEsclavo : MonoBehaviour
{

    public string nombreDePila;
    [SerializeField]private float nivelCordura = 100;
    private int latasDeAtunOcultas;

     public void Manipular()
    {
        int latasGanadas;

        if (nivelCordura < 50)
        {
            nivelCordura += 50;
            Debug.Log(nombreDePila + " No esta de humor, pero sigue asi y lo conseguiras");
        }
        else
        {
            latasGanadas = Random.Range(1, 5);
            latasDeAtunOcultas += latasGanadas;
            Debug.Log(nombreDePila + " Ha sido manipulado con exito" + "has ganado " + latasGanadas + "latas de atun");
        }


    }

    public void Ataque(float daño)
    {
        if (nivelCordura > 0)
        {
            nivelCordura -= daño;
            Debug.Log("Estas volviendo loco a " + nombreDePila);
        }
        else
        {
            Debug.Log("HAS VUELTO COMPLETAMENTE MAJARA A " + nombreDePila + "Deja vivir al pobre");
        }
    }

    public void Recargar()
    {
        latasDeAtunOcultas -= 1;
        
    }




}