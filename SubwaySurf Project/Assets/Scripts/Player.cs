using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float speed = 15;
    Vector3 MovePosRight = new Vector3(4, 0, 0);
    Vector3 MovePosLeft = new Vector3(-4, 0, 0);
    private float jumpForce = 100f;
    Vector3 velocity = new Vector3(0, 3, 0);
    private bool touchFloor = false;
    public Animator anim;
    public int DimondPickedUp;
    private int Dimonds;
    public GameObject loseMenu;
    public TextMeshProUGUI dimondsText;
    private float lengthvector = 0.6f;

    void Start()
    {
        Dimonds = PlayerPrefs.GetInt("Dimonds" , 0);
    }

    
    void Update()
    {
        dimondsText.text = DimondPickedUp.ToString();

        if(Input.GetKeyDown(KeyCode.Space) && touchFloor ==true)
        {
            rb.AddForce(velocity * jumpForce);
            anim.SetTrigger("jump");
            touchFloor = false;
        }

        transform.position += new Vector3(0,0,lengthvector) * speed * Time.deltaTime;
        


        if(Input.GetKeyDown(KeyCode.D) && transform.position.x <4)
        {
            transform.position = transform.position + MovePosRight;
       
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x> -4)
        {
            transform.position = transform.position + MovePosLeft;
       
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(0, -1, 0) * jumpForce);
        }
        else
            return;
    }

    void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "Floors")
        {
            touchFloor = true;
        }
       if(collision.collider.name == "Obtacle(Clone)")
        {
            loseMenu.SetActive(true);
            Time.timeScale = 0f;
            Destroy(collision.collider);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.name == "PickUp(Clone)")
        {
            Destroy(collider.gameObject);
            DimondPickedUp++;
            PlayerPrefs.SetInt("Dimonds", DimondPickedUp + Dimonds);
            FindObjectOfType<AudioManager>().play("PickUp");

        }
    }
}
