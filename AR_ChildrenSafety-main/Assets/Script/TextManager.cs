using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;

    public Text text1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("���� �ΰ� �̻��� �Ŵ��� ����");
            Destroy(gameObject);
        }
    }

    void Start()
    {
        text1.DOText("1. ī�带 �غ����ּ���.\r\n\r\n2. ī�޶� ȭ�鿡 ī�带 �����ּ���.\r\n\r\n3. ȭ�鿡 ������ �ִϸ��̼��� ���� \r\n����ְ� ��������� ������ƿ�!", 8f); // Ÿ��ġ�� ȿ��

        //textFade.DOFade(1, 2); // 2�ʵ��� ���̵���(���̵�ƿ��� �տ��� 0���� �ٲٱ�) 



    }

}
