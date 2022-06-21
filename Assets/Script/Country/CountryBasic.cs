using UnityEngine;
using Cinemachine;

public class CountryBasic : MonoBehaviour
{
    public float size_camera;
    private GameObject cCamera;
    public Vector3 localScaleDead;
    private void Start()
    {
        cCamera = GameObject.FindGameObjectWithTag("Chinem");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager playerManager = collision.GetComponent<PlayerManager>();
        if(playerManager != null)
        {
            playerManager.transform.localScale = playerManager.transform.localScale - localScaleDead;
            cCamera.GetComponent<CinemachineVirtualCamera>().m_Lens.OrthographicSize -= size_camera;
        }
    }
}
