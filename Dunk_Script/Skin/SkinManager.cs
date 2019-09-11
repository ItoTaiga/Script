using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : SingletonMonoBehaviour<SkinManager>
{
    [SerializeField]
    private Sprite[] PlayerSkin;//プレイヤーのスキン用

    [SerializeField]
    private GameObject Player;//プレイヤープレハブ用

    private SpriteRenderer PlayerSprite;//プレイヤー画像用

    private int Player_Skin;//プレイヤープレファス用


    public void UpdateSkin()
    {
        //スキンの数字をロード
        Player_Skin = PlayerPrefs.GetInt("SKIN");
        //プレイヤーのスプライトを取得
        PlayerSprite = Player.GetComponent<SpriteRenderer>();
        //プレイヤーの画像を変更
        PlayerSprite.sprite = PlayerSkin[Player_Skin];
    }
}
