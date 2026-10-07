using System.Xml;
using UnityEngine;

public class Dron : MonoBehaviour
{
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float boost = speed;
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            boost = speed * 2;    
        }
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * boost);
        if (Input.GetKey(KeyCode.Space))
        {
        transform.Translate(Vector3.up * Time.deltaTime * boost);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.down * Time.deltaTime * boost); 
        }
    }
    
}
