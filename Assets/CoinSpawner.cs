using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float xMin = -8f, xMax = 8f, yMin = -4f, yMax = 4f;

    public void SpawnCoin()
    {
        float x = Random.Range(xMin, xMax);
        float y = Random.Range(yMin, yMax);
        Instantiate(coinPrefab, new Vector3(x, y, 0), Quaternion.identity);
    }
}
