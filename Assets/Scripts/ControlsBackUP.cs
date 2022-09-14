using UnityEngine;

public class ControlsBackUP : MonoBehaviour
{
    private Vector3 _previousMousePosition;
    public float Sensitivity;

    void Update()
    {
        Vector3 curPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        // Debug.Log("_previousMousePosition " + _previousMousePosition);

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Input " + Input.mousePosition);

            Vector3 delta = Input.mousePosition - _previousMousePosition;
            if ((curPosition.x + delta.x * Sensitivity) > 4.5f || (curPosition.x + delta.x * Sensitivity) < -4.5f)
            {
                delta.x = 0f;
            }
            transform.position = new Vector3(curPosition.x + delta.x * Sensitivity, 0.5f, 0);
            Debug.Log("delta.x " + delta.x);
            curPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Debug.Log("curPosition 1 " + curPosition.x);
        }
        Debug.Log("transform.position.x " + transform.position.x);
        _previousMousePosition = Input.mousePosition;

        // Debug.Log("_previousMousePosition " + _previousMousePosition);
        Debug.Log("curPosition 2 " + curPosition.x);
    }
}
