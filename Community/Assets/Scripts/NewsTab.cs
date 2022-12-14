using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class NewsTab : MonoBehaviour
{
    private TextMeshProUGUI infoText;
    private Image img;

    private bool isClicked;

    [SerializeField]
    private float bottomMargin;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => OnBtnClicked());

        img = GetComponent<Image>();
        infoText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }
    private void OnBtnClicked()
    {
        if (!isClicked)
        {
            float yPos = img.rectTransform.sizeDelta.y;
            yPos += infoText.rectTransform.sizeDelta.y + bottomMargin;

            img.rectTransform.DOSizeDelta(new Vector2(img.rectTransform.sizeDelta.x, yPos), 0.4f);
        }
        else
        {

        }

        isClicked = !isClicked;
    }

}
