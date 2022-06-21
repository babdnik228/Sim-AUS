using UnityEngine;

public class SpawnActivator : MonoBehaviour
{
    [SerializeField] private GameObject[] spawner;
    [SerializeField] private int time;
    private void Start()
    {
        Invoke("ActivSpawn", time );
    }
    public void ActivSpawn()
    {
        for (int i = 0; i < spawner.Length; i++)
        {
            spawner[i].SetActive(true);
        }
    }
}
