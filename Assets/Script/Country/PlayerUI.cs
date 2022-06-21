using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public PlayerManager playerManager;
    public Slider max_health;
    public Slider health;
    private void Update()
    {
        max_health.maxValue = playerManager.health_fpsc_max;
        health.value = playerManager.health_fpsc;
    }
}
