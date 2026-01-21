using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().AddScore(1);
            FindObjectOfType<CoinSpawner>().SpawnCoin();
            Destroy(gameObject);
        }
    }
}
