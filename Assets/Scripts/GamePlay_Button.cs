using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.AI;

public class GamePlay_Button : MonoBehaviour
{
    public void BackClick()
    {
        SceneManager.LoadScene("Scene_Title");
    }
    public void Monster_1()
    {
        SceneManager.LoadScene("GJagras");
    }
    public void Monster_2()
    {
        SceneManager.LoadScene("Kulu");
    }
    public void Monster_3()
    {
        SceneManager.LoadScene("Pukei");
    }
    public void Monster_4()
    {
        SceneManager.LoadScene("Barroth");
    }
    public void Monster_5()
    {
        SceneManager.LoadScene("Jyura");
    }
    public void Monster_6()
    {
        SceneManager.LoadScene("Tobi");
    }
    public void Monster_7()
    {
        SceneManager.LoadScene("Anja");
    }
    public void Enchant()
    {
        SceneManager.LoadScene("Weapon");
    }
    public void Inventory()
    {
        SceneManager.LoadScene("Inven");
    }
}
