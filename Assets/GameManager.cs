using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int Score { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddScore(int points)
    {
        Score += points;
        Debug.Log("Score: " + Score);
    }
    private void Start()
{
    // Esto es una prueba para ver que funciona solo al iniciar
    AddScore(5); 
}
}