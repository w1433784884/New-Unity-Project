using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManaer : MonoBehaviour {

    public GameObject[] outWallArray;
    public GameObject[] floorArray;
    public GameObject[] wallArray;

    // Use this for initialization
    public int rows=10;
    public int cols=20;

    public int minCountWall = 20;
    public int maxCountWall = 35;

    private Transform mapHolder;
    private List<Vector2> positionstList = new List<Vector2>();

	void Start () {
        InitMap();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //初始地图
    private void InitMap(){

        mapHolder = new GameObject("Map").transform;

        for (int x = 0; x < cols; x++) {
            for (int y = 0; y < rows; y++) {
                if (x == 0 || y == 0 || x == cols -1|| y == rows-1 )
                {
                    int index = Random.Range(0, outWallArray.Length);
                   GameObject go= GameObject.Instantiate(outWallArray[index], new Vector3(x, y, 0), Quaternion.identity)as GameObject;
                    go.transform.SetParent(mapHolder);
                }
                if (x>=0||y>=0|| x <= cols - 1 || y <= rows - 1)
                { 
                    int index = Random.Range(0, floorArray.Length);
                   GameObject go= GameObject.Instantiate(floorArray[index], new Vector3(x, y, 0), Quaternion.identity)as GameObject;
                    go.transform.SetParent(mapHolder);
                }
            }
        }
        //障碍物 敌人 管理盒子
        positionstList.Clear();
        for(int x =2; x < cols - 2; x++)
        {
            for(int y = 2; y < rows - 2; y++)
            { positionstList.Add(new Vector2(x, y)); }
        }

        int wallCount = Random.Range(minCountWall, maxCountWall + 1);//个数
        for (int i = 0; i < wallCount; i++)
        {
            //位置
            int positionIndex = Random.Range(0, positionstList.Count);
            Vector2 pos = positionstList[positionIndex];
            positionstList.RemoveAt(positionIndex);

            int wallIndex = Random.Range(0, wallArray.Length);
            GameObject go = GameObject.Instantiate(wallArray[wallIndex], pos, Quaternion.identity) as GameObject;
            go.transform.SetParent(mapHolder);
        }


    }
    

}
