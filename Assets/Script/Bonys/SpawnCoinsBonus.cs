using UnityEngine;

public class SpawnCoinsBonus : MonoBehaviour
{
    
    [SerializeField] private GameObject prefab_Coins;
    [SerializeField] private float Timer_spawn;
    [SerializeField] private float Timer_interval;
    private void Update()
    {
        Timer_spawn -= Time.deltaTime;
        if(Timer_spawn <= 0)
        {
            Vector2 pos = new Vector2(0, 0);
            pos.x = Random.Range(-100, 100);
            pos.y = Random.Range(-50, 50);
            GameObject bonus = Instantiate(prefab_Coins, pos, Quaternion.identity);
            Timer_spawn = Timer_interval;
        }
    }
    
}
