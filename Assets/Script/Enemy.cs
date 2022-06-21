using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    private GameObject player_target;
    private void Start()
    {
        player_target = GameObject.FindWithTag("Player");
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player_target.transform.position, speed * Time.deltaTime);
    }
}
