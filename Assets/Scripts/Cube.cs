using UnityEngine;

public class Cube : MonoBehaviour
{
    public float Damage = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < Damage; i++)
            {
                other.GetComponent<Player>().DestroyBone();
            }
            Destroy(gameObject);
        }
    }
}
