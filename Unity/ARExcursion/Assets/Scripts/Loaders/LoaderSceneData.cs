using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class LoaderSceneData : MonoBehaviour
{
    [SerializeField]
    private GameObject loaderPanel;

    [SerializeField]
    private TMP_Text loaderText;

    public GameObject LoaderPanel { get => loaderPanel; set => loaderPanel = value; }
    public TMP_Text LoaderText { get => loaderText; set => loaderText = value; }
}
