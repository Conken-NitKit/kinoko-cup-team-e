using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// リザルト画面の最終スコアの発表を管理するクラス
/// </summary>
public class ResultScore : MonoBehaviour
{
    /*[SerializeField]private WallAnimation wallAnimation;*/
    [SerializeField]public Text resultText;

    private void Start()
    {
       /*SetResult();*/ 
    }
    
    /*public void SetResult()
    {
        resultText.text = $"{wallAnimation.wallOpenedCount}回" ;
    }*/
}
