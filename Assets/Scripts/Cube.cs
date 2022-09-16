using UnityEngine;

public class Cube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Control control ))
        {

        }    
    }
}
