using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        Vector3 moveCamera = Input.mousePosition;
        Vector3 mousWordCamera = Camera.main.ScreenToWorldPoint(moveCamera);
        mousWordCamera.z = 0;
        transform.position = Vector3.MoveTowards(transform.position, mousWordCamera, speed * Time.deltaTime);
    }
}
