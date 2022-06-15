using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotation : MonoBehaviour
{
    [SerializeField]
    private Transform model;

    public void Rotate(float angle)
    {
        if (model != null)
        {
            model.RotateAround(model.position, model.up, angle);
        }
    }

    public void SetModel(Transform model)
    {
        this.model = model;
    }

    public void ClearModel()
    {
        model = null;
    }
}
