using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureManager : MonoBehaviour
{
    public Picture PicturePrefab;
    public Transform PicSpawnPosition;
    public Vector2 StartPosition = new Vector2(-35f, 50f);

    [HideInInspector]
    public List<Picture> PictureList;

    private Vector2 _offset = new Vector2(35f, 42f);
    void Start()
    {
        SpawnPictureMesh(4, 3, StartPosition, _offset, false);
        MovePicture(4, 3, StartPosition, _offset);
    }

    void Update()
    {
        
    }

    private void SpawnPictureMesh(int columns, int rows, Vector2 Pos, Vector2 offset, bool scaleDown)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                var tempPicture = (Picture) Instantiate(PicturePrefab, PicSpawnPosition.position, PicSpawnPosition.transform.rotation);
                tempPicture.name = tempPicture.name + "r" + row + "c" + col;
                PictureList.Add(tempPicture);
            }
        }
    }

    private void MovePicture(int columns, int rows, Vector2 pos, Vector2 offset)
    {
        var index = 0;
        for (int row = 0; row < rows; row++)
        {
            for (var col = 0; col < columns; col++)
            {
                var targetPosition = new Vector3((pos.x + (offset.x * row)), (pos.y - (offset.y * col)), 90f);
                StartCoroutine(MoveToPosition(targetPosition, PictureList[index]));
                index++;
            }
        }
    }

    private IEnumerator MoveToPosition(Vector3 target, Picture obj)
    {
        var randomDis = 200;

        while (obj.transform.position != target)
        {
            obj.transform.position = Vector3.MoveTowards(obj.transform.position, target, randomDis * Time.deltaTime);
            yield return 0;
        }
    }

}
