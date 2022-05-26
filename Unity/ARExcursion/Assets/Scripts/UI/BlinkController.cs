using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeWait;



    public void Run()
    {
        if (gameObject.activeSelf)
        {
            animator.gameObject.SetActive(true);
            StartCoroutine(CreateBlink());
        }
        
    }

    private IEnumerator CreateBlink()
    {
        animator.SetTrigger("Run");
        yield return new WaitForSeconds(timeWait);
        animator.gameObject.SetActive(false);
    }

    
}
