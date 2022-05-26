using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    private PoolModels poolModels;

    public void SetPool(PoolModels poolModels)
    {
        this.poolModels = poolModels;
    }

    public void ClearPool()
    {

    }

    public void TurnModel()
    {
        if(poolModels != null)
        {
            poolModels.TurnModel();
        }
    }
}
