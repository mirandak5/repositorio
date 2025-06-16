using UnityEngine;

public class atv : MonoBehaviour
{


void Start()
    {private int resposta;}

      

    


    



  
    void Update()
    {

        if (Input.GetKeyDown(KeyCode. A))
        {
            resposta = 1;
        }
        
        
        
        else if (Input.GetKeyDown(KeyCode.B))
        {
            resposta = 2; 
        }
        
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log();
        }
            
            
    }


}
