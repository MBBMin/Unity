using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bt_Control : MonoBehaviour
{
    public void GameStart() //���� ��ŸƮ ��ư�� ������ ���
    {
        SceneManager.LoadScene("Stage");//Stage������ ��ȯ
    }

    public void ShopOpen() //�� ��ư�� ������ ���
    {
        SceneManager.LoadScene("Shop");//Shop������ ��ȯ
    }

    public void GameQuit()//���� ���� ��ư�� ������ ���
    {

        Application.Quit(); //������ �����
        Debug.Log("Button CLick");

    }

    public void Back()
    {
        SceneManager.LoadScene("Open");//Shop������ ��ȯ
    }

    public void HeroSetting()
    {
        SceneManager.LoadScene("HeroSetting");//����� ������ ��ȯ
    }

}
