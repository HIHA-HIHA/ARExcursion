using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    [SerializeField]
    private LoaderSceneData dataset;

    [SerializeField]
    private string nameScene;

    private void Awake()
    {
        if (dataset == null)
        {
            Debug.LogWarning("Loader Scene: " + gameObject.name + ":  ERROR: Not set datset!");
        }
    }

    public void StartLoading()
    {
        dataset.LoadingPanel.SetActive(true);
        SceneManager.LoadSceneAsync(nameScene);
    }

   

}