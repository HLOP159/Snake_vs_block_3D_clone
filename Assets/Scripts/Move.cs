using UnityEngine;

public class Move : MonoBehaviour
{
    public float MoveSpeed;
    void Update()
    {
        Vector3 motion = new Vector3(0,0,MoveSpeed);
        transform.position += motion;
    }
}
