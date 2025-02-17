using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveFoward;
    public KeyCode moveBackward;
    public KeyCode rotateClockwise;
    public KeyCode roatateCounterClockwise;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
   
   
    public override void Start()
    {
       
        
    }

    // Update is called once per frame
   public override void Update()
    {
        
        if (Input.GetKey(moveFoward)){
            // move our pawn foward
          
           pawn.moveFoward();
        }
        if (Input.GetKey(moveBackward)){
            // move pawn Backward
           pawn.moveBackward();
        }
        if (Input.GetKey(rotateClockwise)){
            pawn.rotateClockwise();
        }
        if (Input.GetKey(roatateCounterClockwise)){
            pawn.roatateCounterClockwise();
        }
    }
}
