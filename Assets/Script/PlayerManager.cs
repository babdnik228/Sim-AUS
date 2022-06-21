using UnityEngine;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    public float health_fpsc;
    public float health_fpsc_max;
    public GameObject cCamera;
    private Vector3 trSc;

    private void Update()
    {
        health_fpsc = cCamera.GetComponent<CinemachineVirtualCamera>().m_Lens.OrthographicSize;
        if (health_fpsc <= 0)
        {
            Destroy(gameObject);
        }
        if(transform.localScale.x <= trSc.x)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CountryBasic countryBasic = collision.GetComponent<CountryBasic>();
        if (countryBasic != null)
        {
            health_fpsc--;
            Destroy(countryBasic.gameObject);
        }
    }
}
