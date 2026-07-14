using UnityEngine;

public class TriggerMarker : MonoBehaviour
{

    public int themeIndex;
    private TopicTrigger topPanel;

    private void Start()
    {
        topPanel = FindFirstObjectByType<TopicTrigger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("TopDetector") && topPanel != null)
        {
            topPanel.ShowText(themeIndex);
        }
    }

}
