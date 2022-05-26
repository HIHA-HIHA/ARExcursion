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
            Debug.LogWarning("Loader Scene: "+gameObject.name+":  ERROR: Not set datset!");
        }
    }

    public void StartLoading()
    {
        dataset.LoadingPanel.SetActive(true);
        StartCoroutine(AsyncLoadScene());
    }

    private IEnumerator AsyncLoadScene()
    {
        var operation = SceneManager.LoadSceneAsync(nameScene,LoadSceneMode.Additive);
        while (!operation.isDone)
        {
            dataset.AlphaImage.alpha = (
                operation.progress);
            yield return new WaitForSeconds(0.001f);
        }
        yield return new WaitForSeconds(1f);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        

    }


}
