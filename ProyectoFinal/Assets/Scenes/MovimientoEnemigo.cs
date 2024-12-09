using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    Transform ubi_personaje;
    CalcularDistancia auxComponenteDistance;

    private void Awake()
    {
        ubi_personaje = GameObject.Find("Jugador").GetComponent<Transform>();
    }
    
    void Start()
    {
        auxComponenteDistance = GetComponent<CalcularDistancia>();
    }

    void Update()
    {
        float distanciaAlEnemigo = auxComponenteDistance.getDistance();
        if (distanciaAlEnemigo < 75.0f)
        {
            float velocidad = 6.0f * Time.deltaTime;
            transform.position =
            Vector3.MoveTowards(transform.position, ubi_personaje.position, velocidad);
        }
    }
}


