
using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{

    public float velocidade = 5;
    public float forcaDoPulo = 10;

    private bool noChao = false;

    private SpriteRenderer sprite;
    private Rigidbody2D rb;


    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

    }



    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
            sprite.flipX = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
            sprite.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            rb.AddForce(new Vector2(0, forcaDoPulo), ForceMode2D.Impulse);
        }

    }
    
    
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }

    }

    void OnCollisionExit2D(Collision2D colisao)
    {


        if (colisao.gameObject.CompareTag("Chao"))
        {

            noChao = false;

        }

    }
}  










