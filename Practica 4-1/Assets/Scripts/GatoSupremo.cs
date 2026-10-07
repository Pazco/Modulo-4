using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class GatoSupremo : MonoBehaviour
{

    public string tituloTemible;
    public HumanoEsclavo victimaActual;
    [SerializeField]private RayoLaserMaligno armaEquipada;

    public bool atacar;
    public bool manipulacion;
    public bool recargar;
    private void Update()
    {
        

        if(manipulacion == true)
        {
            victimaActual.Manipular();
            manipulacion = false;
        }

        if(atacar == true)
        {
            armaEquipada.Ataque();
            float daño = armaEquipada.potenciaCegadora;
            victimaActual.Ataque(daño);
            atacar = false;
        }

        if (recargar == true)
        {
            armaEquipada.Recargar();
            recargar = false;
        }
    }

    

    
    

}