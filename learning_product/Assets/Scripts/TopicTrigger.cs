using UnityEngine;

public class TopicTrigger : MonoBehaviour
{
    public GameObject[] topicTexts;
    public int defautTopic =0;

    private void Start()
    {
        ShowText(defautTopic);
    }
    public void ShowText(int index)
    {
        if(index<0 || index>= topicTexts.Length) { return; }
        for(int i = 0; i< topicTexts.Length; i++)
        {
            if(topicTexts[i] != null)
            {
                topicTexts[i].SetActive(i == index);
            }
        }
    }
}
