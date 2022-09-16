using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    
    void Update()
    {
        Vector3 currentPlayerPosition = new Vector3(Player.position.x,Player.position.y,Player.position.z);
        transform.position = new Vector3(0,10,currentPlayerPosition.z - 15);
    }
}
