using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(1600, 1).SetLoops(-1, LoopType.Yoyo);
        // �տ� ��ġ���� �˾Ƽ� �����ϱ�
        //-1�� ���� ����
        // Ÿ���� ���(�Դٰ����ϴ°�)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
