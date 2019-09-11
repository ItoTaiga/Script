using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkinButton : MonoBehaviour
{
    [SerializeField]
    private int SkinNumber =0;

    public void OnClick()
    {
        PlayerPrefs.SetInt("SKIN", SkinNumber);
        PlayerPrefs.Save();
        SkinManager.Instance.UpdateSkin();
    }
}
