using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SizeController : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject;

    [SerializeField]
    private float subargumentForScale;


    public void SetSize(float value)
    {
        if(gameObject != null)
            gameObject.transform.localScale = new Vector3(value, value, value) * subargumentForScale;
    }

    public void SetGameObjectForChangeSize(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }

    public void ClearGameObjectForChangeSize()
    {
        gameObject = null;
    }

}
