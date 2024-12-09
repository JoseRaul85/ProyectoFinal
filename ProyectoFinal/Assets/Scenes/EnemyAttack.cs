using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float fuerzaEmpuje = 40f; 
    [SerializeField] private float daño = 0.2f; 
    private S_CameraShake cameraShake; 
    private ManagerLife lifeManager; 

    void Start()
    {
   
        cameraShake = FindObjectOfType<S_CameraShake>();
        lifeManager = FindObjectOfType<ManagerLife>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
           
            if (cameraShake != null)
            {
                StartCoroutine(cameraShake.shake());
            }

            
            if (lifeManager != null)
            {
                lifeManager.TakeDamage(daño);
            }

            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                Vector3 knockbackDirection = (collision.transform.position - transform.position).normalized;
                knockbackDirection.y = 0.10f; 
                playerRb.AddForce(knockbackDirection * fuerzaEmpuje, ForceMode.Impulse); 
            }
        }
    }
}