using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCSharp : MonoBehaviour
{
    //欄位
    //修飾詞 欄位類型 欄位名稱 (指定 值);
    //Header = 上頭字串標示
    //Range = 給出的範圍
    //Tooltip = 可顯示的字串提示

    [Header("分數")]
    [Range(0, 100)]
    public int Score = 70;        //int = 整數
     
    [Header("速度"), Range(0.0f, 10.0f) ]              
    public float Speed = 7.0f;    //float = 浮點數

    [Header("道具"), Tooltip("可以放紅色藥水和藍色藥水")]              
    public string Prop = "藥水";  //string = 字串

    [Header("任務")]
    public bool Misson = true;  //布林值 是或否


    //Unity 常用欄位類型
    public Vector2 v2 = new Vector2(7, 77);             //給予兩個新座標
    public Vector3 v3 = new Vector3(7, 7, 7);           //給予三個新座標
    public Vector3 Zero = Vector3.zero;

    public Color blue = Color.blue;                     //給予指定顏色
    public Color red = new Color(0.0f, 0.0f, 0.0f);     //給予指定RGB數值顏色

    //(非靜態)類別類型：可存放帶有這些類別的物件
    public AudioClip Sound;
    public Camera Cam;
    public Light Biglight;
    public Transform camPos;
    //GameObject 指的是Hierarchy 內所有物件
    public GameObject obj;
    //靜態類別不能宣告為欄位
    public Debug Hello;


    private void Start()
    {
        Debug.Log("Hello World");
    }

}
