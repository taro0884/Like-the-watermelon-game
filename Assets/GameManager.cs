using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject fruit1;
    public GameObject fruit2;
    public GameObject fruit3;
    public GameObject fruit4;
    public GameObject fruit5;
    public GameObject fruit6;
    public GameObject fruit7;

    [SerializeField] GameObject[] fruits;

    private GameObject keepfruit;

    public static int score;
    public Text score_object;

    public static int[] next = new int[10];   // NEXT
    public int[] res = new int[10];
    int tonextCount = 0;        // nextToNext()実行回数

    Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        nextDecide();
        //keepfruit = fruits[next[0]];
    }

    // Update is called once per frame
    void Update()
    {
        //keepfruit = fruits[next[0]];
        mousePos = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(keepfruit, Camera.main.ScreenToWorldPoint(mousePos), Quaternion.identity);

            //for (int k = 0; k < next.Length; k++)
            //{
            //    Debug.Log(next[k]);
            //}
            
            //Debug.Log(next[0]+""+next[1] + "" + next[2] + "" + next[3] + "" + next[4] + "←最後" + next[5] + "" + next[6] + "" + next[7] + "" + next[8] + "" + next[9]+"←最後");

            nextToNext();
            //nextDecide();
            //for (int i = 0; i < next.Length; i++) {
            //    Debug.Log(next[i]);
            // }
        }

        Text score_text = score_object.GetComponent<Text>();
        score_text.text = score.ToString();

    }

    void nextDecide()
    {
        int[] val = { 1, 2, 3, 4, 5};

        int loop = next.Length / 5; // ループする回数

        for (int i = 0; i < loop; i++)
        {
            // 各巡最初のNEXTが存在しない時に処理を行う
            if (next[i * 5] == 0)
            {
                // 配列valをシャッフルして配列resに格納
                res = val.OrderBy(i => Guid.NewGuid()).ToArray();

                // NEXTに適用
                for (int j = 0; j < 5; j++)
                {
                    next[i * 5 + j] = res[j];
                }
            }
        }
    }

    void nextToNext()
    {
        // nextを次に進める
        for (int i = 0; i < next.Length - 1; i++)
        {
            next[i] = next[i + 1];
        }
        // ループ処理が終わったらnextの最後尾を0にする
        next[next.Length - 1] = 0;

        tonextCount++;

        if (tonextCount == 5)
        {
            // 5回実行する度にnextdecide()を実行
            nextDecide();
            tonextCount = 0;
        }
    }

    void keepfruitselect()
    {

    }
}
