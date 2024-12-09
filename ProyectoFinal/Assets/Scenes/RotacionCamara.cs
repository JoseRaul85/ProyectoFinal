using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionCamara : MonoBehaviour
{

    [SerializeField]
    float velocidad;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float valX = Input.GetAxis("Mouse X");
        float valX_conVelocidad = valX * velocidad; 
        transform.Rotate(new Vector3(0, valX_conVelocidad, 0));

    }
}
