using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    [SerializeField] private Transform target_player;
    private void Update()
    {
        transform.position = new Vector3(target_player.position.x, target_player.position.y, -10);
    }
}
