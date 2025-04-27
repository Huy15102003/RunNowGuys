using UnityEngine;

public class RaoChan : MonoBehaviour
{
    Player player;

    private void Awake()
    {
        player = Object.FindFirstObjectByType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.Die();
        }
    }
}
