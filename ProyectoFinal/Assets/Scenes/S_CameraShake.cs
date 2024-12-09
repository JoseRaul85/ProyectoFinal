using System.Collections;
using UnityEngine;

public class S_CameraShake : MonoBehaviour
{
    [SerializeField] Transform cam; 
    [SerializeField] float duracion = 0.5f; 
    [SerializeField] float amplitud = 0.1f; 
    private float transcurrido;

    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main.transform; 
        }
    }
    public IEnumerator shake()
    {
        Vector3 posicionOriginal = cam.position;
        transcurrido = 0;
        while (transcurrido < duracion)
        {
            float x = Random.Range(-1f, 1f) * amplitud;
            float y = Random.Range(-1f, 1f) * amplitud;
            cam.position = new Vector3(posicionOriginal.x + x, posicionOriginal.y + y, posicionOriginal.z);
            transcurrido += Time.deltaTime;
            yield return null;
        }
        cam.position = posicionOriginal;
    }
}
