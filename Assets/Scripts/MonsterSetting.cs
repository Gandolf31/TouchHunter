using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonsterSetting : MonoBehaviour
{
    public GameObject particle;
    public float Damage = 7f;
    public void MonsterTouched()
    {
        HealthSystem.Instance.TakeDamage(Damage);
        Debug.Log("입구");
        Create();
    }
    void Create()
    {
        Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mPosition.z = -100;
        Instantiate(particle, mPosition, Quaternion.identity);
    }
}
