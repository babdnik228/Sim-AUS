using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject prefab_enemy;
    //
    [SerializeField] private float TimerInterval;
    [SerializeField] private float Timer;
    private void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0)
        {
            GameObject enemy = Instantiate(prefab_enemy, transform.position, Quaternion.identity);
            Timer = TimerInterval;
        }
    }
}
