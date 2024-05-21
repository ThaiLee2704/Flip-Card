using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    [SerializeField] int x;
    int[] mang;

    GridLayoutGroup gr;
    [SerializeField] List<Sprite> mangList;
    [SerializeField] GameObject _imgSprite;

    private void Start()
    {
        mang = new int[x];
        gr = GetComponent<GridLayoutGroup>();
        StartCoroutine(waiting());
    }

    IEnumerator waiting()
    {

        for (int i = 0; i < mang.Length; i++)
        {
            yield return new WaitForSeconds(0.1f);
            Instantiate<GameObject>(_imgSprite.gameObject, this.transform.position, Quaternion.identity, gr.transform);
        }
    }
}
