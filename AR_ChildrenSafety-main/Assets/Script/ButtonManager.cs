using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadScene(int sceneId) // 씬 전환
    {
        SceneManager.LoadScene(sceneId);
    }

    public void GameEnd() // 끝내기 버튼 누르면 게임종료
    {
        Debug.Log("end");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


}
