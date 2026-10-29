using UnityEngine;
using UnityEngine.SceneManagement; 

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player killed!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}