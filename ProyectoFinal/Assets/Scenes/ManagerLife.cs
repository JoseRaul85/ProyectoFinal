using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerLife : MonoBehaviour
{
    public Image barraDeVida; 
    [SerializeField] private float vida = 1f; 

    public void TakeDamage(float damage)
    {
        vida -= damage;
        vida = Mathf.Clamp(vida, 0f, 1f); 
        barraDeVida.fillAmount = vida; 

        if (vida <= 0)
        {
            CambiarAEscenaGameOver(); 
        }
    }

    private void CambiarAEscenaGameOver()
    {
        SceneManager.LoadScene("Final"); 
    }
}
