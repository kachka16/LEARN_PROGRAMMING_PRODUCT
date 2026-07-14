using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class RobotAnimation : MonoBehaviour, IPointerClickHandler
{
    public Animator anim;
    private bool isPlaying = false;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (isPlaying) { return;}
            anim.SetTrigger("RobotPlay");
        StartCoroutine(WaitAnimation());
    }
    IEnumerator WaitAnimation()
    {
        isPlaying = true;
        yield return new WaitForSeconds(1f);
        isPlaying = false;
    }
}
