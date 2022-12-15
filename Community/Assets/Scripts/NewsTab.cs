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
    private Vector2 imgOriginalPos;

    [SerializeField]
    private float bottomMargin;


    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => OnBtnClicked());

        img = GetComponent<Image>();
        infoText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        imgOriginalPos = img.rectTransform.sizeDelta;
    }
    private void OnBtnClicked()
    {
        if (!isClicked)
        {
            float yPos = imgOriginalPos.y;
            yPos += infoText.rectTransform.sizeDelta.y + bottomMargin;

            img.rectTransform.DOSizeDelta(new Vector2(imgOriginalPos.x, yPos), 0.4f);
        }
        else
        {
            img.rectTransform.DOSizeDelta(imgOriginalPos, 0.4f);

        }

        isClicked = !isClicked;
    }
    private void OnDestroy()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
    }
}
