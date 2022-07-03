using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

/// <summary>
/// リザルト画面のタイトル画面に戻るボタンの動きを管理するクラス
/// </summary>
public class GameOverButton : MonoBehaviour
{

    /// <summary>
    /// ボタンがクリックされたときボタンが一瞬拡大する
    /// </summary>
    public void OnClicked()
    {
        Time.timeScale = 1f;
        transform.DOScale(1.1f,0.5f).SetEase(Ease.OutElastic)
        .OnComplete(() => transform.DOScale(1f,0.5f)).OnComplete(() => SceneManager.LoadScene("Satou"));    
    }
    
}