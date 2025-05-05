using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    private int numero;
    public float velocidade = 5; 
    void Start()
    {
        numero = 27; 
    }

    
    void Update()
    {
        //debug.log(numero);
        //numero = numero = 1; 
        
        if (Input.GetKey(KeyCode.A))
            
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime,0,0);
        
        if (Input.GetKey(KeyCode.D))
            
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime,0,0);
        
        if (Input.GetKey(KeyCode.Space))
            
            gameObject.transform.position += new Vector3(0,velocidade * Time.deltaTime,0);
            
    }
    
}
