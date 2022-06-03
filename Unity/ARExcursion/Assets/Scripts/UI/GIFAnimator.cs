
using UnityEngine;
using UnityEngine.UI;

public class GIFAnimator : MonoBehaviour
{

    public Sprite[] animatedImages;
    public Image animatedImageObj;

    [SerializeField]
    private float subTime;

    void Update()
    {
        animatedImageObj.sprite = animatedImages[(int)(Time.time * subTime) % animatedImages.Length];
        //     var index : int = (Time.time * farmsPerSecond) % farms.Length;        
        //     render.material.mainTexture = farmes[index];       
    }
}