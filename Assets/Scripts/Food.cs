using UnityEngine;

public class Food : MonoBehaviour
{
    public int HPFood = 10 ;
    public float Delay;
    private void Start()
    {
        HPFood = Random.Range(1, HPFood + 1);
    }
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
