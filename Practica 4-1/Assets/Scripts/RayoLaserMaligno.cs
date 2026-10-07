using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoLaserMaligno : MonoBehaviour
{

    public float potenciaCegadora = 50;
    [SerializeField]private float bateriaRestante = 100;

    public float Ataque()
    {
        if (bateriaRestante > 0)
        {
            bateriaRestante -= 25;
        }
        else Debug.Log("Se te a acabado la bateria");
        
        return bateriaRestante;
    }
    
    public void Recargar()
    {
        if(bateriaRestante < 100)
        {
            bateriaRestante += 25;
            Debug.Log("Bateria recargada un 25%");
            
        }
        else
        {
            Debug.Log("La bateria ya esta llena no hace falta recargar");
            
        }

        

    }
}
