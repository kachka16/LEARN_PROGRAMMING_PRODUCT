using UnityEngine;

public class LessonFalseScript : MonoBehaviour
{
    public GameObject locks;
    public Animator circleAnimator;
    public void Kfkeef()
    {
        locks.SetActive(false);
    }
    public void PlayCircle()
    {
        circleAnimator.SetTrigger("start");
    }
}
