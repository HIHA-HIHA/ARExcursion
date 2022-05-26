using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class LoaderSceneData : MonoBehaviour
{
    [SerializeField]
    private GameObject loadingPanel;

    [SerializeField]
    private CanvasGroup alphaImage;

    public CanvasGroup AlphaImage { get => alphaImage;}
    public GameObject LoadingPanel { get => loadingPanel; set => loadingPanel = value; }
}
