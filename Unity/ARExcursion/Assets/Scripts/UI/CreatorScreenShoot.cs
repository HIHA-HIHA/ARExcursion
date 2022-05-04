using System;
using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class CreatorScreenShoot : MonoBehaviour
{

    public void CreateScreenshoot()
    {
        StartCoroutine(IECreateScreenShoot());
    }

    private IEnumerator IECreateScreenShoot()
    {

        yield return new WaitForEndOfFrame();

        Texture2D screenshoot = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        screenshoot.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenshoot.Apply();

        string nameFile = "Screenshoot_"+ System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss")+".png";

        // Save the screenshot to Gallery/Photos
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(
            screenshoot,
            "ARExcursion",
            nameFile,
            (success, path) => Debug.Log("Good!")
            );

       
    }

    private void Temp()
    {
        /*
       string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
       string filename = "Screenshoot" + timeStamp + ".png";
       string pathToSave = Application.persistentDataPath + "/" + filename;
       ScreenCapture.CaptureScreenshot(pathToSave);
       yield return new WaitForEndOfFrame();
       debugText.text = Application.persistentDataPath + "/" + filename;
       */
    }
}
