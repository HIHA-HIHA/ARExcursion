using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolModels : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> models;

    [SerializeField]
    private GameObject activeModel;

    [SerializeField]
    private int activeID;

    public void TurnModel()
    {
        activeID++;

        if(activeID >= models.Count)
        {
            activeID = 0;
        }

        GameObject newModel = models[activeID];
        activeModel.SetActive(false);
        activeModel = newModel;
        activeModel.SetActive(true);
        
    }
}
