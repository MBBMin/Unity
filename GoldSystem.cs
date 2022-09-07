using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldSystem : MonoBehaviour
{
    public static float Star;//�̱�� ��ȭ
    public static float Gold = 200;//��ȭ
    private float TimeLeft = 1.0f;
    private float nextTime = 0.0f;

    

    public Text Text_Gold; //��ȭǥ��


    void Update()
    {
        if(Time.time > nextTime) //1�ʴ� timeGold�Լ� ȣ��
        {
            nextTime = Time.time + TimeLeft;
            timeGold();

        }
        
    }

    public void timeGold()
    {
        Gold += 5;//��带 5�� ����
        Text_Gold.text = Mathf.Round(Gold) + "G/100G";//UI�� ǥ��
    }
    public bool spendGold(int cost) //���� ����� ���������� ���
    {
        if (cost > Gold)
            return false;
        else
        {
            Gold -= cost;
            Text_Gold.text = Mathf.Round(Gold) + "G/100G";//UI�� ǥ��
            return true;
        }
    }
    public void EnemyGold(int cost) //�� óġ�� �߰��Ǵ� ���
    {
        Gold += cost;
        Text_Gold.text = Mathf.Round(Gold) + "G/100G";//UI�� ǥ��
    }

  
}
