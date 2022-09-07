using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button_Unit : MonoBehaviour
{

    public bool isDelay;
    public float delayTime;//�����̽ð�

    GameObject gold; //��� ������Ʈ
    public GameObject prefab1; //���� ������
    public GameObject prefab2; //�䳢 ������
    public GameObject prefab3; //�ڳ��� ������
    public GameObject prefab4; //�� ������
    public GameObject prefab5; //Ļ�ŷ� ������

    void Start()
    {
        gold = GameObject.Find("GoldSystem"); //���ý��� ��ġ
    }

    
    public void FirstUnit()
    {
        if (!isDelay)
        {
            if (gold.GetComponent<GoldSystem>().spendGold(10) == true)
            {
                Instantiate(prefab1);
                Debug.Log("Mouse Click");
                isDelay = true;
            }
            
            StartCoroutine(CountDelay());

        }
        else
        {
            Debug.Log("Delay");
        }
        
    }
  
    public void SecondUnit()
    {
        if (!isDelay)
        {
            if (gold.GetComponent<GoldSystem>().spendGold(25) == true)
            {
                Instantiate(prefab2);
                Debug.Log("Bunny Click");
            }
            isDelay = true;
            StartCoroutine(CountDelay());

        }
        else
        {
            Debug.Log("Delay");
        }
      
    }
    public void ThirdUnit()
    {
        if (!isDelay)
        {
            if (gold.GetComponent<GoldSystem>().spendGold(25) == true)
            {
                Instantiate(prefab3);
                Debug.Log("Elephant Click");
            }
            isDelay = true;
            StartCoroutine(CountDelay());

        }
        else
        {
            Debug.Log("Delay");
        }
       
    }
    public void FourthUnit()
    {
        if (!isDelay)
        {
            if (gold.GetComponent<GoldSystem>().spendGold(40) == true)
            {
                Instantiate(prefab4);
                Debug.Log("Chick Click");
            }
            isDelay = true;
            StartCoroutine(CountDelay());

        }
        else
        {
            Debug.Log("Delay");
        }
        
    }
    public void FifthUnit()
    {
        if (!isDelay)
        {
            if (gold.GetComponent<GoldSystem>().spendGold(60) == true)
            {
                Instantiate(prefab5);
                Debug.Log("Kangaroo Click");
            }
            isDelay = true;
            StartCoroutine(CountDelay());

        }
        else
        {
            Debug.Log("Delay");
        }

       
    }


    IEnumerator CountDelay()
    {
        yield return new WaitForSeconds(delayTime);
        isDelay = false;
    }
}
