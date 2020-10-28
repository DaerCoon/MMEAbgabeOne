using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ballPrefab;

    private void Start()
    {
        for (int i= 0;i< 5;i++) 
        {
            Vector3 position = new Vector3(Random.Range(-5, 5), Random.Range(1, 2), Random.Range(-5, 5));
            Instantiate(ballPrefab, position, Quaternion.identity);
        };
    }
}
