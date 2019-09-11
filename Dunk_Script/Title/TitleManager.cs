using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TitleManager : SingletonMonoBehaviour<TitleManager>
{
    private int Title_BestScore;//ベストスコア用
    private int Title_LastScore;//ラストスコア用

    [SerializeField]
    private TextMeshProUGUI BEST;//ベストスコアテキスト用

    [SerializeField]
    private TextMeshProUGUI LAST;//ラストスコアテキスト用

    public GameObject FeedPanel;//フェードアウトパネル用


    // Start is called before the first frame update
    void Start()
    {
        BEST = BEST.GetComponent<TextMeshProUGUI>();
        LAST = LAST.GetComponent<TextMeshProUGUI>();
        //画像を非表示
        FeedPanel.SetActive(false);

        //スコアのロード
        Title_BestScore = PlayerPrefs.GetInt("BESTSCORE");
        Title_LastScore = PlayerPrefs.GetInt("LASTSCORE");

        //テキストに反映
        BEST.text = "BEST:" + Title_BestScore;
        LAST.text = "LAST:" + Title_LastScore;
    }
}
