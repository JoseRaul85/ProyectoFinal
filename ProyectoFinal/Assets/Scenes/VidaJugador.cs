using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    [SerializeField] private Transform player; // Referencia al jugador
    [SerializeField] private Vector3 offset = new Vector3(0, 2, 0); // Ajuste de posición

    void Update()
    {
        if (player != null)
        {
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(player.position + offset);
            transform.position = screenPosition;
        }
    }
}

