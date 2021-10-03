using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            Destroy(collision.gameObject);
        }
    }
}
