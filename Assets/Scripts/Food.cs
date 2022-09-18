using UnityEngine;

public class Food : MonoBehaviour
{
    public float HPFood = 3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < HPFood; i++)
            {
                other.GetComponent<Player>().AddBone();
            }
            Destroy(gameObject);
        }
    }
}
