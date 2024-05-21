using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    Button btn;


    private void OnEnable()
    {
        btn = GetComponent<Button>();
    }

    private void Start()
    {
        Sprite p = btn.spriteState.pressedSprite;

        Sprite s = btn.spriteState.selectedSprite;

        btn.onClick.AddListener(() =>
        {
            btn.GetComponent<Image>().sprite = p;
        });
    }


}
