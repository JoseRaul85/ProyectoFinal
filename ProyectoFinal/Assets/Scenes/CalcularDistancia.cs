using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcularDistancia : MonoBehaviour
{
    Transform ubi_obj_a_cal_dist;
    float distance;
    public float getDistance()
    {
        return distance;
    }

    private void Awake()
    {
        ubi_obj_a_cal_dist = GameObject.Find("Jugador").GetComponent<Transform>();
    }
    void Start()
    {

    }
    void Update()
    {
        distance = Vector3.Distance(
            transform.position,
            ubi_obj_a_cal_dist.position);
    }
}
