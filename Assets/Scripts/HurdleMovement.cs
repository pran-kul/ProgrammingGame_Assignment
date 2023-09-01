using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleMovement : MonoBehaviour
{
    bool scaleInc, xInc;
    public float xSpeed, scaleSpeed;
    Vector3 newScale;
    // Start is called before the first frame update
    void Start()
    {
        scaleInc = xInc = true;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeTransform();
    }
    public void ChangeTransform()
    {
        if(gameObject.transform.lossyScale.x > 2 )
        {
            scaleInc = false;
        }
        else if(gameObject.transform.lossyScale.x < 0.5)
        {
            scaleInc = true;
        }

        if (gameObject.transform.localPosition.x > 0.4)
        {
            xInc = false;
        }
        else if (gameObject.transform.localPosition.x < -0.4)
        {
            xInc = true;
        }



        if (scaleInc)
        {
            newScale = new Vector3 (gameObject.transform.localScale.x * scaleSpeed, 0, gameObject.transform.localScale.z * scaleSpeed);
            gameObject.transform.localScale = gameObject.transform.localScale +newScale;
        }
        else
        {
            newScale = new Vector3(gameObject.transform.localScale.x * -scaleSpeed, 0 , gameObject.transform.localScale.z * -scaleSpeed);
            gameObject.transform.localScale = gameObject.transform.localScale + newScale;
        }
    

        if(xInc)
        {
            gameObject.transform.localPosition = gameObject.transform.localPosition + new Vector3(xSpeed, 0, 0);
        }
        else
        {
            gameObject.transform.localPosition = gameObject.transform.localPosition - new Vector3(xSpeed, 0, 0);
        }
       
        
    }
}
