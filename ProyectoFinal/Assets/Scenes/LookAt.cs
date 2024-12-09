using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float maxDistance = 6.5f;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < maxDistance)
        {
            Vector3 lookDirection = player.position - transform.position;
            lookDirection.y = 0; 
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }
}
