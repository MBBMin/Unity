using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldSystem : MonoBehaviour
{
    public static float Star;//뽑기용 재화
    public static float Gold = 200;//재화
    private float TimeLeft = 1.0f;
    private float nextTime = 0.0f;

    

    public Text Text_Gold; //재화표기


    void Update()
    {
        if(Time.time > nextTime) //1초당 timeGold함수 호출
        {
            nextTime = Time.time + TimeLeft;
            timeGold();

        }
        
    }

    public void timeGold()
    {
        Gold += 5;//골드를 5씩 증가
        Text_Gold.text = Mathf.Round(Gold) + "G/100G";//UI에 표기
    }
    public bool spendGold(int cost) //유닛 생산시 빠져가나는 골드
    {
        if (cost > Gold)
            return false;
        else
        {
            Gold -= cost;
            Text_Gold.text = Mathf.Round(Gold) + "G/100G";//UI에 표기
            return true;
        }
    }
    public void EnemyGold(int cost) //적 처치시 추가되는 골드
    {
        Gold += cost;
        Text_Gold.text = Mathf.Round(Gold) + "G/100G";//UI에 표기
    }

  
}
