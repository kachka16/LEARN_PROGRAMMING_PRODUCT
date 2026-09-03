using UnityEngine;

public class LessonFalseScript : MonoBehaviour
{
    public GameObject locks;
    public Animator circleAnimator;

    void Start()
    {
        locks.SetActive(true);
    }
    public void lockFalse()
    {
        if (locks != null)
        {
            locks.SetActive(false);
        }
    }
    public void PlayCircle()
    {
        circleAnimator.SetTrigger("start");
    }
}
