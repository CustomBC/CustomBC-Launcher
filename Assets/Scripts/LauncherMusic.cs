using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LauncherMusic : MonoBehaviour
{
    public Sprite musicOn;
    public Sprite musicOff;

    public bool isOn;

    public Image musicButton;

    public AudioSource audioSource;

    void Start()
    {
        isOn = true;
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("music") == 0)
        {
            musicButton.GetComponent<Image>().sprite = musicOn;
            audioSource.enabled = true;
            isOn = true;
        }

        else if (PlayerPrefs.GetInt("music") == 1)
        {
            musicButton.GetComponent<Image>().sprite = musicOff;
            audioSource.enabled = false;
            isOn = false;
        }
    }

    public void OffMusic()
    {
        if (!isOn)
        {
            PlayerPrefs.SetInt("music", 0);
        }

        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);
        }
    }
}
