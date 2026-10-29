using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private Collider platformCollider;
    private Collider playerCollider;

    void Start()
    {
        platformCollider = GetComponent<Collider>();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerCollider = player.GetComponent<Collider>();
        }
    }

    void Update()
    {
        if (playerCollider == null) return;

        float playerFeet = playerCollider.bounds.min.y;
        float platformTop = platformCollider.bounds.max.y;

        if (playerFeet < platformTop - 0.05f)
        {
            Physics.IgnoreCollision(playerCollider, platformCollider, true);
        }
        else
        {
            Physics.IgnoreCollision(playerCollider, platformCollider, false);
        }
    }
}