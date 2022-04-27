using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.AI;
public class Title_Button : MonoBehaviour
{
    public void PlayClick()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void ExitClick()
    { // 유니티 에디터 내부에서도 종료 기능을 하도록 코드 추가
#if UNITY_EDITOR    
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif
    }
}