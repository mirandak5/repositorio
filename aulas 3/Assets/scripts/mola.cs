using UnityEngine;

public class mola : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forcaDoPulo = 15;
    public bool boost = false;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Mola"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,forcaDoPulo), ForceMode2D.Impulse);
            boost = true;
                
        }
    }
}
