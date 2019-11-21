using UnityEngine;

public class Lady : MonoBehaviour
{

    private Animator Ani;       //動畫元件
    private Rigidbody Rig;      //剛體元件

    [Header("走路速度"), Range(0f, 100f)]
    public float Speed = 1.5f;
    [Header("旋轉速度"), Range(0f, 100f)]
    public float turn = 1.5f;


    private void Start()
    {
        Ani = GetComponent<Animator>();     //動畫元件欄位 = 取得元件<泛型>();
        Rig = GetComponent<Rigidbody>();   
    }

    [Header("動畫控制:參數名稱")]
    public string ParWalk = "towalk";
    public string ParAttack = "toattack";
    public string ParHunt = "tohunt";
    public string ParSleep = "tosleep";
    public string ParJump = "tojump";

    // 定義方法
    // 修飾詞 傳回類型 方法名稱 (參數) { 敘述 }
    // void 無回傳

    private void Update()
    {
        Turn();
    }

    private void FixedUpdate()
    {
        Walk();
        Attack();
        Jump();
    }

    /// <summary>
    /// 走路左右控制
    /// </summary>
    private void Walk()
    {
        Ani.SetBool(ParWalk, Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0);
        //Rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * Speed);
        //Rig.AddForce(0, 0, Input.GetAxisRaw("Vertical") * Speed);
        Rig.AddForce(transform.forward * Input.GetAxisRaw("Vertical") * Speed + transform.right * Input.GetAxisRaw("Horizontal") * Speed);
    }

    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {
        float x = Input.GetAxis("Mouse X");
        transform.Rotate(0, x * turn * Time.deltaTime, 0);
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        Ani.SetTrigger(ParAttack);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Ani.SetTrigger(ParJump);
    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hurt()
    {
        Ani.SetTrigger(ParHunt);
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Sleep()
    {
        Ani.SetBool(ParSleep, true);
    }
}
