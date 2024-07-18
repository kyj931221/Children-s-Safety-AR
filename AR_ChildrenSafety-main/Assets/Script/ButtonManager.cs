using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadScene(int sceneId) // �� ��ȯ
    {
        SceneManager.LoadScene(sceneId);
    }

    public void GameEnd() // ������ ��ư ������ ��������
    {
        Debug.Log("end");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


}
