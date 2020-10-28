using UnityEngine;

public class Delete : MonoBehaviour
{
    public float ttl = 1;

    private void Update()
    {
        if (ttl > 0)
        {
            ttl -= Time.deltaTime;
            if (ttl <= 0)
            {
                Destruction();
            }
        }
        if (transform.position.y <= -10) Destruction();
    }
    
    private void Destruction()
    {
        Destroy(gameObject);
    }
}