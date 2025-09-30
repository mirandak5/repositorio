using UnityEngine;

public class mola : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forcaDoPulo = 15;
    public bool boost = false;
    
    private Animator animator;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      animator = GetComponent<Animator>();
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,forcaDoPulo), ForceMode2D.Impulse);
            boost = true;
            animator.SetTrigger("pulo");       
        }
        
        
    }
}
