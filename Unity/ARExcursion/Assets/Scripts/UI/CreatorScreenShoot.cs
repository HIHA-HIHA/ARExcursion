using System;
using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.Events;

public class CreatorScreenShoot : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onCreateScreenshoot;

    [SerializeField]
    private GameObject UI;

    [SerializeField]
    private GameObject waterMark;


    public void CreateScreenshoot()
    {
        StartCoroutine(IECreateScreenShoot());
    }

    private IEnumerator IECreateScreenShoot()
    {
        TurnWaterMark();

        yield return new WaitForEndOfFrame();

        Texture2D screenshoot = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        screenshoot.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenshoot.Apply();

        string nameFile = "Screenshoot_" + System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";

        // Save the screenshot to Gallery/Photos
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(
            screenshoot,
            "ARExcursion",
            nameFile,
            (success, path) =>
            {
                if (success)
                {
                    Debug.Log("Good! Path: " + path);
                    onCreateScreenshoot?.Invoke();
                }
                
            }
            );
        TurnWaterMark();


    }

    private void TurnWaterMark()
    {
        UI.SetActive(!UI.activeSelf);
        waterMark.SetActive(!waterMark.activeSelf);
    }
}
