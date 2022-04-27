using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoGamePlay : MonoBehaviour
{
    public void GoBack () {
        SceneManager.LoadScene("GamePlay");
    }
}
