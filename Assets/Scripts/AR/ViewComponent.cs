using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewComponent : MonoBehaviour
{
    public bool CanRotate;
    public bool CanScale;
    public float minScale;
    public float MaxScale;

    float TouchBegan;
    float TouchMoved;
    float ScaleSize;
    void Update()
    {
        if(CanRotate)
        {
            if(Input.touchCount==1)
            {
                Touch touch = Input.GetTouch(0);
                if(touch.phase==TouchPhase.Began)
                {
                    TouchBegan = touch.position.x;
                }
                if(touch.phase==TouchPhase.Moved)
                {
                    TouchMoved = touch.position.x;
                    if (TouchMoved != TouchBegan)
                        transform.Rotate(transform.up, (TouchMoved-TouchBegan)* Time.deltaTime);
                }
            }
        }
        if (CanScale)
        {
            if (Input.touchCount == 2)
            {

                Touch touchOne = Input.GetTouch(0);
                Touch touchTwo = Input.GetTouch(1);

                Vector2 tOneMoved = touchOne.position - touchOne.deltaPosition;
                Vector2 tTwoMoved = touchTwo.position - touchTwo.deltaPosition;

                float oldTouchDistance = Vector2.Distance(tOneMoved, tTwoMoved);
                float currentTouchDistance = Vector2.Distance(touchOne.position, touchTwo.position);

                float deltaDistance = (currentTouchDistance-oldTouchDistance)*Time.deltaTime;

                ScaleSize = Mathf.Clamp(ScaleSize+deltaDistance, minScale, MaxScale);
                transform.localScale = new Vector3(ScaleSize, ScaleSize, ScaleSize);
            }
        }
    }
}
