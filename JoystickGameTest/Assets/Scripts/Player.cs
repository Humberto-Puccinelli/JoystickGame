using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    
    public FixedJoystick joystick;
    public float speed;
    
    float Hinput, Vinput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Hinput = joystick.Horizontal * speed;
        Vinput = joystick.Vertical * speed;
        
        transform.Translate(Hinput, Vinput, 0);
    }
}
