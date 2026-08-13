using UnityEngine;

public class animFalse : MonoBehaviour
{
    public Animator circleAnimator;
    public GameObject circleObject;
    public void stopCircle()
    {
        if (circleObject != null)
        {
            circleObject.SetActive(false);
        }
    }
    public void startCircle()
    {
        if (circleObject != null)
        {
            circleObject.SetActive(true);
        }
    }
    public void PlayCircle()
    {
        if (circleAnimator != null)
        {
            circleAnimator.SetTrigger("start");
        }
    }
}
