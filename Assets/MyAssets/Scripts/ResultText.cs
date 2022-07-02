/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// リザルト画面の最終スコアの発表を管理するクラス
/// </summary>
public class ResultText : MonoBehaviour
{
    [SerializeField]private Player player;
    [SerializeField]public Text resultText;

    private void Start()
    {
       SetResult(); 
    }
    
    public void SetResult()
    {
        resultText.text = "スコア " + $"{player.scorecount}" ;
    }
}
*/