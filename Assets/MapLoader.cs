using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoader : SingletonMonoBehaviour<MapLoader>
{
    public GameObject _map;
    public int[,] STAGE0MAP = {
        {0, 0, 0, 0, 1, 0, 0, 0},
        {1, 1, 1, 1, 1, 1, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0}
    };
    public int[,] STAGE1MAP = {
        {1, 0, 0, 0, 0, 1, 1, 0},
        {0, 0, 1, 0, 0, 0, 0, 0},
        {1, 0, 1, 1, 0, 1, 0, 1},
        {1, 0, 0, 1, 1, 1, 0, 0},
        {0, 0, 1, 1, 1, 0, 1, 0},
        {1, 0, 0, 1, 1, 1, 0, 0},
        {1, 0, 1, 0, 1, 0, 0, 1},
        {0, 1, 1, 1, 0, 0, 1, 0}
    };
    public int[,] STAGE2MAP = {
        {0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 0, 1, 0, 1, 1, 0},
        {1, 0, 9, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 1, 1, 0},
        {0, 0, 1, 0, 0, 8, 0, 0},
        {0, 1, 9, 1, 0, 1, 9, 0},
        {0, 0, 1, 0, 0, 0, 1, 0},
        {0, 0, 0, 1, 0, 0, 0, 0}
    };
    public int[,] STAGE3MAP = {
        {1, 0, 1, 0, 1, 1, 0, 1},
        {0, 9, 0, 0, 0, 0, 0, 9},
        {1, 0, 1, 0, 1, 1, 0, 1},
        {0, 1, 0, 0, 1, 9, 0, 0},
        {1, 0, 1, 0, 1, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0},
        {1, 0, 1, 0, 1, 0, 0, 1},
        {0, 0, 0, 1, 9, 1, 0, 0}
    };
    public int[,] STAGE4MAP = {
        {1, 1, 1, 0, 0, 0, 0, 1},
        {1, 0, 0, 1, 0, 1, 0, 1},
        {1, 0, 1, 0, 0, 0, 1, 1},
        {1, 0, 1, 9, 1, 0, 0, 0},
        {0, 1, 0, 1, 0, 1, 1, 0},
        {1, 9, 1, 9, 1, 0, 9, 0},
        {0, 1, 0, 1, 0, 0, 1, 0},
        {0, 0, 1, 9, 1, 0, 0, 0}
    };

    // Start is called before the first frame update
    void Awake()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        var MAP = STAGE1MAP;
        for (int i = 0; i < 8; i++) {
            for (int k = 0; k < 8; k++) {
                if (MAP[i, k] == 0) {
                    _map.transform.Find(i.ToString()).transform.Find(k.ToString()).gameObject.SetActive(false);
                }
            }
        }
    }
}
