using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public float speed;
    public Transform target;
    
    public Vector3 zAxis = new Vector3(0,0,1), mousePosition;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //TODO:
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // pz.z = 0;
        // gameObject.transform.position = pz;
        // transform.RotateAround(transform.position, new Vector3(0,0,245), speed);
        RotationTest();
    }

    void GetMouseDirection(){
        //get mouse screen position
        

    }

    void RotationTest(){
        //todo
    }

    void LateUpdate () {

        //  this.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -1);

        //  Vector2 dir = Input.mousePosition - Camera.main.WorldToScreenPoint (transform.position);
        //  float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
        //  transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
    }
}
