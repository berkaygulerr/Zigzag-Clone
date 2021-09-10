using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] Tiles;
    public GameObject currentTile;

    private static TileManager instance;

    public static TileManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileManager>();
            }

            return TileManager.instance;
        }
    }

    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            SpawnTile();
        }
    }

    public void SpawnTile()
    {
        int randomIndex = Random.Range(0, 2);

        //zemin sağ tarafta çıkarsa, zemin sağ tarafta çıkarsa zeminin x ve z pozisyonunun farkı 5.25 veya 6.75 tir
        if (currentTile.transform.position.x - currentTile.transform.position.z == 5.25f || Mathf.Abs(currentTile.transform.position.x - currentTile.transform.position.z) == 6.75f)
        {
            currentTile = Instantiate(Tiles[0], currentTile.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
        }
        //zemin sol tarafta çıkarsa, zemin sağ tarafta çıkarsa zeminin x ve z pozisyonunun farkı -5.25 tir
        else if (currentTile.transform.position.x - currentTile.transform.position.z == -5.25f)
        {
            currentTile = Instantiate(Tiles[1], currentTile.transform.GetChild(0).GetChild(1).position, Quaternion.identity);
        }
        //zemin ortalarda çıkarsa rastgele çıksın
        else
        {
            currentTile = Instantiate(Tiles[randomIndex], currentTile.transform.GetChild(0).GetChild(randomIndex).position, Quaternion.identity);
        }
    }
}
