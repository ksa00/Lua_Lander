using TMPro;
using UnityEngine;

public class StatsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI StatsTextMesh;

    private void Update()
    {
        UpdateStatsTextMesh();
    }
    private void UpdateStatsTextMesh()
    {
        StatsTextMesh.text=GameManager.Instance.GetScore() + "\n" +
            GameManager.Instance.GetTime() + "\n" +
            Lander.Instance.GetSpeedX() + "\n" +
            Lander.Instance.GetSpeedY() + "\n" +
            Lander.Instance.GetFuel() ;

            
    }
}
