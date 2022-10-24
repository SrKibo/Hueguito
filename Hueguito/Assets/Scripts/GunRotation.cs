using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public float speed, interpRatio = 1;
    public Transform target;
    public SpriteRenderer spriteRenderer;
    public Vector3 zAxis = new Vector3(0,0,1), mousePosition;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //TODO:
        mousePosition = GetMousePosition();
        RotateGun();
        FlipGun(mousePosition);
        // pz.z = 0;
        // gameObject.transform.position = pz;
        // transform.RotateAround(transform.position, new Vector3(0,0,245), speed);
    }

    Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void RotateGun(){

        LookAt(mousePosition);
        
    }

    protected void LookAt(Vector2 point)
    {
        float angle = AngleBetweenPoints(point, transform.position);
        var targetRotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, interpRatio);
    }

    float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    void FlipGun(Vector3 vector)
    {
        if(transform.position.x - vector.x >= 0)
        {
            spriteRenderer.flipY = true;
        }
        else
        {
            spriteRenderer.flipY = false;
        }
    }

    void LateUpdate () {

        //  this.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -1);

        //  Vector2 dir = Input.mousePosition - Camera.main.WorldToScreenPoint (transform.position);
        //  float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
        //  transform.rotation = Quaternion.AngleAxis (angle, Vector3.forward);
    }
}
