using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    // ������ ���� ��������
    private void Update()
    {
        Screen.SetResolution(Screen.width, Screen.height, fullscreen: false);
    }

    // ����� ������ ������

    public void Launch_1_6_3()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.6.3 Release/CustomBC.exe";

        // ������ CustomBC 1.5
        transform.Find("Launch 1.6.3");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 1.6.3 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_5()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.5 Release/CustomBC.exe";

        // ������ CustomBC 1.5
        transform.Find("Launch 1.5");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 1.5 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_4()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.4 Release/CustomBC.exe";

        // ������ CustomBC 1.4
        transform.Find("Launch 1.4");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 1.4 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_3()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.3/CustomBC.exe";

        // ������ CustomBC 1.4
        transform.Find("Launch 1.3");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 1.3 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_2()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.2/CustomBC.exe";

        // ������ CustomBC 1.4
        transform.Find("Launch 1.2");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 1.2 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_1()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.1/CustomBC.exe";

        // ������ CustomBC 1.4
        transform.Find("Launch 1.1");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 1.1 Release...");
            Process.Start(path);
        }
    }

    public void Launch_1_0()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Release/CustomBC 1.0/CustomBC.exe";

        // ������ CustomBC 1.4
        transform.Find("Launch 1.0");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 1.0 Release...");
            Process.Start(path);
        }
    }

    public void Launch_0_1_Beta()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Beta/CustomBC 0.1 Beta/BuilderCraft.exe";

        // ������ CustomBC 0.1 Beta
        transform.Find("Launch 0.1 Beta");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 0.1 Beta...");
            Process.Start(path);
        }
    }

    public void Launch_0_2_Beta()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Beta/CustomBC 0.2 Beta/BuilderCraft.exe";

        // ������ CustomBC 0.1 Beta
        transform.Find("Launch 0.2 Beta");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 0.2 Beta...");
            Process.Start(path);
        }
    }

    public void Launch_0_3Beta()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Beta/CustomBC 0.3 Beta/BuilderCraft.exe";

        // ������ CustomBC 0.1 Beta
        transform.Find("Launch 0.3 Beta");
        {
            UnityEngine.Debug.Log("�����������: CustomBC 0.3 Beta...");
            Process.Start(path);
        }
    }

    public void Launch_1_0_Legacy()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Legacy/BuilderCraft 2.3.7 Mod by Konnivalys 1.0/BuilderCraft.exe";

        // ������ BuilderCraft 2.3.7 Mod by: Konnivalys 1.0 
        transform.Find("Launch 1.0 Legacy");
        {
            UnityEngine.Debug.Log("�����������: BuilderCraft 2.3.7 Mod by Konnivalys 1.0...");
            Process.Start(path);
        }
    }

    public void Launch_2_0_Legacy()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Legacy/BuilderCraft 2.3.7 Mod by Konnivalys 2.0/BuilderCraft.exe";

        // ������ BuilderCraft 2.3.7 Mod by: Konnivalys 1.0 
        transform.Find("Launch 2.0 Legacy");
        {
            UnityEngine.Debug.Log("�����������: BuilderCraft 2.3.7 Mod by Konnivalys 2.0...");
            Process.Start(path);
        }
    }

    public void Launch_3_0_Legacy()
    {
        // ����� ������������ �����
        string path = Application.dataPath + "/../CustomBC Builds/Legacy/BuilderCraft 2.3.7 Mod by Konnivalys 3.0/BuilderCraft.exe";

        // ������ BuilderCraft 2.3.7 Mod by: Konnivalys 1.0 
        transform.Find("Launch 3.0 Legacy");
        {
            UnityEngine.Debug.Log("�����������: BuilderCraft 2.3.7 Mod by Konnivalys 3.0...");
            Process.Start(path);
        }
    }

    // ����� ���� ��������

    // ��������� ���� CustomBC
    public void SiteOpen()
    {
        UnityEngine.Debug.Log("�������� ����� CustomBC...");
        Application.OpenURL("https://custombc.github.io/custombc.mod/");
    }

    // ��������� ��-������ CustomBC
    public void VKOpen()
    {
        UnityEngine.Debug.Log("�������� ��-������ CustomBC...");
        Application.OpenURL("https://vk.com/custombc");
    }

    public void YouTubeOpen()
    {
        UnityEngine.Debug.Log("�������� ����-������ CustomBC...");
        Application.OpenURL("https://www.youtube.com/@CustomBCmod");
    }

    // �����
    public void LauncherQuit()
    {
        Application.Quit();
        UnityEngine.Debug.Log("������� ������");
    }
}
