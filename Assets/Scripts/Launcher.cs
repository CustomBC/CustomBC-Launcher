using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    // Размер окна лаунчера
    private void Update()
    {
        Screen.SetResolution(Screen.width, Screen.height, fullscreen: false);
    }

    // Отсек выбора версий

    public void Launch_1_6_3()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.6.3 Release/CustomBC.exe";

        // Запуск CustomBC 1.5
        transform.Find("Launch 1.6.3");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 1.6.3 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_5()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.5 Release/CustomBC.exe";

        // Запуск CustomBC 1.5
        transform.Find("Launch 1.5");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 1.5 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_4()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.4 Release/CustomBC.exe";

        // Запуск CustomBC 1.4
        transform.Find("Launch 1.4");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 1.4 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_3()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.3/CustomBC.exe";

        // Запуск CustomBC 1.4
        transform.Find("Launch 1.3");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 1.3 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_2()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.2/CustomBC.exe";

        // Запуск CustomBC 1.4
        transform.Find("Launch 1.2");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 1.2 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_1()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.1/CustomBC.exe";

        // Запуск CustomBC 1.4
        transform.Find("Launch 1.1");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 1.1 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_0()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.0/CustomBC.exe";

        // Запуск CustomBC 1.4
        transform.Find("Launch 1.0");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 1.0 Release...");
            Process.Start(path);
        }
    }

    public void Launch_0_1_Beta()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Beta/CustomBC 0.1 Beta/BuilderCraft.exe";

        // Запуск CustomBC 0.1 Beta
        transform.Find("Launch 0.1 Beta");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 0.1 Beta...");
            Process.Start(path);
        }
    }

    public void Launch_0_2_Beta()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Beta/CustomBC 0.2 Beta/BuilderCraft.exe";

        // Запуск CustomBC 0.1 Beta
        transform.Find("Launch 0.2 Beta");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 0.2 Beta...");
            Process.Start(path);
        }
    }

    public void Launch_0_3Beta()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Beta/CustomBC 0.3 Beta/BuilderCraft.exe";

        // Запуск CustomBC 0.1 Beta
        transform.Find("Launch 0.3 Beta");
        {
            UnityEngine.Debug.Log("Запускается: CustomBC 0.3 Beta...");
            Process.Start(path);
        }
    }

    public void Launch_1_0_Legacy()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Legacy/BuilderCraft 2.3.7 Mod by Konnivalys 1.0/BuilderCraft.exe";

        // Запуск BuilderCraft 2.3.7 Mod by: Konnivalys 1.0 
        transform.Find("Launch 1.0 Legacy");
        {
            UnityEngine.Debug.Log("Запускается: BuilderCraft 2.3.7 Mod by Konnivalys 1.0...");
            Process.Start(path);
        }
    }

    public void Launch_2_0_Legacy()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Legacy/BuilderCraft 2.3.7 Mod by Konnivalys 2.0/BuilderCraft.exe";

        // Запуск BuilderCraft 2.3.7 Mod by: Konnivalys 1.0 
        transform.Find("Launch 2.0 Legacy");
        {
            UnityEngine.Debug.Log("Запускается: BuilderCraft 2.3.7 Mod by Konnivalys 2.0...");
            Process.Start(path);
        }
    }

    public void Launch_3_0_Legacy()
    {
        // Поиск исполняемого файла
        string path = Application.dataPath + "/../CustomBC Builds/Legacy/BuilderCraft 2.3.7 Mod by Konnivalys 3.0/BuilderCraft.exe";

        // Запуск BuilderCraft 2.3.7 Mod by: Konnivalys 1.0 
        transform.Find("Launch 3.0 Legacy");
        {
            UnityEngine.Debug.Log("Запускается: BuilderCraft 2.3.7 Mod by Konnivalys 3.0...");
            Process.Start(path);
        }
    }

    // Отсек меню лаунчера

    // Открывает сайт CustomBC
    public void SiteOpen()
    {
        UnityEngine.Debug.Log("Открытие сайта CustomBC...");
        Application.OpenURL("https://custombc.github.io/custombc.mod/");
    }

    // Открывает ВК-Группу CustomBC
    public void VKOpen()
    {
        UnityEngine.Debug.Log("Открытие ВК-Группы CustomBC...");
        Application.OpenURL("https://vk.com/custombc");
    }

    public void YouTubeOpen()
    {
        UnityEngine.Debug.Log("Открытие Ютуб-канала CustomBC...");
        Application.OpenURL("https://www.youtube.com/@CustomBCmod");
    }

    // Выход
    public void LauncherQuit()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Лаунчер закрыт");
    }
}
