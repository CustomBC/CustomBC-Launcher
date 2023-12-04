using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class LauncherUpdater : MonoBehaviour
{
    public Launcher launcher;

    public GameObject test;

    public GameObject Update;

    WebClient client = new WebClient();

    public void UpdateLoad()
    {
        if (client.DownloadString("https://pastebin.com/0mtzdMed").Contains("1.1.0"))
        {
            test.SetActive(false);
        }
        else
        {
            Update.SetActive(false);
        }
    }
}
