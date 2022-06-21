using Cinemachine;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    private Vector3 local_scale = new Vector3(1, 1,1);
    private GameObject cinemachine;
    private void Start()
    {
        Destroy(gameObject, 20);
        cinemachine = GameObject.FindGameObjectWithTag("Chinem");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager playerManager = collision.GetComponent<PlayerManager>();
        if(playerManager != null)
        {
            playerManager.health_fpsc += 2;
            cinemachine.GetComponent<CinemachineVirtualCamera>().m_Lens.OrthographicSize += 2.5f;
            playerManager.transform.localScale = playerManager.transform.localScale + local_scale;
            Destroy(gameObject);
        }
    }
}
