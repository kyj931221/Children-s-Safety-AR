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
            Debug.LogWarning("씬에 두개 이상의 매니저 존재");
            Destroy(gameObject);
        }
    }

    void Start()
    {
        text1.DOText("1. 카드를 준비해주세요.\r\n\r\n2. 카메라 화면에 카드를 비춰주세요.\r\n\r\n3. 화면에 나오는 애니메이션을 보며 \r\n재미있게 교통안전을 배워보아요!", 8f); // 타자치는 효과

        //textFade.DOFade(1, 2); // 2초동안 페이드인(페이드아웃은 앞에를 0으로 바꾸기) 



    }

}
