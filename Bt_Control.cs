using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bt_Control : MonoBehaviour
{
    public void GameStart() //게임 스타트 버튼을 눌렀을 경우
    {
        SceneManager.LoadScene("Stage");//Stage씬으로 전환
    }

    public void ShopOpen() //숍 버튼을 눌렀을 경우
    {
        SceneManager.LoadScene("Shop");//Shop씬으로 전환
    }

    public void GameQuit()//게임 종료 버튼을 눌렀을 경우
    {

        Application.Quit(); //게임이 종료됨
        Debug.Log("Button CLick");

    }

    public void Back()
    {
        SceneManager.LoadScene("Open");//Shop씬으로 전환
    }

    public void HeroSetting()
    {
        SceneManager.LoadScene("HeroSetting");//히어로 덱으로 전환
    }

}
