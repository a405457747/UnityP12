using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MyMoney : MonoBehaviour
{
    [SerializeField] private Text moneyText; // 绑定到UI的Text组件

    private int money = 0;           // 真实金钱
    private int oldMoney = 0;        // 显示用金钱
    private Tween currentTween = null;

    // 按钮点击增加金钱
    public void OnAddMoneyButtonClicked()
    {
        money += 100; // 增加真实金钱

        // 如果有动画在运行，先杀死
        if (currentTween != null && currentTween.IsActive())
        {
            currentTween.Kill();
        }

        // 从 oldMoney 平滑过渡到 money
        currentTween = DOTween.To(
            () => oldMoney,
            x => {
                oldMoney = x;
                UpdateText(); // 更新UI
            },
            money,
            2f
        ).SetEase(Ease.OutQuad);
    }

    // 更新Text组件显示
    private void UpdateText()
    {
        moneyText.text = Mathf.RoundToInt(oldMoney).ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnAddMoneyButtonClicked();
        }
    }
}
