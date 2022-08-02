using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpforce = 15f;
    [SerializeField] private int hp;
    public GameObject punchcoll;
    public Text HPtxt;
    public Text ENtxt;

    private Rigidbody2D rb;
    
    public Transform groundCheck;
    public LayerMask groundlayer;
    bool isGround;


    public void Start(){

    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Walk();
        Stats();
        Punch();
    }

    private void Run(){
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
    private void Walk(){
        if(Input.GetButton("Horizontal")){
            Run();
        }
        if(Input.GetButton("Jump")){
            if(isGround){;
                Jump();
            }
        }
        if(transform.position.y < -10){
            transform.position = new Vector3(-13,1,0);
        }
    }

    private void Jump(){
        rb.velocity = new Vector3(rb.velocity.x, jumpforce);
    }

    private void FixedUpdate(){
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f,groundlayer);
    }

    private void Stats(){
        HPtxt.text = hp.ToString()+"/10";
        if(Input.GetKeyDown("k")){
            hp -= 1;
            HPtxt.text = hp.ToString()+"/10";
        }
        else if(hp == -1)hp = 0;
    }
    public void Punch(){
        if(Input.GetKeyDown("p")){
            punchcoll.transform.position = new Vector2(transform.position.x + 0.145f,transform.position.y-0.01f);
            punchcoll.transform.position = new Vector2(transform.position.x,transform.position.y);
            
        }
    }
}
